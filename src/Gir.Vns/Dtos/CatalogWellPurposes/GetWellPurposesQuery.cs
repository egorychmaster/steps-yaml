using Gir.Vns.Dtos.CatalogWellPurposes.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.CatalogWellPurposes;

public class GetWellPurposesQuery : BaseSortFilter<WellPurposeDto, WellPurposeSortPropertyName>
{
    /// <summary>
    /// Идентификаторы.
    /// </summary>
    public Guid[]? Ids { get; init; }

    ///// <summary>
    ///// Номер (алиас для Number).
    ///// </summary>
    //public string? Name { get; init; }

    ///// <summary>
    ///// Часть номера (алиас для NumberContains).
    ///// </summary>
    //public string? NameContains { get; init; }

    ///// <summary>
    ///// Наименования.
    ///// </summary>
    //public string[]? Names { get; init; }

    ///// <summary>
    ///// Короткое наименование.
    ///// </summary>
    //public string? ShortName { get; init; }

    ///// <summary>
    ///// Часть короткого наименования.
    ///// </summary>
    //public string? ShortNameContains { get; init; }

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
    protected override Dictionary<WellPurposeSortPropertyName, Expression<Func<WellPurposeDto, object>>> SupportedSortings =>
        new()
        {
            [WellPurposeSortPropertyName.DateCreated] = x => x.DateCreated
        };
}
