﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;

namespace BaseApi.Controllers
{
    [Produces("application/json")]
    [ActionFilter]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BaseApiController<T> : ControllerBase where T : BaseApiController<T>
    {
        public int UserId
        {
            get
            {
                return int.Parse(this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid)?.Value);
            }
        }
    }

    public class ActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            //Check Model
            if (actionContext.ModelState.IsValid == false)
            {
                var dicErrors = new Dictionary<string, object>();
                foreach (var keyModelStatePair in actionContext.ModelState)
                {
                    var key = keyModelStatePair.Key;//.ToCamel();
                    //
                    var errors = keyModelStatePair.Value.Errors;
                    if (errors != null && errors.Count > 0)
                    {
                        if (errors.Count == 1)
                        {
                            var errorMessage = GetErrorMessage(errors[0]);
                            dicErrors.Add(key, new[] { errorMessage });
                        }
                        else
                        {
                            var errorMessages = new string[errors.Count];
                            for (var i = 0; i < errors.Count; i++)
                            {
                                errorMessages[i] = GetErrorMessage(errors[i]);
                            }

                            dicErrors.Add(key, errorMessages);
                        }
                    }
                }
                //var res = new MessageBase<object>() { Code = enmMsg.FAILED, Desc = dicErrors.ToJson() };
                //
                //actionContext.Result = new ContentResult
                //{
                //    Content = res.ToJson(),
                //    ContentType = "application/json",
                //    StatusCode = (int)HttpStatusCode.OK
                //};
            }
        }
        private string GetErrorMessage(ModelError error)
        {
            return string.IsNullOrEmpty(error.ErrorMessage) ? "The input was not valid." : error.ErrorMessage;
        }
    }
}
