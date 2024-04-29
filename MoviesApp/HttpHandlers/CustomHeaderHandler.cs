using System.Net.Http.Headers;

namespace MoviesApp.HttpHandlers
{
    public class CustomHeaderHandler : DelegatingHandler
    {
        public CustomHeaderHandler() : base(new HttpClientHandler()) { }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string jwtToken = "my_api_token";
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
            return base.SendAsync(request, cancellationToken);
        }
    }
}
