namespace Step.Lib.Shared.Domain.Constants.Enums;

/// <summary>
/// Тип сценария.
/// </summary>
public enum BcVersionScenarioType : short
{
    /// <summary>
    /// Оптимистичный.
    /// </summary>
    Optimistic = 1,

    /// <summary>
    /// Средний.
    /// </summary>
    Normal = 2,

    /// <summary>
    /// Пессимистичный.
    /// </summary>
    Pessimistic = 3,
}