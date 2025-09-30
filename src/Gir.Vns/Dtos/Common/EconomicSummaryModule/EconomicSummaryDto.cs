namespace Gir.Vns.Dtos.Common.EconomicSummaryModule;

/// <summary>
/// Экономические данные.
/// </summary>
public class EconomicSummaryDto
{
    /// <summary>
    /// Значение PI.
    /// </summary>
    public Decimal? Pi { get; set; }

    /// <summary>
    /// Значение PVI.
    /// </summary>
    public Decimal? Pvi { get; set; }

    /// <summary>
    /// Значение NPV.
    /// </summary>
    public Decimal? Npv { get; set; }

    /// <summary>
    /// Значение OPEX.
    /// </summary>
    public Decimal? Opex { get; set; }

    /// <summary>
    /// Значение REVEX.
    /// </summary>
    public Decimal? Revex { get; set; }

    /// <summary>
    /// Значение CAPEX.
    /// </summary>
    public Decimal? Capex { get; set; }

    /// <summary>
    /// Накопленная добыча нефти.
    /// </summary>
    public Decimal? TotalOil { get; set; }

    /// <summary>
    /// Общий фонд скважин.
    /// </summary>
    public Decimal? TotalWells { get; set; }

    /// <summary>
    /// Значение DPP.
    /// </summary>
    public Decimal? Dpp { get; set; }

    /// <summary>
    /// Общие инвестиции.
    /// </summary>
    public Decimal? Investments { get; set; }
}