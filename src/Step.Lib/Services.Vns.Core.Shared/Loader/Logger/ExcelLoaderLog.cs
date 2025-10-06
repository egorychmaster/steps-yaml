using Step.Lib.Services.Vns.Core.Shared.Loader.Enums;

namespace Step.Lib.Services.Vns.Core.Shared.Loader.Logger;

/// <summary>
/// Лог загрузчика.
/// </summary>
public class ExcelLoaderLog
{
    /// <summary>
    /// Тип лога.
    /// </summary>
    public LogType Type { get; }

    /// <summary>
    /// Сообщение.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Наименование страницы Excel.
    /// </summary>
    public string? SheetName { get; }

    /// <summary>
    /// Индекс строки.
    /// </summary>
    public int? RowIndex { get; }

    /// <summary>
    /// Номер строки.
    /// </summary>
    public int? RowNumber => RowIndex + 1;

    /// <summary>
    /// Индекс колонки.
    /// </summary>
    public int? ColumnIndex { get; }

    /// <summary>
    /// Номер колонки.
    /// </summary>
    public int? ColumnNumber => ColumnIndex + 1;

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="type">Тип лога.</param>
    /// <param name="message">Сообщение.</param>
    /// <param name="sheetName">Номер страницы excel.</param>
    /// <param name="rowIndex">Индекс строки.</param>
    /// <param name="columnIndex">Индекс колонки.</param>
    public ExcelLoaderLog(LogType type, string message, string? sheetName, int? rowIndex, int? columnIndex)
    {
        Type = type;
        Message = message;
        SheetName = sheetName;
        RowIndex = rowIndex;
        ColumnIndex = columnIndex;
    }

    /// <inheritdoc />
    public override string ToString()
        => $"Excel log - {Type}, Sheet: {SheetName}, Row: {RowNumber} [{RowIndex}], Column: {ColumnNumber}[{ColumnIndex}]: \n"
           + $"- {Message}";
}
