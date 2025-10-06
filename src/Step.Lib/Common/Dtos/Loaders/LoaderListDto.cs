using Step.Lib.Common.Dtos.Loaders.Enums;
using Step.Lib.Services.Vns.Core.Shared.Loader.Logger;

namespace Step.Lib.Common.Dtos.Loaders;

/// <summary>
/// Результат загрузки.
/// </summary>
public class LoaderListDto
{
    /// <summary>
    /// Идентификатор загрузки.
    /// </summary>
    public Guid LoaderId { get; set; }

    /// <summary>
    /// Тип загрузчика.
    /// </summary>
    public LoadType Type { get; set; }

    /// <summary>
    /// Дата старта обработки.
    /// </summary>
    public DateTime DateStart { get; set; }

    /// <summary>
    /// Дата завершения обработки.
    /// </summary>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// Лог по загрузке.
    /// </summary>
    public IEnumerable<ExcelLoaderLog> Log { get; set; }
}
