# UWPBluetoothPython
Library exposing UWP Bluetooth libraries to be used with Python

Targets UWP [Build 16299 (Fall Creators Update, version 1709)](https://docs.microsoft.com/en-us/windows/uwp/updates-and-versions/choose-a-uwp-version?ocid=VSClient_VerX_NewProject_version)

The current version of [pythonnet](https://github.com/pythonnet/pythonnet) v2.3.0 seems to only support UWP 5.44 and below.

**Important:**  
When adding new namespaces, sometimes the base namespace will need to be references in order for the sub namespace to be found

## Debugging tools  
Assembly Binding Log Viewer [fuslogvw.exe](https://docs.microsoft.com/en-us/dotnet/framework/tools/fuslogvw-exe-assembly-binding-log-viewer)  

.Net Decompliler [ILSpy](https://github.com/icsharpcode/ILSpy)