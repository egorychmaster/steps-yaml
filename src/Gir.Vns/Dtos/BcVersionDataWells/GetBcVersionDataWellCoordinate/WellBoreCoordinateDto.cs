namespace Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWellCoordinate;

/// <summary>
/// DTO для координат ствола скважины.
/// </summary>
public class WellBoreCoordinateDto
{
    /// <summary>
    /// ID записи.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ID скважины данных версии БК.
    /// </summary>
    public Guid BcVersionDataWellId { get; set; }

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