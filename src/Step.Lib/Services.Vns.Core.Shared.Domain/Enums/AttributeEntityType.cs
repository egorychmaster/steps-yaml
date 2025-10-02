namespace Step.Lib.Services.Vns.Core.Shared.Domain.Enums;

/// <summary>
/// Перечисление типов сущности атрибутов.
/// </summary>
public enum AttributeEntityType
{
    /// <summary>
    /// Отношение к сущности "Скважина данных версии БК".
    /// </summary>
    BcVersionDataWell = 1,

    /// <summary>
    /// Бк версии куста.
    /// </summary>
    BcVersionDataCluster = 2,

    /// <summary>
    /// Отношение к сущности 'Цикл БК (данных версии БК)'
    /// </summary>
    BcCycle = 3,
}