using System.ComponentModel.DataAnnotations;

namespace Gir.Vns.Dtos.CatalogClusters;

/// <summary>
/// Dto создания куста.
/// </summary>
public class ClusterCreateDto
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
    [Required]
    public string Number { get; set; } = null!;

    /// <summary>
    /// Признак предварительного заполнения.
    /// </summary>
    public bool? IsPreparatory { get; set; }

    /// <summary>
    /// Координаты куста широта
    /// </summary>
    public decimal? CoordinatesW { get; set; }

    /// <summary>
    /// Координаты куста долгота.
    /// </summary>
    public decimal? CoordinatesL { get; set; }

    /// <summary>
    /// Признак копии.
    /// </summary>
    public bool IsCopy { get; set; }
}