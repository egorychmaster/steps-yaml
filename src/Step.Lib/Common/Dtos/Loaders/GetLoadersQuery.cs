using Step.Lib.Common.Dtos.Filter.Sorting;
using Step.Lib.Common.Dtos.Loaders.Enums;
using System.Linq.Expressions;

namespace Step.Lib.Common.Dtos.Loaders;

public class GetLoadersQuery : BaseSortFilter<LoaderListDto, LoaderSortPropertyName>
{
    /// <summary>
    /// Идентификаторы.
    /// </summary>
    public Guid[]? Ids { get; init; }

    /// <summary>
    /// Активные загрузки.
    /// </summary>
    public string? Active { get; init; }


    /// <summary>
    /// **Ключи сортировки:**
    /// - DateStart
    /// 
    /// **Пример использования:** `sortOptions=DateStart.asc`
    /// <br/>Сортировки: `asc` - восходящая, `desc` - нисходящая.
    /// <br/>Если ни `desc` ни `asc` не предоставлен - сортировка производится как `asc` (как например для `{DateStart}` в примере).
    /// <br/>Если `sortOptions` не переданы - по умолчанию действует сортировка по `{DateStart}`.
    /// </summary>
    public override string[]? SortOptions { get; init; }

    /// <summary>
    /// Поддерживаемые сортировки.
    /// </summary>
    protected override Dictionary<LoaderSortPropertyName, Expression<Func<LoaderListDto, object>>> SupportedSortings =>
        new()
        {
            [LoaderSortPropertyName.DateStart] = x => x.DateStart
        };
}
