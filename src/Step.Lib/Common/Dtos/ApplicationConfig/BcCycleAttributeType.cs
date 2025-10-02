using Step.Lib.Services.Vns.Core.Shared.Domain.Enums;

namespace Step.Lib.Common.Dtos.ApplicationConfig;

/// <summary>
/// Модель конфигурации атрибута цикла БК.
/// </summary>
public sealed class BcCycleAttributeType
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
    /// Тип значения атрибута.
    /// </summary>
    public required AttributeValueType ValueType { get; init; }

    /// <summary>
    /// Тип сущности.
    /// </summary>
    public required AttributeEntityType EntityType { get; init; }

    private bool _autoCreate = false;

    /// <summary>
    /// Флаг, указывающий, нужно ли автоматически создавать атрибут при создании цикла БК.
    /// </summary>
    public bool AutoCreate
    {
        get => _autoCreate;
        set => _autoCreate = value;
    }
}