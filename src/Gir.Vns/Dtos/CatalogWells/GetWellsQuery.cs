using Gir.Vns.Dtos.CatalogWells.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.CatalogWells;

public class GetWellsQuery : BaseSortFilter<WellDto, WellSortPropertyName>
{
    /// <summary>
    /// Идентификаторы.
    /// </summary>
    public Guid[]? Ids { get; init; }

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
    protected override Dictionary<WellSortPropertyName, Expression<Func<WellDto, object>>> SupportedSortings =>
        new()
        {
            [WellSortPropertyName.DateCreated] = x => x.DateCreated
        };
}
