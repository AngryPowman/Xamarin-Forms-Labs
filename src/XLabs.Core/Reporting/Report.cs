namespace XLabs.Reporting
{
    using System.Collections.Generic;

    /// <summary>
    /// Static Report class.
    /// </summary>
    public static class Report
    {
        /// <summary>
        /// The reporters
        /// </summary>
        private static readonly List<IReport> Reporters;

        /// <summary>
        /// Initializes static members of the <see cref="Report"/> class.
        /// </summary>
        static Report()
        {
            Reporters = new List<IReport>(); 
        }

        /// <summary>
        /// Adds the specified report.
        /// </summary>
        /// <param name="report">The report.</param>
        public static void Add(IReport report)
        {
            Reporters.Add(report);
        }

        /// <summary>
        /// Removes the specified report.
        /// </summary>
        /// <param name="report">The report.</param>
        public static void Remove(IReport report)
        {
            Reporters.Remove(report);
        }

        #region IReport calls

        /// <summary>
        /// Exceptions the specified exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public static void Exception(System.Exception exception)
        {
            foreach (var reporter in Reporters)
            {
                reporter.Exception(exception);
            }
        }

        #endregion
    }
}