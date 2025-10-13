//using Microsoft.AspNetCore.Mvc;
//using Step.Lib.Common.Dtos;
//using Step.Lib.Vns.Core.Shared.Domain.Constants;

//namespace Gir.Vns.Controllers;

///// <summary>
///// Константы.
///// </summary>
//[ApiController]
//[Route("api/v1/vns/gir/constants/benefits/types/all")]
//public class ConstantsController : ControllerBase
//{
//    /// <summary>
//    /// Получение констант "Типы льгот".
//    /// </summary>
//    /// <returns></returns>
//    [HttpGet]
//    [ProducesResponseType(StatusCodes.Status200OK)]
//    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
//    public ActionResult<CollectionResult<BenefitTypeConstants.BenefitTypeItem>> GetModuleTypesAsync()
//    {
//        return Ok();
//    }
//}
