namespace Step.Lib.Common.Dtos.Documents;

/// <summary>
/// DTO для метаданных документа.
/// </summary>
public class DocumentMetadataDto
{
    /// <summary>
    /// ID версии БК на прогнозе.
    /// </summary>
    public Guid? BcVersionForecastId { get; set; }

    /// <summary>
    /// ID версии БК.
    /// </summary>
    public Guid? BcVersionId { get; set; }

    /// <summary>
    /// Тип загрузчика.
    /// Соотношение в сервисах:
    /// Vns.Core - Ключи в LoaderTypes из api/v1/application/config;
    /// SpecificIndicators - Ключи в LoaderType из /api/v1/specific-indicators/loaders/types/all;
    /// Zbs.Core - -;
    /// Grr.Core - -.
    /// </summary>
    public string? LoaderType { get; set; }

    /// <summary>
    /// ID скважины в микросервисе, для которого был сохранен документ.
    /// </summary>
    public Guid? BcVersionDataWellId { get; set; }

    /// <summary>
    /// ID пласта в микросервисе, для которого был сохранен документ.
    /// </summary>
    public Guid? BcVersionDataLayerId { get; set; }

    /// <summary>
    /// ID цикла БК в микросервисе, для которого был сохранен документ.
    /// </summary>
    public Guid? BcCycleId { get; set; }

    /// <summary>
    /// ID данных версии БК, для котого был сохранен документ.
    /// </summary>
    public Guid? BcVersionDataId { get; set; }

    /// <summary>
    /// ID группы удельных показателей.
    /// Используется для загрузчиков из сервиса удельных показателей.
    /// </summary>
    public Guid? SpecificIndicatorGroupId { get; set; }
}