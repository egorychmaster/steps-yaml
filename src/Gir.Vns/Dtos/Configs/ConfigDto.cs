namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурация приложения.
/// </summary>
public class ConfigDto
{
    /// <summary>
    /// Текущее ДО.
    /// </summary>
    public CompanyTypeItem Company { get; init; }

    /// <summary>
    /// Конфигурация циклов БК.
    /// </summary>
    public BcCycleGroupConfigDto BcCycleGroupConfiguration { get; init; }

    /// <summary>
    /// Конфигурация циклов БК.
    /// </summary>
    public BcCycleConfigDto BcCycleConfiguration { get; init; }

    /// <summary>
    /// Конфигурация статусов версии БК.
    /// </summary>
    public BcVersionDataStatusConfigDto BcVersionDataStatusConfiguration { get; init; }

    /// <summary>
    /// Доступные типы загрузчиков.
    /// </summary>
    public IReadOnlyCollection<LoaderTypeDto> LoaderTypes { get; init; }

    /// <summary>
    /// Конфигурация типов метрик статистики.
    /// </summary>
    public StatisticsConfigDto StatisticsConfiguration { get; init; }
}
