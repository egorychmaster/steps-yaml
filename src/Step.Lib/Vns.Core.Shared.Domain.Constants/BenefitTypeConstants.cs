using Step.Lib.Shared.Domain.Constants.Base;
using Step.Lib.Shared.Domain.Constants.Extensions;

namespace Step.Lib.Vns.Core.Shared.Domain.Constants;

/// <summary>
/// Тип льготы.
/// </summary>
public static class BenefitTypeConstants
{
    /// <summary>
    /// Коллекция всех констант.
    /// </summary>
    public static IReadOnlyCollection<BenefitTypeItem> All
        => new List<BenefitTypeItem>() { Triz, Kd };

    /// <summary>
    /// Получение константы из списка всех констант по ключу.
    /// </summary>
    /// <param name="key"> Ключ. </param>
    /// <returns> Константа. </returns>
    public static BenefitTypeItem Get(short key) => All.Get(key);

    /// <summary>
    /// Тип льготы.
    /// </summary>
    /// <param name="key">ID.</param>
    /// <param name="name"> Наименование. </param>
    public class BenefitTypeItem(short key, string name) : ConstantItemBase(key, name) { }

    /// <summary>
    /// ТРИЗ.
    /// </summary>
    public static readonly BenefitTypeItem Triz = new(1, "ТРИЗ");

    /// <summary>
    /// КД.
    /// </summary>
    public static readonly BenefitTypeItem Kd = new(2, "КД");
}