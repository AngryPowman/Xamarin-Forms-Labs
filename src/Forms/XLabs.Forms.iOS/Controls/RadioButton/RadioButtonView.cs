using CoreGraphics;
using Foundation;
using UIKit;

namespace XLabs.Forms.Controls
{
	/// <summary>
	/// Class RadioButtonView.
	/// </summary>
	[Register("RadioButtonView")]
    public class RadioButtonView : UIButton
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="RadioButtonView"/> class.
		/// </summary>
		public RadioButtonView()
        {
            Initialize();
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="RadioButtonView"/> class.
		/// </summary>
		/// <param name="bounds">The bounds.</param>
		public RadioButtonView(CGRect bounds)
            : base(bounds)
        {
            Initialize();
        }


		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="RadioButtonView"/> is checked.
		/// </summary>
		/// <value><c>true</c> if checked; otherwise, <c>false</c>.</value>
		public bool Checked
        {
            set { this.Selected = value; }
            get { return this.Selected; }
        }

		/// <summary>
		/// Sets the text.
		/// </summary>
		/// <value>The text.</value>
		public string Text
        {
            set { this.SetTitle(value, UIControlState.Normal); }
            
        }

		/// <summary>
		/// Initializes this instance.
		/// </summary>
		void Initialize()
        {
            this.AdjustEdgeInsets();
            this.ApplyStyle();

            this.TouchUpInside += (sender, args) => this.Selected = !this.Selected;
        }

		/// <summary>
		/// Adjusts the edge insets.
		/// </summary>
		void AdjustEdgeInsets()
        {
            const float inset = 8f;

            this.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
            this.ImageEdgeInsets = new UIEdgeInsets(0f, inset, 0f, 0f);
            this.TitleEdgeInsets = new UIEdgeInsets(0f, inset * 2, 0f, 0f);
        }

		/// <summary>
		/// Applies the style.
		/// </summary>
		void ApplyStyle()
        {
            this.SetImage(UIImage.FromBundle("Images/RadioButton/checked.png"), UIControlState.Selected);
            this.SetImage(UIImage.FromBundle("Images/RadioButton/unchecked.png"), UIControlState.Normal);
        }
    }
}