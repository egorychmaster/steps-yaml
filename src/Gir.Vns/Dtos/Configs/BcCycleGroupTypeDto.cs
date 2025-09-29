namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурации группы цикла БК.
/// </summary>
public class BcCycleGroupTypeDto
{
    /// <summary>
    /// Строчный тип (ключ) группы цикла БК.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }
}