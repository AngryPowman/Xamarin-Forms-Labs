using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;
using XLabs.Forms.Controls;

[assembly: ExportRenderer(typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]

namespace XLabs.Forms.Controls
{
    using System.ComponentModel;

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

            var element = this.Element;

            if (element == null || this.Control == null)
            {
                return;
            }

            this.Control.VerticalContentAlignment = this.Element.VerticalContentAlignment.ToContentVerticalAlignment();
            this.Control.HorizontalContentAlignment = this.Element.HorizontalContentAlignment.ToContentHorizontalAlignment();
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
                    this.Control.VerticalContentAlignment = this.Element.VerticalContentAlignment.ToContentVerticalAlignment();
                    break;
                case "HorizontalContentAlignment":
                    this.Control.HorizontalContentAlignment =
                        this.Element.HorizontalContentAlignment.ToContentHorizontalAlignment();
                    break;
                default:
                    base.OnElementPropertyChanged(sender, e);
                    break;
            }
        }

		/// <summary>
		/// Gets the element.
		/// </summary>
		/// <value>The element.</value>
		public new ExtendedButton Element
        {
            get
            {
                return base.Element as ExtendedButton;
            }
        }
    }
}