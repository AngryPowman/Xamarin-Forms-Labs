
namespace XLabs.Forms.Mvvm
{
	/// <summary>
	/// Interface IPage
	/// </summary>
	public interface IPage
	{
		/// <summary>
		/// Gets or sets the navigation.
		/// </summary>
		/// <value>The navigation.</value>
		Xamarin.Forms.INavigation Navigation { get; }

		/// <summary>
		/// Gets or sets the binding context.
		/// </summary>
		/// <value>The binding context.</value>
		object BindingContext { get; set; }

		/// <summary>
		/// Navigatings to.
		/// </summary>
		/// <param name="previousPage">The previous page.</param>
		/// <param name="argument">The argument.</param>
		void NavigatingTo(IPage previousPage, object argument);

		/// <summary>
		/// Navigatings from.
		/// </summary>
		/// <param name="nextPage">The next page.</param>
		void NavigatingFrom(IPage nextPage);

		/// <summary>
		/// To the native page.
		/// </summary>
		/// <returns>System.Object.</returns>
		object ToNativePage();
	}

	//public class XPage : Xamarin.Forms.Page, IPage
	//{
	//	public new Xamarin.Forms.INavigation Navigation { get { return base.Navigation; } }

	//	public virtual void NavigatingTo(IPage previousPage, object argument)
	//	{
	//	}

	//	public virtual void NavigatingFrom(IPage nextPage)
	//	{
	//	}

	//	public object ToNativePage()
	//	{
	//		var p = (Xamarin.Forms.Page)this;

	//		return p;
	//	}
	//}
}
