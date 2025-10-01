using Gir.Vns.Dtos.BcCycles.Enums;
using Step.Lib.Shared.Domain.Constants;

namespace Gir.Vns.Dtos.BcCycles;

/// <summary>
/// Цикл БК (данных версии БК).
/// </summary>
public class BcCycleDto
{
    /// <summary>
    /// ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Тип данного цикла.
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Текущий статус шага.<br/>
    /// Возможные значения:
    /// 1 - Waiting - В ожидании.
    /// 2 - InWork - В работе.
    /// 3 - Finished - Завершен.
    /// 4 - OnApproval - На согласовании.
    /// 5 - Excluded - Шаг убран из процесса.
    /// </summary>
    public BcCycleStatusType StatusType { get; set; }

    /// <summary>
    /// Информация о текущем статусе шага.
    /// </summary>
    public BcVersionCycleStatusType.BcVersionCycleStatusTypeItem StatusTypeInfo { get; set; } = null!;

    /// <summary>
    /// Планируемая дата начала шага.
    /// </summary>
    public DateOnly DatePlanStart { get; set; }

    /// <summary>
    /// Планируемая дата завершения шага.
    /// </summary>
    public DateOnly DatePlanEnd { get; set; }

    /// <summary>
    /// Фактическая дата начала шага.
    /// </summary>
    public DateOnly? DateFactStart { get; set; }

    /// <summary>
    /// Фактическая дата завершения шага.
    /// </summary>
    public DateOnly? DateFactEnd { get; set; }

    /// <summary>
    /// Исполнители данного БК.
    /// </summary>
    public IReadOnlyCollection<BcCycleImplementerDto> Implementers { get; set; } = null!;

    /// <summary>
    /// Информация о следующем доступном статусе.
    /// </summary>
    public BcCycleNextStatusDto NextStatus { get; set; } = null!;

    /// <summary>
    /// Доступные действия.
    /// </summary>
    //public IReadOnlyCollection<ActionDto> Actions { get; set; } = null!;
}