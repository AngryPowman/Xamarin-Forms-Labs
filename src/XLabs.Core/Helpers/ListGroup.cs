namespace XLabs.Helpers
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Observable collection grouped by a key.
    /// </summary>
    /// <typeparam name="TKey">Key value type.</typeparam>
    /// <typeparam name="T">Group value type.</typeparam>
    public class ListGroup<TKey, T> : ObservableCollection<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroup{TKey, T}"/> class.
        /// </summary>
        public ListGroup()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroup{TKey, T}"/> class.
        /// </summary>
        /// <param name="items">The collection from which the elements are copied.</param>
        public ListGroup(IEnumerable<T> items)
            : base(items)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroup{TKey, T}"/> class.
        /// </summary>
        /// <param name="key">Key value.</param>
        /// <param name="items">The collection from which the elements are copied.</param>
        public ListGroup(TKey key, IEnumerable<T> items)
            : base(items)
        {
            this.Key = key;
        }

        /// <summary>
        /// Gets or sets the key for the group.
        /// </summary>
        public TKey Key { get; set; }
    }
}
