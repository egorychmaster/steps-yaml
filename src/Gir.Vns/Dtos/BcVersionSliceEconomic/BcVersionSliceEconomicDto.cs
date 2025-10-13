using Step.Lib.Common.Dtos.EconomicSummaryModule;
using Step.Lib.Shared.Domain.Constants.Enums;

namespace Gir.Vns.Dtos.BcVersionSliceEconomic;

/// <summary>
/// Экономические данные.
/// </summary>
public class BcVersionSliceEconomicDto
{
    /// <summary>
    /// ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ID данных версии БК.
    /// </summary>
    public Guid? BcVersionDataId { get; set; }

    /// <summary>
    /// ID скважины данных версии БК.
    /// </summary>
    public Guid? DataWellId { get; set; }

    /// <summary>
    /// Тип экономических данных.
    /// </summary>
    public EconomicSummaryType Type { get; set; }

    /// <summary>
    /// Тип экономических данных.
    /// </summary>
    public EconomicDataType? DataType { get; set; }

    /// <summary>
    /// ID документа из S3 сервиса, содержащего экономические данные.
    /// </summary>
    public Guid? DocumentId { get; set; }

    /// <summary>
    /// Экономические показатели.
    /// </summary>
    public EconomicSummaryDto Summary { get; set; } = null!;

    /// <summary>
    /// Дата и время создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Дата и время обновления.
    /// </summary>
    public DateTime? DateUpdated { get; set; }
}
