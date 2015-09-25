using System;

namespace XLabs
{
    /// <summary>
    /// Class DateTimeExtensions.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// The unix time
        /// </summary>
        public static DateTime UnixTime = new DateTime(1970, 1, 1);

        /// <summary>
        /// Sinces the unix time.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan SinceUnixTime(this DateTime time)
        {
            return time - UnixTime;
        }

        /// <summary>
        /// Sinces the unix time.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan SinceUnixTime(this DateTimeOffset time)
        {
            return time - UnixTime;
        }

        /// <summary>
        /// Sinces the unix time.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns>System.Nullable&lt;TimeSpan&gt;.</returns>
        public static TimeSpan? SinceUnixTime(this DateTime? time)
        {
            return time - UnixTime;
        }

        /// <summary>
        /// Sinces the unix time.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns>System.Nullable&lt;TimeSpan&gt;.</returns>
        public static TimeSpan? SinceUnixTime(this DateTimeOffset? time)
        {
            return time - UnixTime;
        }

        /// <summary>
        /// Fulls the milliseconds.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns>System.Nullable&lt;System.Int64&gt;.</returns>
        public static long? FullMilliseconds(this TimeSpan? timeSpan)
        {
            return timeSpan == null ? default(long?) : (long)timeSpan.Value.TotalMilliseconds;
        }
    }
}
