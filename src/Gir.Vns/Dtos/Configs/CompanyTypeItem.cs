using Gir.Vns.Domain.Constants.Enums;

namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Тип ДО.
/// </summary>
/// <param name="key"> Ключ. </param>
/// <param name="textKey"> Текстовое представление ключа. </param>
/// <param name="enumKey"> Дочернее общество. </param>
/// <param name="name"> Наименование. </param>
/// <param name="shortName"> Сокращенное наименование. </param>
public class CompanyTypeItem(short key, string name, string textKey, CompanyType enumKey, string shortName)
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public short Key => key;

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name => name;

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
}