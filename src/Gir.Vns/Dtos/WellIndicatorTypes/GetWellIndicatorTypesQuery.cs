using Gir.Vns.Dtos.WellIndicatorTypes.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.WellIndicatorTypes;

public class GetWellIndicatorTypesQuery : BaseSortFilter<WellIndicatorTypeDto, WellIndicatorTypeSortPropertyName>
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
    protected override Dictionary<WellIndicatorTypeSortPropertyName, Expression<Func<WellIndicatorTypeDto, object>>> SupportedSortings =>
        new()
        {
            [WellIndicatorTypeSortPropertyName.DateCreated] = x => x.DateCreated
        };
}
