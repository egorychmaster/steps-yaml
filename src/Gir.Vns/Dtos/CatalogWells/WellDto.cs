using Gir.Vns.Dtos.Clusters;
using Gir.Vns.Dtos.WellConditions;
using Gir.Vns.Dtos.WellPurposes;
using Gir.Vns.Dtos.WellTypes;

namespace Gir.Vns.Dtos.CatalogWells;

/// <summary>
/// Dto чтения сущности скважины.
/// </summary>
public class WellDto
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
    /// Идентификатор куста.
    /// </summary>
    public Guid ClusterId { get; set; }

    /// <summary>
    /// Идентификатор типа скважины.
    /// </summary>
    public Guid? WellTypeId { get; set; }

    /// <summary>
    /// Идентификатор назначения скважины.
    /// </summary>
    public Guid? WellPurposeId { get; set; }

    /// <summary>
    /// Наименование состояния скважины.
    /// </summary>
    public Guid? WellConditionId { get; set; }

    /// <summary>
    /// Идентификатор способа эксплуатации.
    /// </summary>
    public Guid? WellExploitationId { get; set; }

    /// <summary>
    /// Идентификатор характера работы скважины.
    /// </summary>
    public Guid? WellNatureId { get; set; }

    /// <summary>
    /// Идентификатор цеха.
    /// </summary>
    public Guid? WorkshopId { get; set; }

    /// <summary>
    /// Номер скважины.
    /// </summary>
    public string Number { get; set; } = null!;

    /// <summary>
    /// Координаты скважины широта.
    /// </summary>
    public decimal? CoordinatesW { get; set; }

    /// <summary>
    /// Координаты скважины долгота.
    /// </summary>
    public decimal? CoordinatesL { get; set; }

    /// <summary>
    /// Микросейсмика (да/нет).
    /// </summary>
    public bool? Microseismic { get; set; }

    /// <summary>
    /// Год начала бурения куста.
    /// </summary>
    public DateTime? DrillingClusterYear { get; set; }

    /// <summary>
    /// Дата сдачи.
    /// </summary>
    public DateTime? DateStartWellFact { get; set; }

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
    /// Dto <see cref="WorkshopDto"/>.
    /// </summary>
    public WorkshopDto? Workshop { get; set; }

    /// <summary>
    /// Dto <see cref="ClusterDto"/>.
    /// </summary>
    public ClusterDto Cluster { get; set; } = default!;

    /// <summary>
    /// Dto <see cref="WellTypeDto"/>.
    /// </summary>
    public WellTypeDto? WellType { get; set; } = default!;

    /// <summary>
    /// Dto <see cref="WellPurposeDto"/>.
    /// </summary>
    public WellPurposeDto? WellPurpose { get; set; } = default!;

    /// <summary>
    /// Dto <see cref="WellConditionDto"/>.
    /// </summary>
    public WellConditionDto? WellCondition { get; set; } = default!;
}