using Gir.Vns.Dtos.CatalogModuleTypes.Enums;
using Step.Lib.Common.Dtos.Filter.Sorting;
using System.Linq.Expressions;

namespace Gir.Vns.Dtos.CatalogModuleTypes;

public class GetModuleTypesQuery : BaseSortFilter<ModuleTypeDto, ModuleTypeSortPropertyName>
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
    protected override Dictionary<ModuleTypeSortPropertyName, Expression<Func<ModuleTypeDto, object>>> SupportedSortings =>
        new()
        {
            [ModuleTypeSortPropertyName.DateCreated] = x => x.DateCreated
        };
}
