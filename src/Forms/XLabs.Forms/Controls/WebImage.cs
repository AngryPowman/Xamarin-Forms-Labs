
using Xamarin.Forms;

namespace XLabs.Forms.Controls
{
	/// <summary>
	/// Class WebImage.
	/// </summary>
	public class WebImage : Image
    {
		/// <summary>
		/// The image URL property
		/// </summary>
		public static readonly BindableProperty ImageUrlProperty = BindableProperty.Create<WebImage, string>(p => p.ImageUrl, default(string));

        /// <summary>
        /// The URL of the image to display from the web
        /// </summary>
        public string ImageUrl
        {
            get { return (string)GetValue(ImageUrlProperty); }
            set { SetValue(ImageUrlProperty, value); }
        }

		/// <summary>
		/// The default image property
		/// </summary>
		public static readonly BindableProperty DefaultImageProperty = BindableProperty.Create<WebImage, string>(p => p.DefaultImage, default(string));

        /// <summary>
        /// The path to the local image to display if the <c>ImageUrl</c> can't be loaded
        /// </summary>
        public string DefaultImage
        {
            get { return (string)GetValue(DefaultImageProperty); }
            set { SetValue(DefaultImageProperty, value); }
        }

    }
}
