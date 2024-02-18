<Query Kind="Statements">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <NuGetReference>Rx-Main</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

var observer = UAWriteValueObserver.Create<int>(
	"opc.tcp://opcua.demo-this.com:51210/UA/SampleServer",
	"nsu=http://test.org/UA/Data/;i=10389");

Observable
	.Interval(TimeSpan.FromSeconds(0.5))
	.Select(l => (int)l)
	.Subscribe(observer);
	
Thread.Sleep(10*1000);

