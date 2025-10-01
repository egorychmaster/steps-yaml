namespace Gir.Vns.Dtos.BcCycles.Enums;

/// <summary>
/// Перечисление типов статусов цикла БК.
/// </summary>
public enum BcCycleStatusType : short
{
    /// <summary>
    /// В ожидании.
    /// </summary>
    Waiting = 1,

    /// <summary>
    /// В работе.
    /// </summary>
    InWork = 2,

    /// <summary>
    /// Завершен.
    /// </summary>
    Finished = 3,

    /// <summary>
    /// На согласовании.
    /// </summary>
    OnApproval = 4,

    /// <summary>
    /// Шаг убран из процесса.
    /// </summary>
    Excluded = 5,
}