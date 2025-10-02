using Step.Lib.Common.Dtos.Documents.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Step.Lib.Common.Dtos.Documents;

public class GetDocumentsQuery : BaseSortFilter<DocumentDto, DocumentSortPropertyName>
{
    /// <summary>
    /// Идентификаторы.
    /// </summary>
    public Guid[]? Ids { get; init; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    public Guid? UserId { get; init; }

    /// <summary>
    /// Фильтр - по физическому пути до файла в S3.
    /// </summary>
    public string? Path { get; init; }

    /// <summary>
    /// Фильтр по метаданным - ID версии БК на прогнозе в микросервисе, для которых сохраняли документы (ID версии БК на прогнозе).
    /// </summary>
    public Guid? BcVersionForecastId { get; set; }

    /// <summary>
    /// Фильтр по метаданным - список ID версий БК в микросервисе, для которых сохраняли документы.
    /// </summary>
    public Guid[]? BcVersionIds { get; set; }

    /// <summary>
    /// Фильтр по метаданным - типы загрузчиков, для которых сохраняли документы.
    /// </summary>
    public string[]? LoaderTypes { get; set; }

    /// <summary>
    /// Фильтр по метаданным - список ID скважин в микросервисе, для которых сохраняли документы.
    /// </summary>
    public Guid[]? BcVersionDataWellIds { get; set; }

    /// <summary>
    /// Фильтр по метаданным - список ID пластов в микросервисе, для которых сохраняли документы.
    /// </summary>
    public Guid[]? BcVersionDataLayerIds { get; set; }

    /// <summary>
    /// Фильтр по метаданным - список ID циклов БК в микросервисе, для которых сохраняли документы.
    /// </summary>
    public Guid[]? BcCycleIds { get; set; }

    /// <summary>
    /// Фильтр по метаданным - список ID данных версии БК, для которых сохраняли документы.
    /// </summary>
    public Guid[]? BcVersionDataIds { get; set; }

    /// <summary>
    /// Фильтр по метаданным - список ID группы удельных показателей.
    /// </summary>
    public Guid[]? SpecificIndicatorGroupIds { get; set; }

    /// <summary>
    /// **Ключи сортировки:**
    /// - DateCreated
    /// 
    /// **Пример использования:** `sortOptions=DateCreated`
    /// 
    /// Сортировки: `asc` - восходящая, `desc` - нисходящая.
    /// 
    /// Если ни `desc` ни `asc` не предоставлен - сортировка производится как `asc` (как например для `{DateCreated}` в примере).
    /// 
    /// Если `sortOptions` не переданы - по умолчанию действует сортировка по `{DateCreated}`.
    /// </summary>
    public override string[]? SortOptions { get; init; }

    /// <summary>
    /// Поддерживаемые сортировки.
    /// </summary>
    protected override Dictionary<DocumentSortPropertyName, Expression<Func<DocumentDto, object>>> SupportedSortings =>
        new()
        {
            [DocumentSortPropertyName.DateCreated] = x => x.DateCreated
        };
}