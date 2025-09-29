namespace Gir.Vns.Domain.Enums;

/// <summary>
/// Перечисление типов значения атрибутов.
/// </summary>
public enum AttributeValueType
{
    /// <summary>
    /// Булевое.
    /// </summary>
    Bool = 1,

    /// <summary>
    /// Строчное.
    /// </summary>
    String = 2,

    /// <summary>
    /// Целочисленное.
    /// </summary>
    Int = 3,

    /// <summary>
    /// Десятичное.
    /// </summary>
    Decimal = 4,

    /// <summary>
    /// Дата.
    /// </summary>
    DateOnly = 5,

    /// <summary>
    /// Дата со временем.
    /// </summary>
    DateTime = 6
}