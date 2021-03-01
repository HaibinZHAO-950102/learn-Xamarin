using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AirCase2.Models;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE.Abstractions.Exceptions;
using Plugin.Permissions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AirCase2
{
    public partial class BluetoothConnection : ContentPage
    {
        //IBluetoothLE ble;
        //IAdapter adapter;
        //ObservableCollection<IDevice> deviceList;
        //IDevice device;

        public BluetoothConnection()
        {
            InitializeComponent();
            //ble = CrossBluetoothLE.Current;
            //adapter = CrossBluetoothLE.Current.Adapter;
            //deviceList = new ObservableCollection<IDevice>();
            //btlist.ItemsSource = deviceList;

            //RequestPermissions();
        }

        //private async void RequestPermissions()
        //{
        //    var status = await CrossPermissions.Current.RequestPermissionAsync<LocationAlwaysPermission>();
        //    Console.WriteLine("requested location permission: " + status.ToString());
        //}

        //async void btlist_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    var dataviewmodel = new DataViewModel();

        //    if (e.SelectedItem == null) return;
        //    IDevice selecteddevice = e.SelectedItem as IDevice;
        //    ((ListView)sender).SelectedItem = null;
        //    Console.WriteLine("seleted is " + selecteddevice.Name);
        //    try
        //    {
        //        await adapter.ConnectToDeviceAsync(selecteddevice);
        //        Console.WriteLine("Connect to " + selecteddevice.Name + " successfully!");
        //        await DisplayAlert("Successful", "Connect to " + selecteddevice.Name + " successfully!", "Perfect!");
        //        dataviewmodel.record_device(selecteddevice);
        //    }
        //    catch (DeviceConnectionException)
        //    {
        //        try
        //        {
        //            await adapter.ConnectToKnownDeviceAsync(new Guid("guid"));
        //            //Console.WriteLine(selecteddevice.Name + " is already connected");
        //            //await DisplayAlert("Successful", selecteddevice.Name + " is already connected", "Perfect!");
        //        }
        //        catch (DeviceConnectionException)
        //        {
        //            await DisplayAlert("Error", "Cant connet to that device", "OK");
        //        }
        //    }


        //}

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    var state = ble.State;

        //    if (state.ToString() == "Off")
        //    {
        //        await DisplayAlert("Bluetooth State", "Bluetooth is off, please turn on the Bluetooth.", "OK");
        //    }
        //    else
        //    {
        //        Console.WriteLine("BLE STATUS IS: " + state.ToString());
        //    }


        //    deviceList.Clear();

        //    adapter.DeviceDiscovered += (s, a) =>
        //    {
        //        if (a.Device.Name == null | a.Device.Id == null) { }
        //        else
        //        {
        //            deviceList.Add(a.Device);
        //            Console.WriteLine(deviceList.Count.ToString() + " devices was found.");
        //        }

        //    };

        //    if (!ble.Adapter.IsScanning)
        //    {
        //        await adapter.StartScanningForDevicesAsync();
        //    }
        //}
    }
}
