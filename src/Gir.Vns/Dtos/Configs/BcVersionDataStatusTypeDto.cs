namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурации статуса версии БК.
/// </summary>
public class BcVersionDataStatusTypeDto
{
    /// <summary>
    /// Строчный тип (ключ) статуса версии БК.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }
}