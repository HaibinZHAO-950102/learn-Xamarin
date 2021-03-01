using System;
using System.Collections.Generic;
using AirCase.Models;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using Xamarin.Forms;

namespace AirCase
{
    public partial class DataReading : ContentPage
    {
        IBluetoothLE ble;
        IAdapter adapter;
        IDevice aircasedevice;

        public DataReading()
        {
            InitializeComponent();
            ble = CrossBluetoothLE.Current;
            adapter = CrossBluetoothLE.Current.Adapter;

            
        }

        private void Getdeviceinformation()
        {
            var dataviewmodel = new DataViewModel();
            aircasedevice = dataviewmodel.GetDevice();
            Console.WriteLine("Got the Device " + aircasedevice.Name.ToString());
        }

        private void connectbluetooth()
        {
            //adapter.ConnectToDeviceAsync(device);

            //IList<IService> Services;
            //IService Service;

            //Services = (IList<IService>) dataviewmodel.selected_device.GetServicesAsync();
            //Service = (IService)dataviewmodel.selected_device.GetServiceAsync(dataviewmodel.selected_device.Id);

            //IList<ICharacteristic> Characteristics;
            //ICharacteristic Characteristic;

            //var characteristics = await Service.GetCharacteristicsAsync();
            //Guid idGuid = Guid.Parse("guid");
            //Characteristic = await Service.GetCharacteristicAsync(idGuid);

            //IDescriptor descriptor;
            //IList<IDescriptor> descriptors;

            //descriptors = (IList<IDescriptor>)await Characteristic.GetDescriptorsAsync();
            //descriptor = await Characteristic.GetDescriptorAsync(Guid.Parse("guid"));
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Getdeviceinformation();
            //connectbluetooth();
            if (adapter.ConnectedDevices == null)
            {
                Console.WriteLine("Haven't connected any device.");
            }
            else
            {
                Console.WriteLine("Connected");
            }
        }
    }
}
