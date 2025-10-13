using Gir.Vns.Dtos.BcVersionSliceEconomic.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.BcVersionSliceEconomic;

public class GetBcVersionSliceEconomicQuery : BaseSortFilter<BcVersionSliceEconomicDto, EconomicSortPropertyName>
{
    /// <summary>
    /// Идентификаторы.
    /// </summary>
    public Guid[]? Ids { get; init; }

    /// <summary>
    /// Идентификаторы срезов.
    /// </summary>
    public int[]? BcVersionSliceIds { get; init; }

    ///// <summary>
    ///// Номер Скважины.
    ///// </summary>
    //public string? WellNumber { get; init; }

    ///// <summary>
    ///// Наименование пласта.
    ///// </summary>
    //public string? LayerFieldName { get; init; }

    ///// <summary>
    ///// Список Идентификаторов справочника Состав актива.
    ///// </summary>
    //public string[]? AssetContentIds { get; init; }

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
    protected override Dictionary<EconomicSortPropertyName, Expression<Func<BcVersionSliceEconomicDto, object>>> SupportedSortings =>
        new()
        {
            [EconomicSortPropertyName.DateCreated] = x => x.DateCreated
        };
}
