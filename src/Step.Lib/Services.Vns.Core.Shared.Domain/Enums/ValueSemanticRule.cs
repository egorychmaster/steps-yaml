namespace Step.Lib.Services.Vns.Core.Shared.Domain.Enums;

/// <summary>
/// Перечисление правил семантики значения.
/// </summary>
/// <remarks>
/// Правила описаны относительно значения, которое является первичным в рамках правила. <br/>
/// Т.е. например <see cref="GreaterIsGood"/> - первичное (оригинальное) значение больше сравниваемого, и т.д.
/// </remarks>
public enum ValueSemanticRule
{
    /// <summary>
    /// Значение больше сравниваемого - хорошо.
    /// </summary>
    GreaterIsGood = 1,
    /// <summary>
    /// Значение больше сравниваемого - плохо.
    /// </summary>
    GreaterIsBad = 2,
    /// <summary>
    /// Значение не равно сравниваемому - плохо.
    /// </summary>
    NotEqualIsBad = 3,
    /// <summary>
    /// Относительная разница между числом и сравниваемым:<br/>
    /// больше 0.0 и меньше коэффициента - средне (средне плохо/хорошо),<br/>
    /// больше коэффициента - плохо.
    /// </summary>
    RelativeDiffByCoefficient = 4,
}