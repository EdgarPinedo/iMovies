using System.Net.Http.Headers;

namespace MoviesApp.HttpHandlers
{
    public class CustomHeaderHandler : DelegatingHandler
    {
        public CustomHeaderHandler() : base(new HttpClientHandler()) { }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string jwtToken = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI5MTJhNTk0ZGY5NDIxYjFmMzM0YTFiZWE1ZmZkN2E4OSIsInN1YiI6IjY1OWM0N2VjMmRjNDRlMDFmY2E5NmY0YiIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.kqY0PVD7KyQIvczu2bGLbQj6aQ7vc9KBzx7Yh1oB5J0";
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
            return base.SendAsync(request, cancellationToken);
        }
    }
}
