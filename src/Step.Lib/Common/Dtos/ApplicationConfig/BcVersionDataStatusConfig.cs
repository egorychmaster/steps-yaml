namespace Step.Lib.Common.Dtos.ApplicationConfig;

/// <summary>
/// Модель конфигурации статусов версии БК.
/// </summary>
public sealed class BcVersionDataStatusConfig
{
    /// <summary>
    /// Доступные типы статусов.
    /// </summary>
    public required IReadOnlyList<BcVersionDataStatusType> Types { get; init; }
}

/// <summary>
/// Модель конфигурации статуса версии БК.
/// </summary>
public sealed class BcVersionDataStatusType
{
    /// <summary>
    /// Строчный тип (ключ) статуса версии БК.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }
}