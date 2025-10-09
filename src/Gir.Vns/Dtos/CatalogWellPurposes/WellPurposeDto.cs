namespace Gir.Vns.Dtos.CatalogWellPurposes;

/// <summary>
/// DTO (чтение записи из справочника 'Назначение скважины')
/// </summary>
public class WellPurposeDto
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
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Краткое наименование состояния скважины.
    /// </summary>
    public string? ShortName { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }
}
