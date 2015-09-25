using Xamarin.Forms;

using XLabs.Forms.Pages;

[assembly: ExportRenderer(typeof(ExtendedMasterDetailPage), typeof(ExtendedMasterDetailRenderer))]

namespace XLabs.Forms.Pages
{
    using Xamarin.Forms.Platform.WinPhone;

	/// <summary>
	/// Class ExtendedMasterDetailRenderer.
	/// </summary>
	public class ExtendedMasterDetailRenderer : MasterDetailRenderer
    {
    }
}
