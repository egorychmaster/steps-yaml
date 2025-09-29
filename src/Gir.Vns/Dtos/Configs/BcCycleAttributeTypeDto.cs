using Gir.Vns.Domain.Enums;

namespace Gir.Vns.Dtos.Configs;

/// <summary>
/// Конфигурации атрибута цикла БК.
/// </summary>
public class BcCycleAttributeTypeDto
{
    /// <summary>
    /// Строчный тип (ключ) цикла.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Тип значения атрибута. <br/>
    /// См. `AttributeValueType` в Schemas. <br/>
    /// </summary>
    public required AttributeValueType ValueType { get; init; }

    /// <summary>
    /// Тип сущности, к которой относится атрибут. <br/>
    /// Если `null` - атрибут относится только к циклу БК. <br/>
    /// См. `AttributeEntityType` в Schemas.
    /// </summary>
    public AttributeEntityType? EntityType { get; init; }
}