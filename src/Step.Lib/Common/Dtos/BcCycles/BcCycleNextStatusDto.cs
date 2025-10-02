using Step.Lib.Shared.Domain.Constants.Enums;

namespace Step.Lib.Common.Dtos.BcCycles;

/// <summary>
/// Информация о следующем доступном статусе цикла БК.
/// </summary>
public class BcCycleNextStatusDto
{
    /// <summary>
    /// Тип следующего статуса.<br/>
    /// Если равно `null` - изменить статус невозможно, иначе содержит ключ следующего доступного статуса.
    /// </summary>
    public BcCycleStatusType? StatusType { get; set; }

    /// <summary>
    /// Причина недоступности перехода в следующий статус.
    /// </summary>
    public string? Reason { get; set; }
}