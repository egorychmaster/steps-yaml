using Gir.Vns.Domain.Constants.Enums;

namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурации типа загрузчика.
/// </summary>
public class LoaderTypeDto
{
    /// <summary>
    /// Строчный тип (ключ).
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Механизм загрузки.
    /// </summary>
    /// <see cref="LoaderLoadingMechanism"/>
    public required LoaderLoadingMechanism LoadingMechanism { get; init; }
}