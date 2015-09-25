namespace XLabs.Platform.Device
{
    using Windows.System.Profile;

	/// <summary>
	/// Class Wp81Device.
	/// </summary>
	public class Wp81Device : IDevice
    {

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string Id
        {
            get { return HardwareIdentification.GetPackageSpecificToken(null).Id.ToString(); }
        }

		/// <summary>
		/// Gets the display.
		/// </summary>
		/// <value>The display.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public IDisplay Display
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the phone service.
		/// </summary>
		/// <value>The phone service.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public Services.IPhoneService PhoneService
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the battery.
		/// </summary>
		/// <value>The battery.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public IBattery Battery
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the accelerometer.
		/// </summary>
		/// <value>The accelerometer.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public IAccelerometer Accelerometer
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the gyroscope.
		/// </summary>
		/// <value>The gyroscope.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public IGyroscope Gyroscope
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the media picker.
		/// </summary>
		/// <value>The media picker.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public Services.Media.IMediaPicker MediaPicker
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the network.
		/// </summary>
		/// <value>The network.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public Services.INetwork Network
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the bluetooth hub.
		/// </summary>
		/// <value>The bluetooth hub.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public IBluetoothHub BluetoothHub
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the microphone.
		/// </summary>
		/// <value>The microphone.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public Services.Media.IAudioStream Microphone
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the file manager.
		/// </summary>
		/// <value>The file manager.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public Services.IO.IFileManager FileManager
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public string Name
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the firmware version.
		/// </summary>
		/// <value>The firmware version.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public string FirmwareVersion
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the hardware version.
		/// </summary>
		/// <value>The hardware version.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public string HardwareVersion
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the manufacturer.
		/// </summary>
		/// <value>The manufacturer.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public string Manufacturer
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the total memory.
		/// </summary>
		/// <value>The total memory.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public long TotalMemory
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the language code.
		/// </summary>
		/// <value>The language code.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public string LanguageCode
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the time zone offset.
		/// </summary>
		/// <value>The time zone offset.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public double TimeZoneOffset
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the time zone.
		/// </summary>
		/// <value>The time zone.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public string TimeZone
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Gets the orientation.
		/// </summary>
		/// <value>The orientation.</value>
		/// <exception cref="System.NotImplementedException"></exception>
		public Enums.Orientation Orientation
        {
            get { throw new System.NotImplementedException(); }
        }

		/// <summary>
		/// Launches the URI asynchronous.
		/// </summary>
		/// <param name="uri">The URI.</param>
		/// <returns>System.Threading.Tasks.Task&lt;System.Boolean&gt;.</returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public System.Threading.Tasks.Task<bool> LaunchUriAsync(System.Uri uri)
        {
            throw new System.NotImplementedException();
        }
    }
}