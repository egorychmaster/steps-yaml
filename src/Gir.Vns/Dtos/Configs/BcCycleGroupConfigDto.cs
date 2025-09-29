namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурации групп циклов версии БК.
/// </summary>
public class BcCycleGroupConfigDto
{
    /// <summary>
    /// Доступные типы статусов.
    /// </summary>
    public required List<BcCycleGroupTypeDto> Types { get; init; }
}