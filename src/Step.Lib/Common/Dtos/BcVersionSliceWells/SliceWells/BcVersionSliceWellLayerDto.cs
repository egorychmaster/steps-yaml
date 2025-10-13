namespace Step.Lib.Common.Dtos.BcVersionSliceWells.SliceWells;

/// <summary>
/// Пласт скважины среза версии БК.
/// </summary>
public class BcVersionSliceWellLayerDto
{
    // 🎯 Свойства
    /// <summary>
    /// ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ID пласта (из MDM сервиса).
    /// </summary>
    public Guid LayerId { get; set; }


    // 🛠 Конструкторы
    //public BcVersionDataWellLayerDto(Guid id, Guid layerId)
    //{
    //    Id = id;
    //    LayerId = layerId;
    //}
}