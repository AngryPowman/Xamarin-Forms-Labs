// ***********************************************************************
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XLabs.Forms.Controls;

[assembly: ExportRenderer(typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]

namespace XLabs.Forms.Controls
{
    using System.ComponentModel;
    using Extensions;

	/// <summary>
	/// Class ExtendedButtonRenderer.
	/// </summary>
	public class ExtendedButtonRenderer : ButtonRenderer
    {
		/// <summary>
		/// Called when [element changed].
		/// </summary>
		/// <param name="e">The e.</param>
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            SetAlignment();
        }

		/// <summary>
		/// Handles the <see cref="E:ElementPropertyChanged" /> event.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="PropertyChangedEventArgs"/> instance containing the event data.</param>
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "VerticalContentAlignment":
                case "HorizontalContentAlignment":
                    SetAlignment();
                    break;
                default:
                    base.OnElementPropertyChanged(sender, e);
                    break;
            }
        }

		/// <summary>
		/// Sets the alignment.
		/// </summary>
		private void SetAlignment()
        {
            var element = this.Element as ExtendedButton;

            if (element == null || this.Control == null)
            {
                return;
            }

            this.Control.Gravity = element.VerticalContentAlignment.ToDroidVerticalGravity() |
                element.HorizontalContentAlignment.ToDroidHorizontalGravity();
        }
    }
}