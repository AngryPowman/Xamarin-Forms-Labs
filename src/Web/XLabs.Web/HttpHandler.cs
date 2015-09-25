// ***********************************************************************
// <copyright file="HttpHandler.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XLabs.Web
{
	/// <summary>
	/// Class HttpHandler.
	/// </summary>
	public class HttpHandler : HttpClientHandler
    {
		/// <summary>
		/// The cookie header
		/// </summary>
		private const string CookieHeader = "Set-Cookie";

		/// <summary>
		/// The cookie received
		/// </summary>
		public EventHandler<EventArgs<Cookie>> CookieReceived;

		/// <summary>
		/// send as an asynchronous operation.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            if (response.IsSuccessStatusCode && response.Headers.Contains(CookieHeader))
            {
                try
                {
                    var cookie = response.Headers.GetValues(CookieHeader).First().Split(';')[0].Split('=');
                    this.CookieReceived.Invoke<Cookie>(this, new Cookie(cookie[0], cookie[1]));
                }
                catch
                {

                }
            }

            return response;
        }
    }
}
