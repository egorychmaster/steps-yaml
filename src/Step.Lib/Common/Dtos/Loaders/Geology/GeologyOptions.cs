using Step.Lib.Shared.Domain.Constants.Enums;

namespace Step.Lib.Common.Dtos.Loaders.Geology;

/// <summary>
/// Настройки загрузчика "Геологический загрузчик".
/// </summary>
public class GeologyOptions
{
    /// <summary>
    /// Тип сценария.
    /// </summary>
    public BcVersionScenarioType BcVersionScenarioType { get; init; }

    /// <summary>
    /// ID пользователя - владельца БК, который будет назначен на все созданные БК(Куратор БК).
    /// </summary>
    public Guid BcOwnerUserId { get; init; }

    /// <summary>
    /// ID пользователя - ответственного за БК, который будет назначен на все созданные БК(Руководитель проекта).
    /// </summary>
    public Guid BcResponsibleUserId { get; init; }

    /// <summary>
    /// ID прогноза (из сервиса Forecasts),
    /// который будет установлен в созданные версии БК на прогнозе, если задан.
    /// </summary>
    public Guid ForecastId { get; init; }

    /// <summary>
    /// Дополнительные данные по циклам БК, по которым будут дополнены автоматически создаваемые циклы БК. <br/>
    /// Должен содержать объекты по всем типам циклов для процесса ФБК.
    /// </summary>
    public IReadOnlyCollection<GeologyBcCycleOptions> BcCycles { get; init; } = null!;
}

/// <summary>
/// Дополнительные данные по циклу БК, по которым будет дополнен созданный цикл.
/// </summary>
public sealed class GeologyBcCycleOptions
{
    /// <summary>
    /// Типа цикла для ФБК процесса.<br/>
    /// См. типы в конфигурации приложения.
    /// </summary>
    /// <seealso cref="ApplicationConfig.BcCycleType.Type"/>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Планируемая дата начала цикла.
    /// </summary>
    public DateOnly DatePlanStart { get; set; }

    /// <summary>
    /// Планируемая дата завершения цикла.
    /// </summary>
    public DateOnly DatePlanEnd { get; set; }

    /// <summary>
    /// Список ответственных за цикл.<br/>
    /// В списке не должно быть дубликатов.
    /// </summary>
    public IReadOnlyList<Guid> ImplementerIds { get; set; } = null!;
}