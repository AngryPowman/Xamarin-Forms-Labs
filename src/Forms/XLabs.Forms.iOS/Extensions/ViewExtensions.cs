using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace XLabs.Forms
{
	/// <summary>
	/// Class ViewExtensions.
	/// </summary>
	public static class ViewExtensions
    {
		//private static Lazy<PropertyInfo> InternalChildrenPropertyInfo = new Lazy<PropertyInfo>(() => typeof(View).GetProperty("InternalChildren", BindingFlags.NonPublic | BindingFlags.Instance));

		/// <summary>
		/// Gets the internal children.
		/// </summary>
		/// <param name="view">The view.</param>
		/// <returns>ObservableCollection&lt;Element&gt;.</returns>
		public static ObservableCollection<Element> GetInternalChildren(this View view)
        {
            var internalPropertyInfo = view.GetType().GetProperty("InternalChildren", BindingFlags.NonPublic | BindingFlags.Instance);

            return (internalPropertyInfo == null) ? null : internalPropertyInfo.GetValue(view) as ObservableCollection<Element>;
        }
    }
}
