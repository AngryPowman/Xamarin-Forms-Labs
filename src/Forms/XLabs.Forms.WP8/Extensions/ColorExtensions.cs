namespace XLabs.Forms
{
	using System.Windows.Media;

	/// <summary>
	/// Class ColorExtensions.
	/// </summary>
	public static class ColorExtensions
	{
		/// <summary>
		/// To the brush.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns>Brush.</returns>
		public static Brush ToBrush(this Xamarin.Forms.Color color)
		{
			return new SolidColorBrush(color.ToMediaColor());
		}

		/// <summary>
		/// To the color of the media.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns>System.Windows.Media.Color.</returns>
		public static System.Windows.Media.Color ToMediaColor(this Xamarin.Forms.Color color)
		{
			return System.Windows.Media.Color.FromArgb((byte)(color.A * 255.0), (byte)(color.R * 255.0), (byte)(color.G * 255.0), (byte)(color.B * 255.0));
		}
	}
}
