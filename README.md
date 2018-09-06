# ASCOM Perseus Commander :telescope:

![GitHub](https://img.shields.io/github/license/mashape/apistatus.svg?style=for-the-badge) [![ASCOM DOWNLOAD](https://img.shields.io/badge/ASCOM-Driver--Download-blue.svg?longCache=true&style=for-the-badge&logo=windows)](https://www.optecinc.com/astronomy/catalog/perseus/perseus_4-port.htm)

### Description
ASCOM external driver control for Optec's Perseus Commander. 

### Software Demo
![alt text](https://github.com/masterbachman/ASCOMPerseusCommander/blob/master/Images/ASCOMPerseusControl.gif)

### API
```JavaScript
supportedActions.Add("GetPort1Name");
supportedActions.Add("GetPort2Name");
supportedActions.Add("GetPort3Name");
supportedActions.Add("GetPort4Name");
supportedActions.Add("SetPort1Name");
supportedActions.Add("SetPort2Name");
supportedActions.Add("SetPort3Name");
supportedActions.Add("SetPort4Name");
supportedActions.Add("GetFWVersion");

supportedActions.Add("IsHomed");
supportedActions.Add("Home");
 ```
