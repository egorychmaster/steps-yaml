namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурации циклов БК.
/// </summary>
public class BcCycleConfigDto
{
    /// <summary>
    /// Доступные типы циклов БК.
    /// </summary>
    public required IReadOnlyCollection<BcCycleTypeDto> Types { get; init; }
}