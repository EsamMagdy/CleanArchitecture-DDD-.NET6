//using System.Net;
//using System.Text.Json;
//using System;

//namespace WebApi.Middleware
//{
//    internal sealed class ExceptionHandlingMiddleware : IMiddleware
//    {
//        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

//        public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger) => _logger = logger;

//        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
//        {
//            try
//            {
//                await next(context);
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, ex.Message);

//                await HandleExceptionAsync(context, ex);
//            }
//        }

//        private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
//        {
//            HttpStatusCode status;
//            var stackTrace = String.Empty;
//            string message;
//            var exceptionType = ex.GetType();
//            if (exceptionType == typeof(Exceptions.BadRequestException))
//            {
//                message = ex.Message;
//                status = HttpStatusCode.BadRequest;
//                stackTrace = ex.StackTrace;
//            }
//            else if (exceptionType == typeof(Exceptions.NotFoundException))
//            {
//                message = ex.Message;
//                status = HttpStatusCode.NotFound;
//                stackTrace = ex.StackTrace;
//            }
//            else if (exceptionType == typeof(Exceptions.AmbiguousException))
//            {
//                message = ex.Message;
//                status = HttpStatusCode.Ambiguous;
//                stackTrace = ex.StackTrace;
//            }
//            else if (exceptionType == typeof(Exceptions.InternalServerErrorException))
//            {
//                message = ex.Message;
//                status = HttpStatusCode.InternalServerError;
//                stackTrace = ex.StackTrace;
//            }
//            //else if (exceptionType == typeof(Exceptions.NotImplementedException))
//            //{
//            //    status = HttpStatusCode.NotImplemented;
//            //    message = exception.Message;
//            //    stackTrace = exception.StackTrace;
//            //}
//            else if (exceptionType == typeof(Exceptions.UnauthorizedAccessException))
//            {
//                status = HttpStatusCode.Unauthorized;
//                message = ex.Message;
//                stackTrace = ex.StackTrace;
//            }
//            else if (exceptionType == typeof(Exceptions.KeyNotFoundException))
//            {
//                status = HttpStatusCode.Unauthorized;
//                message = ex.Message;
//                stackTrace = ex.StackTrace;
//            }
//            else
//            {
//                status = HttpStatusCode.InternalServerError;
//                message = ex.Message;
//                stackTrace = ex.StackTrace;
//            }

//            var exceptionResult = JsonSerializer.Serialize(new ResponseDto<string>
//            {
//                Message = message,

//            }, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
//            context.Response.ContentType = "application/json";
//            context.Response.StatusCode = (int)status;
//            return context.Response.WriteAsync(exceptionResult);
//        }
//    }
//}
