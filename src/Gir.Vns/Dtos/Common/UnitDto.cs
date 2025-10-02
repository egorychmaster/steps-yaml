namespace Gir.Vns.Dtos.Common;

/// <summary>
/// Одна запись справочника 'Единицы измерения'
/// </summary>
public class UnitDto
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
    /// Идентификатор родительской сущности.
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// Наименование.<br/>
    /// В справочнике наименование является уникальным без учета регистра.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }
}