using Exercise.Base.Response;
using Exercise.Exceptions;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Exercise.Base.Controllers
{
   [EnableCors("APIPublicCors")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        protected ActionResult StepMediaCollection<TResult, TField>(BaseResponse<TResult, TField> response) where TResult : class, new() where TField : class
        {
            if (response.HasErrors())
            {
                return HandleErrors(response.ErrorMessages.First());
            }

            return base.Ok(new { Data = response.Result, Total = response.Total });
        }

        protected ActionResult StepMediaItem<TResult, TField>(BaseResponse<List<TResult>, TField> response) where TResult : class, new() where TField : class
        {
            if (response.HasErrors())
            {
                return HandleErrors(response.ErrorMessages.First());
            }

            return base.Ok(response.Result.First());
        }

        protected ActionResult StepMediaItem<TResult, TField>(BaseResponse<TResult, TField> response) where TResult : class, new() where TField : class
        {
            if (response.HasErrors())
            {
                return HandleErrors(response.ErrorMessages.First());
            }

            return base.Ok(response.Result);
        }

        private ActionResult HandleErrors(Exception exception)
        {
            // Client
            Type type = exception.GetType();
            
            if (type == typeof(FailedValidationException))
            {
                FailedValidationException failedValidationException = (FailedValidationException)exception;
                if (!string.IsNullOrEmpty(failedValidationException.NameProperty))
                    ModelState.AddModelError(failedValidationException.NameProperty, exception.Message);

                return BadRequest(ModelState);
            }

            // Server
            throw exception;
        }
    }
}

