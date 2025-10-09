namespace Gir.Vns.Dtos.Benefits;

/// <summary>
/// Льгота.
/// </summary>
/// <inheritdoc/>
public class BenefitSlmDto
{
    public Guid Id { get; set; }

    /// <summary>
    /// Модуль
    /// </summary>
    public ProjectWell ProjectWell { get; set; } = null!;

    /// <summary>
    /// Значение льготы
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// Дата начала
    /// </summary>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Дата окончания
    /// </summary>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// ИД категории льготы
    /// </summary>
    public long? BenefitCategoryId { get; set; }

    /// <summary>
    /// Тип льготы
    /// </summary>
    public short BenefitType { get; set; }

    /// <summary>
    /// Дата создания. 
    /// </summary>
    public DateTime DateCreated { get; set; }
}