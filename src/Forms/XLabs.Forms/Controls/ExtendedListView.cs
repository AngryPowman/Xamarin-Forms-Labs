using System;
using Xamarin.Forms;

namespace XLabs.Forms.Controls
{
	/// <summary>
	/// Class ExtendedListView.
	/// </summary>
	public class ExtendedListView : ListView
    {
		/// <summary>
		/// The item template selector property
		/// </summary>
		public static readonly BindableProperty ItemTemplateSelectorProperty = BindableProperty.Create<ExtendedListView, DataTemplateSelector>(x => x.ItemTemplateSelector, default(DataTemplateSelector), propertyChanged: OnDataTemplateSelectorChanged);

        private DataTemplateSelector currentItemSelector;
		/// <summary>
		/// Gets or sets the item template selector.
		/// </summary>
		/// <value>The item template selector.</value>
		public DataTemplateSelector ItemTemplateSelector
        {
            get
            {
                return (DataTemplateSelector)GetValue(ItemTemplateSelectorProperty);
            }
            set
            {
                SetValue(ItemTemplateSelectorProperty, value);
            }
        }

		/// <summary>
		/// Called when [data template selector changed].
		/// </summary>
		/// <param name="bindable">The bindable.</param>
		/// <param name="oldvalue">The oldvalue.</param>
		/// <param name="newvalue">The newvalue.</param>
		private static void OnDataTemplateSelectorChanged(BindableObject bindable, DataTemplateSelector oldvalue, DataTemplateSelector newvalue)
        {
            ((ExtendedListView)bindable).OnDataTemplateSelectorChanged(oldvalue, newvalue);
        }

		/// <summary>
		/// Called when [data template selector changed].
		/// </summary>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		/// <exception cref="System.ArgumentException">Cannot set both ItemTemplate and ItemTemplateSelector;ItemTemplateSelector</exception>
		protected virtual void OnDataTemplateSelectorChanged(DataTemplateSelector oldValue, DataTemplateSelector newValue)
        {
            // check to see we don't have an ItemTemplate set
            if (ItemTemplate != null && newValue != null)
                throw new ArgumentException("Cannot set both ItemTemplate and ItemTemplateSelector", "ItemTemplateSelector");

            this.currentItemSelector = newValue;
        }

		/// <summary>
		/// Creates the default.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>Cell.</returns>
		protected override Cell CreateDefault(object item)
        {
            var cell = this.CellFor(item, this.currentItemSelector);

            return cell ?? base.CreateDefault(item);
        }

    }

}