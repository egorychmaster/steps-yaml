namespace Gir.Vns.Dtos.CatalogWells;

public class UpdateWellDto
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
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Координаты скважины — широта.
    /// </summary>
    public double? CoordinatesW { get; set; }

    /// <summary>
    /// Координаты скважины — долгота.
    /// </summary>
    public double? CoordinatesL { get; set; }

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
}
