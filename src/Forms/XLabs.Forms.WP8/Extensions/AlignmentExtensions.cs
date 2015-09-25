namespace XLabs.Forms
{
    using System;
    using System.Windows;
    using TextAlignment = Xamarin.Forms.TextAlignment;

	/// <summary>
	/// Class AlignmentExtensions.
	/// </summary>
	public static class AlignmentExtensions
    {
		/// <summary>
		/// To the content vertical alignment.
		/// </summary>
		/// <param name="alignment">The alignment.</param>
		/// <returns>VerticalAlignment.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		public static VerticalAlignment ToContentVerticalAlignment(this TextAlignment alignment)
        {
            switch (alignment)
            {
                case TextAlignment.Center:
                    return VerticalAlignment.Center;
                case TextAlignment.End:
                    return VerticalAlignment.Bottom;
                case TextAlignment.Start:
                    return VerticalAlignment.Top;
            }

            throw new InvalidOperationException(alignment.ToString());
        }

		/// <summary>
		/// To the content horizontal alignment.
		/// </summary>
		/// <param name="alignment">The alignment.</param>
		/// <returns>HorizontalAlignment.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		public static HorizontalAlignment ToContentHorizontalAlignment(this TextAlignment alignment)
        {
            switch (alignment)
            {
                case TextAlignment.Center:
                    return HorizontalAlignment.Center;
                case TextAlignment.End:
                    return HorizontalAlignment.Right;
                case TextAlignment.Start:
                    return HorizontalAlignment.Left;
            }

            throw new InvalidOperationException(alignment.ToString());
        }
    }
}