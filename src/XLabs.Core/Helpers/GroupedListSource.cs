namespace XLabs.Helpers
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Observable collection 
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class GroupedListSource<TKey, T> : ObservableCollection<ListGroup<TKey, T>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedListSource{TKey, T}"/> class.
        /// </summary>
        public GroupedListSource()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedListSource{TKey, T}"/> class that contains elements copied from the specified collection.
        /// </summary>
        /// <param name="items">The collection from which the elements are copied.</param>
        public GroupedListSource(IEnumerable<ListGroup<TKey, T>> items)
            : base(items)
        {

        }
    }
}
