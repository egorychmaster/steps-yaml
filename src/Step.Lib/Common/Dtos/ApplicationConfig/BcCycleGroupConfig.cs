namespace Step.Lib.Common.Dtos.ApplicationConfig;

/// <summary>
/// Конфигурации групп циклов версии БК.
/// </summary>
public class BcCycleGroupConfig
{
    /// <summary>
    /// Доступные типы статусов.
    /// </summary>
    public required List<BcCycleGroupType> Types { get; init; }
}

/// <summary>
/// Модель конфигурации группы цикла БК.
/// </summary>
public sealed class BcCycleGroupType
{
    /// <summary>
    /// Строчный тип (ключ) группы цикла БК.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Приоритет.
    /// </summary>
    public required short Priority { get; init; }
}