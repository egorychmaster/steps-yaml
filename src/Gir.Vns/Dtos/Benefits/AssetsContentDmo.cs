using System.ComponentModel.DataAnnotations;

namespace Gir.Vns.Dtos.Benefits;

public class AssetsContentDmo
{
    public Guid Id { get; set; }

    /// <summary>
    /// Внешний ИД КСУ НСИ
    /// </summary>
    public Guid? IdKsuNsi { get; set; }

    /// <summary>
    /// Компания
    /// </summary>
    public ICompanyDmo? Company { get; set; }

    /// <summary>
    /// Лицензионный участок
    /// </summary>
    public ILicenseAreaDmo? LicenseArea { get; set; }

    /// <summary>
    /// Актив
    /// </summary>
    public IAssetDmo? Asset { get; set; }

    /// <summary>
    /// Месторождение
    /// </summary>
    public IFieldDmo? Field { get; set; }
}

/// <summary>
/// Интерфейс модели компании.
/// </summary>
/// <inheritdoc/>
public interface ICompanyDmo 
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ИД родительской компании
    /// </summary>
    public long? CompanyId { get; set; }

    /// <summary>
    /// Полное название компании
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Название компании
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// ИНН
    /// </summary>
    public string Inn { get; set; }

    /// <summary>
    /// КПП
    /// </summary>
    public string Kpp { get; set; }

    /// <summary>
    /// Префикс
    /// </summary>
    public string? Prefix { get; set; }

    /// <summary>
    /// Контрактор?
    /// </summary>
    public bool? IsContractor { get; set; }

    /// <summary>
    /// ИД Вид деятельности
    /// </summary>
    public long? ActivityTypeId { get; set; }
}

/// <summary>
/// Интерфейс модели Лицензионный участок.
/// </summary>
/// <inheritdoc/>
public interface ILicenseAreaDmo
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Компания
    /// </summary>
    [Required]
    public ICompanyDmo? Company { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Полное название
    /// </summary>
    public string FullName { get; set; }
}

/// <summary>
/// Интерфейс модели Актива.
/// </summary>
/// <inheritdoc/>
public interface IAssetDmo
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    string Name { get; set; }
}

/// <summary>
/// Интерфейс модели Месторождения.
/// </summary>
/// <inheritdoc/>
public interface IFieldDmo
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Внешний ИД КСУ НСИ
    /// </summary>
    public Guid? IdKsuNsi { get; set; }

    /// <summary>
    /// Район расположения
    /// </summary>
    public IAreaDmo? Area { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Код ДО
    /// </summary>
    public string? CompanyCode { get; set; }
}

/// <summary>
/// Интерфейс модели Района расположения.
/// </summary>
/// <inheritdoc/>
public interface IAreaDmo
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    string Name { get; set; }
}