using Windows.Devices.Radios;
using System;

namespace UWPBluetoothPython
{
    public class UWPRadios
    {
        private Radio radio;

        public UWPRadios()
        {
            var something = radio.State;
        }

        private async void requestAccess()
        {
            var accessLevel = await Radio.RequestAccessAsync();

        }

        private async void GetRadios()
        {
            var radios = await Radio.GetRadiosAsync();
        }
    }
}