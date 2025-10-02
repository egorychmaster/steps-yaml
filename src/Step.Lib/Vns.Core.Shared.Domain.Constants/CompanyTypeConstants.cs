using Step.Lib.Shared.Domain.Constants.Base;
using Step.Lib.Shared.Domain.Constants.Extensions;
using Step.Lib.Vns.Core.Shared.Domain.Constants.Enums;

namespace Step.Lib.Vns.Core.Shared.Domain.Constants;

/// <summary>
/// Тип ДО.
/// </summary>
public static class CompanyTypeConstants
{
    /// <summary>
    /// Коллекция всех констант.
    /// </summary>
    public static IReadOnlyCollection<CompanyTypeItem> All
        => new List<CompanyTypeItem> { Slm, Hnt, Mng, Zpl };

    /// <summary>
    /// Получение константы из списка всех констант по ключу.
    /// </summary>
    /// <param name="key"> Ключ. </param>
    /// <returns> Константа. </returns>
    public static CompanyTypeItem Get(short key) => All.Get(key);

    /// <summary>
    /// Итем <see cref="CompanyTypeConstants"/>.
    /// </summary>
    /// <param name="key"> Ключ. </param>
    /// <param name="textKey"> Текстовое представление ключа. </param>
    /// <param name="enumKey"> Дочернее общество. </param>
    /// <param name="name"> Наименование. </param>
    /// <param name="shortName"> Сокращенное наименование. </param>
    public class CompanyTypeItem(short key, string textKey, CompanyType enumKey, string name, string shortName) : ConstantItemBase(key, name)
    {
        /// <summary>
        /// Текстовое представление ключа.
        /// </summary>
        public string TextKey => textKey;

        /// <summary>
        /// Представление ключа в виде значения <see cref="CompanyType"/>.
        /// </summary>
        public CompanyType EnumKey => enumKey;

        /// <summary>
        /// Короткое имя.
        /// </summary>
        public string ShortName => shortName;
    };

    /// <summary>
    /// Мегион.
    /// </summary>
    public static readonly CompanyTypeItem Slm = new((short)CompanyType.Slm, "SLM", CompanyType.Slm, "Мегион", "СН-МНГ");

    /// <summary>
    /// Хантос.
    /// </summary>
    public static readonly CompanyTypeItem Hnt = new((short)CompanyType.Hnt, "HNT", CompanyType.Hnt, "Хантос", "ГПН-Хантос");

    /// <summary>
    /// Мессояха.
    /// </summary>
    public static readonly CompanyTypeItem Mng = new((short)CompanyType.Mng, "MNG", CompanyType.Mng, "Мессояха", "Мессояха");

    /// <summary>
    /// Заполярье.
    /// </summary>
    public static readonly CompanyTypeItem Zpl = new((short)CompanyType.Zpl, "ZPL", CompanyType.Zpl, "Заполярье", "ГПН-Заполярье");

}