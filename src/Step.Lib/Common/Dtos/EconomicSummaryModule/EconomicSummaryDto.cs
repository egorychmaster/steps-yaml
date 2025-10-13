namespace Step.Lib.Common.Dtos.EconomicSummaryModule;

/// <summary>
/// Экономические данные.
/// </summary>
public class EconomicSummaryDto
{
    /// <summary>
    /// Значение PI.
    /// </summary>
    public decimal? Pi { get; set; }

    /// <summary>
    /// Значение PVI.
    /// </summary>
    public decimal? Pvi { get; set; }

    /// <summary>
    /// Значение NPV.
    /// </summary>
    public decimal? Npv { get; set; }

    /// <summary>
    /// Значение OPEX.
    /// </summary>
    public decimal? Opex { get; set; }

    /// <summary>
    /// Значение REVEX.
    /// </summary>
    public decimal? Revex { get; set; }

    /// <summary>
    /// Значение CAPEX.
    /// </summary>
    public decimal? Capex { get; set; }

    /// <summary>
    /// Накопленная добыча нефти.
    /// </summary>
    public decimal? TotalOil { get; set; }

    /// <summary>
    /// Общий фонд скважин.
    /// </summary>
    public decimal? TotalWells { get; set; }

    /// <summary>
    /// Значение DPP.
    /// </summary>
    public decimal? Dpp { get; set; }

    /// <summary>
    /// Общие инвестиции.
    /// </summary>
    public decimal? Investments { get; set; }
}