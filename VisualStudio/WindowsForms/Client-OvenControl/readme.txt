Specification
=============

The OPC server that you need to connect is KepServerEX from Kepware, using OPC-DA (Data Access) specification. It uses 
Siemens S5 (3964R driver) to connect to a PLC. The PLC controls an industrial oven, with elements listed below.

•	A fan with variable speed (tag: FanPower).
•	A heater element with variable power (tag: HeaterPower).
•	Oven (inside) temperature sensor (tag: OvenTemp).
•	Heater element temperature sensor (tag: HeaterTemp).
•	Fan speed sensor (tag: FanSpeed).

The PLC already has a control loop that has a single setpoint (tag: TempSetpoint), for the oven temperature.

The application will be a desktop program, for main part just a single form, with following functionality:
-	Every 10 seconds, display values of all known variables on the form.
-	Append all obtained values to some kind of a log file, while the application is running. You can choose the file 
	format.
-	Change the oven temperature background color to blue as when it is less than 5 degrees or more below the setpoint, 
	and change it to red as long as it is 5 degrees or more above the setpoint.
-	Change the heater temperature background color to red when it is less 200 degrees or above.
-	Have the ability to enter a new value for temperature setpoint, and put it into effect by pressing a button.
-	There should be some error handling for the OPC operations, so that errors do not crash the application, and also 
	if values are not coming in, the reason is indicated.
	
The configuration file for the server is: OvenControl.opf.
 
For development, the client application and the OPC server will be on the same machine. The production deployment will 
be on separate machines, your application should support this scenario.



Implementation Note
===================
In this example, periodic reads are used to obtain value from the OPC Server. Although QuickOPC attempts to optimize the
periodic reads, you should rather use subscriptions to receive value changes, especially with faster update rates and larger
number of items.
