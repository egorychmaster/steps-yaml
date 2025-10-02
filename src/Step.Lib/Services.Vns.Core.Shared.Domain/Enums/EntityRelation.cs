namespace Step.Lib.Services.Vns.Core.Shared.Domain.Enums;

/// <summary>
/// Перечисление типов сущностей, к которым может быть отношение.
/// </summary>
public enum EntityRelation
{
    /// <summary>
    /// Отношение к сущности "Версия БК".
    /// </summary>
    BcVersion,

    /// <summary>
    /// Отношение к сущности "Данные версии БК".
    /// </summary>
    BcVersionData,

    /// <summary>
    /// Отношение к сущности "Версия БК на прогнозе".
    /// </summary>
    BcVersionForecast,

    /// <summary>
    /// Отношение к сущности "Скважина данных версии БК".
    /// </summary>
    BcVersionDataWell,

    /// <summary>
    /// Отношение к сущности 'Цикл БК (данных версии БК)'
    /// </summary>
    BcCycle,

    /// <summary>
    /// Отношение к сущности "Месторождение данных версии БК".
    /// </summary>
    BcVersionDataField,
}