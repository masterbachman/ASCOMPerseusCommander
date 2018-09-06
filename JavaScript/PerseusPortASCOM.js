WScript.Echo("Hello world");


/*var chooser = new ActiveXObject("DriverHelper.Chooser");
chooser.DeviceType = "Switch";
var driverName = chooser.Choose();
WScript.Echo("Driver name: " + driverName);
*/

var driverName = "ASCOM.PerseusServer.Switch";

var sw = new ActiveXObject(driverName);

WScript.Echo("Connecting...");
sw.Connected = true;
WScript.Echo("Connected!");

var numSwitches = sw.MaxSwitch;
WScript.Echo(numSwitches + " switches available");

for (var i = 0; i < numSwitches; i++) {
	var name = sw.GetSwitchName(i);
	WScript.Echo("Switch " + i + ": " + name);
}

var port = sw.GetSwitchValue(0);
WScript.Echo("Port is " + port);

sw.SetSwitchValue(0, 4);


/*

var isOn = sw.GetSwitch(0);
WScript.Echo("Switch 0 is " + isOn);

sw.SetSwitch(0, true);

var isOn = sw.GetSwitch(0);
WScript.Echo("Switch 0 is " + isOn);

sw.SetSwitch(0, false);

var isOn = sw.GetSwitch(0);
WScript.Echo("Switch 0 is " + isOn);

*/s