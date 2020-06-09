using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Esmart.Application.WebApi.Filters
{
	public class LanguageActionFilter : ActionFilterAttribute
	{
		
		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			var objectContent = actionExecutedContext.Response.Content as ObjectContent;
			if (objectContent != null)
			{
				var type = objectContent.ObjectType; //returned object
				var value = objectContent.Value; //returned value
			}

			
		}
	}
}