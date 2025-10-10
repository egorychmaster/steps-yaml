namespace Step.Lib.Shared.Domain.Constants.Enums;

/// <summary>
/// Тип экономики.
/// </summary>
public enum EconomicSummaryType : short
{
    /// <summary>
    /// Фактическая (экономика с загрузчиков).
    /// </summary>
    Fact = 1,

    /// <summary>
    /// Плановая (экономика из "Паспорт ИП").
    /// </summary>
    Plan = 2,

    /// <summary>
    /// Расчетная (экономика из ГФЭМ расчета).
    /// </summary>
    Calculated = 3
}