namespace Step.Lib.Common.Dtos.Filter.Sorting;

/// <summary>
/// Модель сортировки.
/// </summary>
/// <param name="key">Ключ из enum, по которому будет идти сортировка.</param>
/// <param name="directionType">Сторона сортировки.</param>
public class SortOption<E>(E key, OrderDirectionType directionType)
    where E : struct, Enum
{
    /// <summary>
    /// В enum имя поля для сортировки.
    /// </summary>
    public E Key { get; } = key;

    /// <summary>
    /// Направление.
    /// </summary>
    public OrderDirectionType DirectionType { get; } = directionType;
}