using ASP_Exam.Helpers.JwtUtil;

namespace ASP_Exam.Helpers
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        
    }
}
