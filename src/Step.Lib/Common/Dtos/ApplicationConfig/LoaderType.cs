using Step.Lib.Vns.Core.Shared.Domain.Constants.Enums;

namespace Step.Lib.Common.Dtos.ApplicationConfig;

/// <summary>
/// Модель конфигурации типа загрузчика.
/// </summary>
public sealed class LoaderType
{
    /// <summary>
    /// Строчный тип (ключ).
    /// </summary>
    /// <remarks>
    /// Ключ должен присутствовать в <see cref="Domain.Constants.LoaderTypes"/>
    /// </remarks>
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

    /// <summary>
    /// Флаг возможности загрузить файл на несколько БК.
    /// </summary>
    public bool AllowMultipleBcUpload { get; init; } = false;

    /// <summary>
    /// Является ли загрузчик опциональным.
    /// </summary>
    public bool IsOptional { get; init; } = false;
}