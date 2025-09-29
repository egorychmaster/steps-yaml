namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурации статусов версии БК.
/// </summary>
public class BcVersionDataStatusConfigDto
{
    /// <summary>
    /// Доступные типы статусов.
    /// </summary>
    public required List<BcVersionDataStatusTypeDto> Types { get; init; }
}