
using Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWellsBore;

namespace Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWells;

/// <summary>
/// Скважина среза версии БК
/// </summary>
public class BcVersionSliceWellCreateDto
{
    /// <summary>
    /// ID куста данных версии БК.
    /// </summary>
    public Guid BcVersionDataClusterId {  get; set; }

    /// <summary>
    /// ID скважины.
    /// </summary>
    public Guid WellId { get; set; }

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
