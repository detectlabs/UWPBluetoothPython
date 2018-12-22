using System;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;

namespace UWPBluetoothPython
{
    public class Enumeration
    {
        public Enumeration()
        {

        }

        public async Task<BluetoothLEDevice> BluetoothLEDeviceFromIdAsync(string id)
        {
            BluetoothLEDevice ble = await BluetoothLEDevice.FromIdAsync(id);
            GattDeviceServicesResult results = await ble.GetGattServicesAsync();
            return ble;
        }

        static string[] requestedProperties = { "System.Devices.Aep.DeviceAddress", "System.Devices.Aep.IsConnected" };

        DeviceWatcher deviceWatcher =
                    DeviceInformation.CreateWatcher(
                            BluetoothLEDevice.GetDeviceSelectorFromPairingState(false),
                            requestedProperties,
                            DeviceInformationKind.AssociationEndpoint);

    }
}