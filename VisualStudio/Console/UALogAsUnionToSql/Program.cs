﻿// ReSharper disable StringLiteralTypo

// UALogAsUnionToSql: Logs OPC Unified Architecture data changes into an SQL database, using a subscription. Values of
// different data types are stored in separate columns.
//
// The database creation script is in the ExamplesNet\MSSQL\QuickOPCExamples.sql file under the product installation 
// directory. The example assumes that the database is already created.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UALogAsUnionToSql
{
    class Program
    {
        static void Main()
        {
            const string connectionString =
                "Data Source=(local);Initial Catalog=QuickOPCExamples;Integrated Security=true";

            // Define which server we will work with.
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            Console.WriteLine("Starting up...");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create all necessary ADO.NET objects.
                var adapter = new SqlDataAdapter("SELECT * FROM UALogAsUnion", connection);
                var dataSet = new DataSet();
                adapter.FillSchema(dataSet, SchemaType.Source, "UALogAsUnion");
                adapter.InsertCommand = new SqlCommandBuilder(adapter).GetInsertCommand();
                DataTable table = dataSet.Tables["UALogAsUnion"];
                Debug.Assert(!(table is null));

                Console.WriteLine("Logging for 30 seconds...");
                // Subscribe to OPC items, using an anonymous method to process the notifications.
                int[] handles = EasyUAClient.SharedInstance.SubscribeMultipleDataChanges(
                    new[]
                    {
                        // Data/Dynamic/Scalar/...
                        new UAMonitoredItemArguments(null, endpointDescriptor,
                            "nsu=http://test.org/UA/Data/ ;ns=2;i=10849", 100),     // Int32Value
                        new UAMonitoredItemArguments(null, endpointDescriptor,
                            "nsu=http://test.org/UA/Data/ ;ns=2;i=10853", 1000),    // FloatValue
                        new UAMonitoredItemArguments(null, endpointDescriptor,
                            "nsu=http://test.org/UA/Data/ ;ns=2;i=10855", 1000),    // StringValue
                        new UAMonitoredItemArguments(null, endpointDescriptor,
                            "nsu=http://test.org/UA/Data/ ;ns=2;i=10844", 1000)     // BooleanValue
                    },
                    (_, eventArgs) =>
                    {
                        Debug.Assert(!(eventArgs is null));

                        Console.Write(".");
                        // In this example, we only log valid data. Production logger would also log errors.
                        if (!(eventArgs.AttributeData is null))
                        {
                            // Fill a DataRow with the OPC data, and add it to a DataTable.
                            Debug.Assert(!(table.Rows is null));
                            table.Rows.Clear();
                            DataRow row = table.NewRow();
                            row["NodeID"] = eventArgs.Arguments.NodeDescriptor.NodeId;

                            if (!(eventArgs.AttributeData.Value is null))
                            {
                                Type type = eventArgs.AttributeData.Value.GetType();
                                // Store into a corresponding column. 
                                // The DataRow will make the conversion to a string.
                                if (type == typeof(Int16) || (type == typeof(Int32)) || type == typeof(Int64))
                                    row["IntegerValue"] = eventArgs.AttributeData.Value;
                                else if (type == typeof(Single) || type == typeof(Double))
                                    row["FloatValue"] = eventArgs.AttributeData.Value;
                                else if (type == typeof(string))
                                    row["StringValue"] = eventArgs.AttributeData.Value;
                                else if (type == typeof(Boolean))
                                    row["BooleanValue"] = eventArgs.AttributeData.Value;
                            }

                            row["SourceTimestamp"] = (eventArgs.AttributeData.SourceTimestamp < (DateTime)SqlDateTime.MinValue)
                                ? (DateTime)SqlDateTime.MinValue
                                : eventArgs.AttributeData.SourceTimestamp;
                            row["ServerTimestamp"] = (eventArgs.AttributeData.ServerTimestamp < (DateTime)SqlDateTime.MinValue)
                                ? (DateTime)SqlDateTime.MinValue
                                : eventArgs.AttributeData.ServerTimestamp;
                            row["StatusCode"] = eventArgs.AttributeData.StatusCode.InternalValue;

                            Debug.Assert(!(table.Rows is null));
                            table.Rows.Add(row);

                            // Update the underlying DataSet using an insert command.
                            adapter.Update(dataSet, "UALogAsUnion");
                        }
                    }
                    );
                System.Threading.Thread.Sleep(30 * 1000);
                Console.WriteLine();

                Console.WriteLine("Shutting down...");
                EasyUAClient.SharedInstance.UnsubscribeMultipleMonitoredItems(handles);
            }

            Console.WriteLine("Finished.");
        }
    }
}
