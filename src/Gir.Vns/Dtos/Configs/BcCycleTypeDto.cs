using Gir.Vns.Domain.Constants.Enums;

namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурации типа цикла БК.
/// </summary>
public sealed class BcCycleTypeDto
{
    /// <summary>
    /// Строчный тип (ключ) цикла.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Тип группы циклов, к которой относится данный тип цикла.
    /// </summary>
    public required string GroupType { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Полное наименование.
    /// </summary>
    public required string FullName { get; init; }

    /// <summary>
    /// Приоритет.
    /// </summary>
    public required short Priority { get; init; }

    /// <summary>
    /// Нормативный срок выполнения, в днях.
    /// </summary>
    public required short NormativeInDays { get; init; }

    /// <summary>
    /// Тип процесса, к которому относится цикл.
    /// </summary>
    public required BcProcessType BcProcessType { get; init; }

    /// <summary>
    /// Разрешено ли копирование данных версии БК до данного типа цикла.
    /// </summary>
    public bool IsBcVersionDataCopyAllowed { get; init; }

    /// <summary>
    /// Типы загрузчиков, соотносимые к данному типу цикла.
    /// </summary>
    public required IReadOnlyCollection<string> LoaderTypes { get; init; }

    /// <summary>
    /// Типы атрибутов, соотносимые к данному типу цикла.
    /// </summary>
    public required IReadOnlyCollection<BcCycleAttributeTypeDto> AttributeTypes { get; init; }
}