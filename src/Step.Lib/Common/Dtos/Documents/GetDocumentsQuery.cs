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

    ///// <summary>
    ///// Наименования.
    ///// </summary>
    //public string[]? Names { get; init; }

    ///// <summary>
    ///// Идентификаторы месторождения.
    ///// </summary>
    //public Guid[]? FieldIds { get; init; }

    ///// <summary>
    ///// Наименование месторождения.
    ///// </summary>
    //public string? FieldName { get; init; }

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