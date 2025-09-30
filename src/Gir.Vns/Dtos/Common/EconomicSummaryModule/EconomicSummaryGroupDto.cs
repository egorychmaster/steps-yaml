namespace Gir.Vns.Dtos.Common.EconomicSummaryModule;

/// <summary>
/// Группа экономических данных.
/// </summary>
public class EconomicSummaryGroupDto
{
    /// <summary>
    /// Плановая экономика.
    /// Под плановой экономикой подразумеваются данные "Мерак" (загрузчик "Паспорт ИП").
    /// </summary>
    public EconomicSummaryDto? Plan { get; set; }

    /// <summary>
    /// Фактическая экономика.
    /// Под фактической экономикой подразумеваются данные экономики, которые берутся с загрузчиков
    /// (за исключением "Паспорт ИП"), которые загружаются во время жизненного цикла версии БК на прогнозе
    /// (данных версии БК, `BcVersionData`).
    /// </summary>
    public EconomicSummaryDto? Fact { get; set; }

    /// <summary>
    /// Расчетная экономика.
    /// Под расчетной экономикой подразумеваются данные от системы "ГФЭМ", которые были рассчитаны на основе
    /// данных версии БК на прогнозе (`BcVersionData`).
    /// </summary>
    public EconomicSummaryDto? Calculated { get; set; }
}