namespace Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWells;

public class BcWellCreateDto
{
    /// <summary>
    /// ID куста данных версии БК.
    /// </summary>
    public Guid BcVersionDataClusterId {  get; set; }

    /// <summary>
    /// ID скважины.
    /// </summary>
    public Guid WellId { get; set; }
}
