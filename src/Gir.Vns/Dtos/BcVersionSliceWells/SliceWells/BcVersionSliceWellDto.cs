using Gir.Vns.Dtos.Common.EconomicSummaryModule;
using System.Text.Json.Serialization;

namespace Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWells;

/// <summary>
/// Скважина среза версии БК.
/// </summary>
public class BcVersionSliceWellDto
{
    // 🎯 Свойства
    /// <summary>
    /// Уникальный ID entity.
    /// </summary>
    [JsonPropertyOrder(-100)]
    public Guid Id { get; }

    /// <summary>
    /// ID куста данных версии БК, к которому относится данная скважина.
    /// </summary>
    public Guid DataClusterId { get; set; }

    /// <summary>
    /// ID скважины (из MDM сервиса).
    /// </summary>
    public Guid WellId { get; set; }

    /// <summary>
    /// Атрибуты данной скважины.
    /// </summary>
    public BcVersionSliceWellAttributesDto? Attributes { get; set; }

    /// <summary>
    /// Пласты данной скважины.
    /// </summary>
    public IReadOnlyCollection<BcVersionSliceWellLayerDto> Layers { get; set; } = new List<BcVersionSliceWellLayerDto>();

    /// <summary>
    /// Экономика данной скважины.
    /// </summary>
    public EconomicSummaryGroupDto Economic { get; set; } = null!;

    /// <summary>
    /// Дата создания.
    /// </summary>
    [JsonPropertyOrder(100)]
    public DateTime DateCreated { get; }
    /// <summary>
    /// Дата последнего изменения.
    /// </summary>
    [JsonPropertyOrder(101)]
    public DateTime? DateUpdated { get; }


    // 🛠 Конструкторы
}