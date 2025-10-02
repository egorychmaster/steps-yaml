namespace Gir.Vns.Dtos.Benefits;

/// <summary>
/// Льгота.
/// </summary>
public class BenefitDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Дата начала.
    /// </summary>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Дата окончания.
    /// </summary>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// Значение.
    /// </summary>
    public decimal? Value { get; set; }

    /// <summary>
    /// Тип льготы.
    /// </summary>
    public short Type { get; set; }

    /// <summary>
    /// Номер Скважины.
    /// </summary>
    public string? WellNumber { get; set; }

    /// <summary>
    /// Наименование пласта.
    /// </summary>
    public string? LayerFieldName { get; set; }

    /// <summary>
    /// Идентификатор справочника Состав актива.
    /// </summary>
    public Guid AssetContentId { get; set; }

    /// <summary>
    /// Тип категории льготы.
    /// </summary>
    public short? CategoryType { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }
}