using Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWellsBore;
using Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWells;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Скважина среза версии БК.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/wells")]
public class BcVersionSliceWellsController : ControllerBase
{
    /// <summary>
    /// Получение списка скважин с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionDataWellDto>> GetBcVersionDataWellAsync([FromQuery] GetBcVersionDataWellsQuery query)
    {
        return Ok();
    }

    /// <summary>
    /// Создание скважины, относящейся к БК.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<BcVersionSliceWellCreateResultDto> CreateWell([FromBody] BcVersionSliceWellCreateDto dto)
    {
        return StatusCode(StatusCodes.Status201Created, new BcVersionSliceWellCreateResultDto { BcVersionSliceWellId = Guid.NewGuid() });
    }

    /// <summary>
    /// Редактирование скважины, относящейся к БК.
    /// </summary>
    /// <param name="bcVersionSliceWellId"></param>
    /// <returns></returns>
    [HttpPut("{bcVersionSliceWellId:guid}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult UpdateWell(Guid bcVersionSliceWellId, [FromBody] BcVersionSliceWellUpdateDto dto)
    {
        return NoContent();
    }


    /// <summary>
    /// Получение координат ствола скважины.
    /// </summary>
    /// <returns></returns>
    [HttpGet("bore-coordinates")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<WellBoreCoordinateDto>> GetBcVersionDataWellCoordinatesAsync([FromQuery] GetBcVersionDataWellCoordinatesQuery query)
    {
        return Ok();
    }

    /// <summary>
    /// Множественное редактирование координат стволов скважин.
    /// </summary>
    /// <param name="bcVersionSliceWellId">Индентификатор скважины данных версии БК.</param>
    /// <returns></returns>
    [HttpPut("bore-coordinates/{bcVersionSliceWellId:guid}/batch")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult UpdateWellCoordinates(Guid bcVersionSliceWellId, [FromBody] DataWellCoordinatesUpdateDto dto)
    {
        return NoContent();
    }
}
