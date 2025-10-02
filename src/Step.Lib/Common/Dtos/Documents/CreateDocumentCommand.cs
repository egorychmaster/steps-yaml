using Microsoft.AspNetCore.Http;

namespace Step.Lib.Common.Dtos.Documents;

public class CreateDocumentCommand
{
    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    public Guid? UserId { get; set; }

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
    /// </summary>
    public int? LoaderSheetType { get; set; }

    /// <summary>
    /// Тип загрузчика.
    /// Соотношение в сервисах:
    /// <br/> Vns.Core - Ключи в LoaderTypes из api/v1/application/config;
    /// <br/> SpecificIndicators - Ключи в LoaderType из /api/v1/specific-indicators/loaders/types/all; 
    /// <br/> Zbs.Core - -;
    /// <br/> Grr.Core - -.
    /// </summary>
    public string? LoaderType { get; set; }

    /// <summary>
    /// ID скважины в микросервисе, для которого был сохранен документ.
    /// <br/> В случае, если микросервис поддерживает УИБК-процесс(и ежемесячные прогнозы), то ожидается ID скважины на прогнозе версии БК(BcVersionForecastWell.Id).
    /// <br/> В случае, если микросервис не поддерживает УИБК-процесс(и нет ежемесячных прогнозов, т.е.все данные привязаны к версии БК), то ожидается ID скважины версии БК(BcVersionWell.Id). BcVersionDataWell.Id более универсальное наименование для обоих случаев и предполагается к использованию в новых микросервисах(вне зависимости есть или нет в них ежемесячные прогнозы).
    /// </summary>
    public Guid? BcVersionDataWellId { get; set; }

    /// <summary>
    /// ID пласта в микросервисе, для которого был сохранен документ.
    /// <br/> В случае, если микросервис поддерживает УИБК-процесс(и ежемесячные прогнозы), то ожидается ID пласта на прогнозе версии БК.
    /// <br/> В противном случае, когда нет ежемесячных прогнозов и все данные привязаны сразу к версии БК, ожидается ID пласта версии БК.ВАЖНО: не путать эту сущность со вскрываемым скважиной пластом (т.е.связкой Пласт+Скважина)!
    /// </summary>
    public Guid? BcVersionDataLayerId { get; set; }

    /// <summary>
    /// ID цикла БК в микросервисе, для которого был сохранен документ.
    /// <br/> Соотношение в сервисах: Vns.Core - BcCycle.Id; Zbs.Core - BcVersionCycle.Id; Grr.Core - BcVersionCycle.Id.
    /// </summary>
    public Guid? BcCycleId { get; set; }

    /// <summary>
    /// ID данных версии БК, для котого был сохранен документ.
    /// <br/> Соотношение в сервисах: Vns.Core - BcVersionData.Id; Zbs.Core - -; Grr.Core - -.
    /// </summary>
    public Guid? BcVersionDataId { get; set; }

    /// <summary>
    /// ID группы удельных показателей.
    /// <br/> Используется для загрузчиков из сервиса удельных показателей.
    /// </summary>
    public Guid? SpecificIndicatorGroupId { get; set; }

    /// <summary>
    /// Загружаемые файлы.
    /// </summary>
    public IEnumerable<IFormFile> Files { get; set; } = null!;
}