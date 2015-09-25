namespace XLabs
{
    /// <summary>
    /// Class Vector3.
    /// </summary>
    public class Vector3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3"/> class.
        /// </summary>
        public Vector3() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        public Vector3(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the z.
        /// </summary>
        /// <value>The z.</value>
        public double Z { get; set; }
    }
}
