namespace Gir.Vns.Dtos.CatalogLayers;

/// <summary>
/// Одна запись справочника 'Пласты месторождений'.<br/>
/// Пара [<see cref="FieldId"/>; <see cref="Name"/>] является уникальной в рамках справочника.
/// </summary>
public class LayerDto
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
    /// Идентификатор месторождения.<br/>
    /// см. <see cref="FieldDto.Id"/>
    /// </summary>
    public Guid? FieldId { get; set; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Идентификатор OIS.
    /// </summary>
    public Guid? OisId { get; set; }

    /// <summary>
    /// Идентификатор КЛАД
    /// </summary>
    public Guid? KladId { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }
}