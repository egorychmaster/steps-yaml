using Gir.Vns.Dtos.BcCycles.Enums;

namespace Gir.Vns.Dtos.BcCycles;

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