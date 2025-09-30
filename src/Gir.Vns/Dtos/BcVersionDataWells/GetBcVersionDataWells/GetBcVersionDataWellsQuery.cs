using Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWells.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWells;

public class GetBcVersionDataWellsQuery : BaseSortFilter<BcVersionDataWellDto, BcVersionDataWellSortPropertyName>
{
    /// <summary>
    /// Фильтр - по ID.
    /// </summary>
    public Guid[]? Ids { get; init; }

    /// <summary>
    /// Фильтр - по ID данных версии БК, в которые включены скважины.
    /// </summary>
    public Guid[]? BcVersionDataIds { get; init; }

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
    protected override Dictionary<BcVersionDataWellSortPropertyName, Expression<Func<BcVersionDataWellDto, object>>> SupportedSortings =>
        new()
        {
            [BcVersionDataWellSortPropertyName.DateCreated] = x => x.DateCreated,
        };
}