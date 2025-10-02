using Gir.Vns.Dtos.Common;

namespace Gir.Vns.Dtos.WellIndicatorTypes;

/// <summary>
/// Одна запись справочника 'Показатели ТЕРРА'
/// </summary>
public class WellIndicatorTypeDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя.<br/>
    /// В справочнике наименование является уникальным без учета регистра.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// ID единицы измерения.<br/>
    /// </summary>
    public Guid UnitId { get; set; }

    /// <summary>
    /// Единица измерения.
    /// </summary>
    public UnitDto Unit { get; set; } = null!;

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }

    /// <summary>
    /// Удалено.
    /// </summary>
    public bool IsDeleted { get; set; }
}