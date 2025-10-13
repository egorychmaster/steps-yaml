using Step.Lib.Common.Dtos.BcVersionSliceWells.SliceWellsBore;

namespace Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWellsBore;

/// <summary>
/// Ствол скважины среза версии БК
/// </summary>
public class WellBoreCreateDto
{
    /// <summary>
    /// Номер ствола.
    /// </summary>
    public short Number { get; set; }

    /// <summary>
    /// Тип ствола (1 - основной, 2 - дополнительный).
    /// </summary>
    public short Type { get; set; }

    /// <summary>
    /// Координаты ствола.
    /// </summary>
    public List<WellBoreCoordinateItemDto> Coordinates { get; set; } = new();

    /// <summary>
    /// Длина (в метрах).
    /// </summary>
    public short Length { get; set; }
}
