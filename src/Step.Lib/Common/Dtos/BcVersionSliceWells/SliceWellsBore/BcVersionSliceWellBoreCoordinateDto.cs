namespace Step.Lib.Common.Dtos.BcVersionSliceWells.SliceWellsBore;

/// <summary>
/// DTO для координат ствола скважины.
/// </summary>
public class BcVersionSliceWellBoreCoordinateDto
{
    /// <summary>
    /// ID записи.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ID скважины среза версии БК.
    /// </summary>
    public Guid BcVersionSliceWellId { get; set; }

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