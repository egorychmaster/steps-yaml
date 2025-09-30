namespace Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWells;

/// <summary>
/// Пласт скважины данных версии БК.
/// </summary>
public class BcVersionDataWellLayerDto
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