namespace XLabs.Sample.ViewModel
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Input;
    using Platform.Device;
    using XLabs.Data;

    public class BluetoothViewModel : ObservableObject
    {
        private readonly IBluetoothHub hub;
        private readonly RelayCommand scan;
        private readonly RelayCommand openSettings;
        //private readonly RelayCommand findSerialPorts;
        private IReadOnlyCollection<IBluetoothDevice> devices;
        private IReadOnlyCollection<string> serialPorts;

        private bool isBusy;

        public BluetoothViewModel(IBluetoothHub hub)
        {
            this.hub = hub;
            this.scan = new RelayCommand(async () => this.Devices = await this.hub.GetPairedDevices(), () => this.Enabled && !this.IsBusy);
            //this.findSerialPorts = new RelayCommand(async () => this.SerialPorts = await this.hub.FindService(BluetoothServiceType.StandardServices.First(a => a.Type == BluetoothServiceType.ServiceType.SerialPort).ServiceId), () => this.Enabled && !this.IsBusy);
            this.openSettings = new RelayCommand(async () => await this.hub.OpenSettings(), () => this.hub != null && !this.IsBusy);
        }

        public bool Enabled
        {
            get { return this.hub != null && this.hub.Enabled; }
        }

        public bool IsBusy
        {
            get { return this.isBusy; }
            set
            {
                if (this.SetProperty(ref this.isBusy, value))
                {
                    this.scan.RaiseCanExecuteChanged();
                    this.openSettings.RaiseCanExecuteChanged();
                    //this.findSerialPorts.RaiseCanExecuteChanged();
                }
            }
        }

        public IReadOnlyCollection<IBluetoothDevice> Devices
        {
            get { return this.devices; }
            private set { this.SetProperty(ref this.devices, value); }
        }

        public IReadOnlyCollection<string> SerialPorts
        {
            get { return this.serialPorts; }
            private set { this.SetProperty(ref this.serialPorts, value); }
        }

        public ICommand Scan { get { return this.scan; } }
        public ICommand OpenSettings { get { return this.openSettings; } }
        //public ICommand FindSerialPorts { get { return this.findSerialPorts; } }
    }
}