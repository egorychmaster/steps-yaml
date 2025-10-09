using Gir.Vns.Dtos.Clusters.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.Clusters;

public class GetClustersQuery: BaseSortFilter<ClusterDto, ClusterSortPropertyName>
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
    /// Идентификаторы месторождения.
    /// </summary>
    public Guid[]? FieldIds { get; init; }

    /// <summary>
    /// Номер.
    /// </summary>
    public string? Number {  get; init; }

    /// <summary>
    /// Часть номера.
    /// </summary>
    public string? NumberContains { get; init; }

    /// <summary>
    /// Номера.
    /// </summary>
    public string[]? Numbers { get; init; }

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
    protected override Dictionary<ClusterSortPropertyName, Expression<Func<ClusterDto, object>>> SupportedSortings =>
        new()
        {
            [ClusterSortPropertyName.DateCreated] = x => x.DateCreated
        };
}
