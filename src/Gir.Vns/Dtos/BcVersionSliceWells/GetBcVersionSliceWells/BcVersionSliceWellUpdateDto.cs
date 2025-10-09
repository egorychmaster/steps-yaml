using Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWellsBore;

namespace Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWells;

public class BcVersionSliceWellUpdateDto
{
    /// <summary>
    /// Атрибуты данной скважины.
    /// </summary>
    public BcVersionDataWellAttributesDto? Attributes { get; set; }

    /// <summary>
    /// Пласты данной скважины.
    /// </summary>
    public IReadOnlyCollection<BcVersionDataWellLayerDto> Layers { get; set; } = new List<BcVersionDataWellLayerDto>();

    /// <summary>
    /// Стволы скважины.
    /// </summary>
    public IEnumerable<WellBoreCreateDto> WellBores { get; set; } = Enumerable.Empty<WellBoreCreateDto>();
}
