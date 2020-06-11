using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using Esmart.Infrastructure.Resources;

namespace Esmart.Infrastructure.Exceptions
{
    public class IntellmixExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext cont)
        {
            if (cont.Exception is System.Data.DBConcurrencyException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format("Data is not updated!")),
                    ReasonPhrase = "DBConcurrency issue"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.InvalidOperationException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format(cont.Exception.Message)),
                    ReasonPhrase = "Invalid data"
                };

                cont.Response = message;
            }

            else if (cont.Exception is System.Data.DeletedRowInaccessibleException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("The Data been already deleted")),
                    ReasonPhrase = "DeletedRowInaccessibleException"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.Data.DuplicateNameException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format("Duplicate data found")),
                    ReasonPhrase = "DuplicateNameException"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.Data.InvalidConstraintException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format("Incorrect Relation found in Database")),
                    ReasonPhrase = "InvalidConstraintException"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.Data.NoNullAllowedException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format("Null values are not allowed")),
                    ReasonPhrase = "NoNullAllowedException"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.Data.OperationAbortedException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format("Operation was cancelled by the user")),
                    ReasonPhrase = "OperationAbortedException"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.Data.RowNotInTableException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("Data is not in database")),
                    ReasonPhrase = "RowNotInTableException"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.Data.SyntaxErrorException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(string.Format("Syntax problem in database table")),
                    ReasonPhrase = "SyntaxErrorException"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.Data.VersionNotFoundException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("Data already been deleted")),
                    ReasonPhrase = "VersionNotFoundException"
                };
                cont.Response = message;
            }

            else if (cont.Exception is System.Data.DataException)
            {
                var message = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("Data Related Exception")),
                    ReasonPhrase = "DataException"
                };
                cont.Response = message;
            }
            else
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ResourceStrings.ErrorMessage),
                    ReasonPhrase = "InternalServerError"
                };
                cont.Response = message;
            }
        }
    }
}
