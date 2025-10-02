using Step.Lib.Shared.Domain.Constants.Enums;
using System.ComponentModel.DataAnnotations;

namespace Step.Lib.Common.Dtos.BcCycles;

public class BcCycleUpdateCommand
{
    /// <summary>
    /// ID ресурса, который требуется изменить.
    /// </summary>
    [Required]
    public Guid Id { get; init; } = default!;

    /// <summary>
    /// DTO, содержащее данные для изменения ресурса.
    /// </summary>
    [Required]
    public BcCycleUpdateDto Value { get; init; } = default!;
}

/// <summary>
/// DTO изменения сущности "Цикл БК (данных версии БК)".
/// </summary>
public class BcCycleUpdateDto
{
    /// <summary>
    /// Новый статус цикла БК. <br/>
    /// См. `BcCycleStatusType` в `Schemas`.<br/>
    /// Возможные значения:
    /// 1 - Waiting - В ожидании.
    /// 2 - InWork - В работе.
    /// 3 - Finished - Завершен.
    /// </summary>
    public BcCycleStatusType StatusType { get; set; }
}