using Gir.Vns.Dtos.CatalogWellTypes.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.CatalogWellTypes;

public class GetWellTypesQuery : BaseSortFilter<WellTypeDto, WellTypeSortPropertyName>
{
    /// <summary>
    /// Идентификаторы.
    /// </summary>
    public Guid[]? Ids { get; init; }

    /// <summary>
    /// Номер (алиас для Number).
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Часть номера (алиас для NumberContains).
    /// </summary>
    public string? NameContains { get; init; }

    /// <summary>
    /// Наименования.
    /// </summary>
    public string[]? Names { get; init; }

    /// <summary>
    /// Короткое наименование.
    /// </summary>
    public string? ShortName { get; init; }

    /// <summary>
    /// Часть короткого наименования.
    /// </summary>
    public string? ShortNameContains { get; init; }

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
    protected override Dictionary<WellTypeSortPropertyName, Expression<Func<WellTypeDto, object>>> SupportedSortings =>
        new()
        {
            [WellTypeSortPropertyName.DateCreated] = x => x.DateCreated
        };
}
