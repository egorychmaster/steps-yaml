namespace Step.Lib.Common.Dtos.BcVersionSliceWells.SliceWellsBore;

/// <summary>
/// Координатная точка ствола скважины.
/// </summary>
public class WellBoreCoordinateItemDto
{
    /// <summary>
    /// Координата X.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Координата Y.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Координата Z.
    /// </summary>
    public double Z { get; set; }

    /// <summary>
    /// Название точки.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}