namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// DTO для конфигурации типов метрик статистики.
/// </summary>
public class StatisticsConfigDto
{
    /// <summary>
    /// Поля конфигурации.
    /// </summary>
    public required IReadOnlyCollection<StatisticsMetricTypeDto> MetricTypes { get; init; }
}

/// <summary>
/// DTO для поля конфигурации типа метрики статистики.
/// </summary>
public sealed class StatisticsMetricTypeDto
{
    /// <summary>
    /// Тип метрики.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Название метрики.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Единица измерения.
    /// </summary>
    public required string Unit { get; init; }
}