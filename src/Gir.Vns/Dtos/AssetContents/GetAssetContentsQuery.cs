using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.AssetContents;

public class GetAssetContentsQuery : BaseSortFilter<AssetContentDto, AssetContentSortPropertyName>
{
    /// <summary>
    /// Идентификаторы.
    /// </summary>
    public Guid[]? Ids { get; init; }

    ///// <summary>
    ///// Наименование
    ///// </summary>
    //public string? Name { get; init; }

    ///// <summary>
    ///// Часть наименования.
    ///// </summary>
    //public string? NameContains { get; init; }

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

    ///// <summary>
    ///// Массив наименований месторождения.
    ///// </summary>
    //public string[]? FieldNames { get; init; }

    ///// <summary>
    ///// Идентификатор лицензионного участка.
    ///// </summary>
    //public Guid LicenseAreaId { get; init; }

    ///// <summary>
    ///// Массив идентификаторов лицензионного участка.
    ///// </summary>
    //public Guid[]? LicenseAreaIds { get; init; }

    ///// <summary>
    ///// Наименование лицензионного участка.
    ///// </summary>
    //public string? LicenseAreaName { get; init; }

    ///// <summary>
    ///// Массив наименований лицензионного участка.
    ///// </summary>
    //public string[]? LicenseAreaNames { get; init; }

    ///// <summary>
    ///// Массив ID Активов для фильтрации.
    ///// </summary>
    //public Guid[]? AssetIds { get; init; }

    /// <summary>
    /// **Ключи сортировки:**
    /// - DateCreated
    /// 
    /// **Пример использования:** `sortOptions=DateCreated.asc`
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
    protected override Dictionary<AssetContentSortPropertyName, Expression<Func<AssetContentDto, object>>> SupportedSortings =>
        new()
        {
            [AssetContentSortPropertyName.DateCreated] = x => x.DateCreated,
        };
}