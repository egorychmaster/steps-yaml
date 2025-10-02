namespace Step.Lib.Common.Dtos.ApplicationConfig;

/// <summary>
/// Модель конфигурации статистики.
/// </summary>
public sealed class StatisticsConfig
{
    /// <summary>
    /// Доступные типы метрик.
    /// </summary>
    public required List<StatisticsMetricType> MetricTypes { get; init; }
}

/// <summary>
/// Модель конфигурации метрики статистики.
/// </summary>
public sealed class StatisticsMetricType
{
    /// <summary>
    /// Тип метрики.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Единица измерения.
    /// </summary>
    public required string Unit { get; init; }
}