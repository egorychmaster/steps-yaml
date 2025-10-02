using Step.Lib.Vns.Core.Shared.Domain.Constants;

namespace Step.Lib.Common.Dtos.ApplicationConfig;

/// <summary>
/// Конфигурация приложения.
/// </summary>
public class ApplicationConfig
{
    /// <summary>
    /// Текущее ДО.
    /// </summary>
    public required CompanyTypeConstants.CompanyTypeItem Company { get; init; }

    /// <summary>
    /// Конфигурация модулей (бизнесовых).
    /// </summary>
    public required ModuleConfig ModuleConfiguration { get; init; }

    /// <summary>
    /// Конфигурация циклов БК.
    /// </summary>
    public required BcCycleGroupConfig BcCycleGroupConfiguration { get; init; }

    /// <summary>
    /// Конфигурация циклов БК.
    /// </summary>
    public required BcCycleConfig BcCycleConfiguration { get; init; }

    /// <summary>
    /// Конфигурация статусов версии БК.
    /// </summary>
    public required BcVersionDataStatusConfig BcVersionDataStatusConfiguration { get; init; }

    /// <summary>
    /// Конфигурация доступных загрузчиков.
    /// </summary>
    public required IReadOnlyCollection<LoaderType> LoaderTypes { get; init; }

    /// <summary>
    /// Конфигурация статистики.
    /// </summary>
    public required StatisticsConfig StatisticsConfiguration { get; init; }

    /// <summary>
    /// Конфигурация ключевых показателей (КПЭ).
    /// </summary>
    public required KeyIndicatorConfig KeyIndicatorConfiguration { get; init; }
}