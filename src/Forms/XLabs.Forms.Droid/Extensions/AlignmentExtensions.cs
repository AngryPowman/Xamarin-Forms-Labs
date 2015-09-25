namespace XLabs.Forms.Extensions
{
    using System;
    using Android.Views;
    using DroidTextAlignment = Android.Views.TextAlignment;
    using TextAlignment = Xamarin.Forms.TextAlignment;

	/// <summary>
	/// Class AlignmentExtensions.
	/// </summary>
	public static class AlignmentExtensions
    {
		/// <summary>
		/// To the droid text alignment.
		/// </summary>
		/// <param name="alignment">The alignment.</param>
		/// <returns>DroidTextAlignment.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		public static DroidTextAlignment ToDroidTextAlignment(this TextAlignment alignment)
        {
            switch (alignment)
            {
                case TextAlignment.Center:
                    return DroidTextAlignment.Center;
                case TextAlignment.End:
                    return DroidTextAlignment.ViewEnd;
                case TextAlignment.Start:
                    return DroidTextAlignment.ViewStart;
            }

            throw new InvalidOperationException(alignment.ToString());
        }

		/// <summary>
		/// To the droid horizontal gravity.
		/// </summary>
		/// <param name="alignment">The alignment.</param>
		/// <returns>GravityFlags.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		public static GravityFlags ToDroidHorizontalGravity(this TextAlignment alignment)
        {
            switch (alignment)
            {
            case TextAlignment.Center:
                return GravityFlags.CenterHorizontal;
            case TextAlignment.End:
                return GravityFlags.Right;
            case TextAlignment.Start:
                return GravityFlags.Left;
            }

            throw new InvalidOperationException(alignment.ToString());
        }

		/// <summary>
		/// To the droid vertical gravity.
		/// </summary>
		/// <param name="alignment">The alignment.</param>
		/// <returns>GravityFlags.</returns>
		/// <exception cref="System.InvalidOperationException"></exception>
		public static GravityFlags ToDroidVerticalGravity(this TextAlignment alignment)
        {
            switch (alignment)
            {
                case TextAlignment.Center:
                    return GravityFlags.CenterVertical;
                case TextAlignment.End:
                    return GravityFlags.Bottom;
                case TextAlignment.Start:
                    return GravityFlags.Top;
            }

            throw new InvalidOperationException(alignment.ToString());
        }
    }
}