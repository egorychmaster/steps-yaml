using Gir.Vns.Dtos.Common.Fields;

namespace Gir.Vns.Dtos.CatalogClusters;

/// <summary>
/// Куст.
/// </summary>
public class ClusterDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор из КСУ НСИ.
    /// </summary>
    public Guid? NsiId { get; set; }

    /// <summary>
    /// Идентификатор месторождения.
    /// </summary>
    public Guid FieldId { get; set; }

    /// <summary>
    /// Номер куста.
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// Признак предварительного заполнения.
    /// </summary>
    public bool? IsPreparatory { get; set; }

    /// <summary>
    /// Координаты куста (широта).
    /// </summary>
    public decimal? CoordinatesW { get; set; }

    /// <summary>
    /// Координаты куста (долгота).
    /// </summary>
    public decimal? CoordinatesL { get; set; }

    /// <summary>
    /// Признак копии.
    /// </summary>
    public bool IsCopy { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }

    /// <summary>
    /// Dto месторождения.
    /// </summary>
    public FieldDto Field { get; set; } = null!;
}