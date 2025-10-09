using Gir.Vns.Dtos.CatalogLayers.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.CatalogLayers;

public class GetLayersQuery : BaseSortFilter<LayerDto, LayerSortPropertyName>
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
    protected override Dictionary<LayerSortPropertyName, Expression<Func<LayerDto, object>>> SupportedSortings =>
        new()
        {
            [LayerSortPropertyName.DateCreated] = x => x.DateCreated
        };
}