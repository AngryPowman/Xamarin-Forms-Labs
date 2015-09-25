namespace XLabs.Forms.Extensions
{
    using System;
    using UIKit;
    using Xamarin.Forms;

	/// <summary>
	/// Class AlignmentExtensions.
	/// </summary>
	public static class AlignmentExtensions
    {
		/// <summary>
		/// To the content vertical alignment.
		/// </summary>
		/// <param name="alignment">The alignment.</param>
		/// <returns>UIControlContentVerticalAlignment.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		public static UIControlContentVerticalAlignment ToContentVerticalAlignment(this TextAlignment alignment)
        {
            switch (alignment)
            {
                case TextAlignment.Center:
                    return UIControlContentVerticalAlignment.Center;
                case TextAlignment.End:
                    return UIControlContentVerticalAlignment.Bottom;
                case TextAlignment.Start:
                    return UIControlContentVerticalAlignment.Top;
            }

            throw new InvalidOperationException(alignment.ToString());
        }

		/// <summary>
		/// To the content horizontal alignment.
		/// </summary>
		/// <param name="alignment">The alignment.</param>
		/// <returns>UIControlContentHorizontalAlignment.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		public static UIControlContentHorizontalAlignment ToContentHorizontalAlignment(this TextAlignment alignment)
        {
            switch (alignment)
            {
                case TextAlignment.Center:
                    return UIControlContentHorizontalAlignment.Center;
                case TextAlignment.End:
                    return UIControlContentHorizontalAlignment.Right;
                case TextAlignment.Start:
                    return UIControlContentHorizontalAlignment.Left;
            }

            throw new InvalidOperationException(alignment.ToString());
        }
    }
}