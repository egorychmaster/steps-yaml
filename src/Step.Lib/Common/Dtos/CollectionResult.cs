namespace Step.Lib.Common.Dtos;

/// <summary>
/// Результат чтения списка.
/// </summary>
/// <typeparam name="T"> Тип элементов коллекции. </typeparam>
public class CollectionResult<T>
{
    // 🎯 Свойства
    /// <summary>
    /// Результат чтения.
    /// </summary>
    public IReadOnlyList<T> Result { get; }

    /// <summary>
    /// Общее количество элементов, попадающее под запрос.
    /// </summary>
    public long TotalCount { get; }


    // 🛠 Конструкторы
    /// <summary>
    /// Результат чтения списка.
    /// </summary>
    /// <param name="result"> Результат чтения. </param>
    /// <param name="totalCount"> Общее количество элементов, попадающее под запрос. </param>
    public CollectionResult(IReadOnlyList<T> result, long totalCount)
    {
        Result = result ?? throw new ArgumentNullException(nameof(result));
        TotalCount = totalCount;
    }
}