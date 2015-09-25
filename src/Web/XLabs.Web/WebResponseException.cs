// ***********************************************************************
// <copyright file="WebResponseException.cs" company="">
//     Copyright ©  2014
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Net;

namespace XLabs.Web
{
	/// <summary>
	/// Class WebResponseException.
	/// </summary>
	public class WebResponseException : Exception
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="WebResponseException"/> class.
		/// </summary>
		public WebResponseException()
        {
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public WebResponseException(string message) : base(message)
        {

        }

		/// <summary>
		/// Initializes a new instance of the <see cref="WebResponseException"/> class.
		/// </summary>
		/// <param name="status">The status.</param>
		/// <param name="message">The message.</param>
		public WebResponseException(HttpStatusCode status, string message)
            : base(message)
        {
            this.Status = status;
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public WebResponseException(string message, Exception innerException) 
            : base(message, innerException)
        {

        }

		/// <summary>
		/// Initializes a new instance of the <see cref="WebResponseException"/> class.
		/// </summary>
		/// <param name="status">The status.</param>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		public WebResponseException(HttpStatusCode status, string message, Exception innerException)
            : base(message, innerException)
        {
            this.Status = status;
        }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		public HttpStatusCode Status { get; set; }
    }
}

