namespace Gir.Vns.Dtos.Benefits;

/// <summary>
/// Модель Справочник льгот.
/// </summary>
/// <inheritdoc/>
public class BenefitDmo
{
    public Guid Id { get; set; }

    /// <inheritdoc/>
    public AssetsContentDmo? AssetsContent { get; set; }

    /// <inheritdoc/>
    public string? WellNumber { get; set; }

    /// <inheritdoc/>
    public string? LayerFieldName { get; set; }

    /// <inheritdoc/>
    public int? BenefitType { get; set; }

    /// <inheritdoc/>
    public int? CategoryType { get; set; }

    /// <inheritdoc/>
    public decimal? Value { get; set; }

    /// <inheritdoc/>
    public DateTime? DateStart { get; set; }

    /// <inheritdoc/>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// ИД категории льготы
    /// </summary>
    public int? BenefitCategoryId { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }

    /// <summary>
    /// Признак удаления записи.
    /// </summary>
    public bool? IsDeleted { get; set; }
}