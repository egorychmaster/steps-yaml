namespace Step.Lib.Shared.Domain.Constants.Base;

/// <summary>
/// Базовый класс для элемента константы.
/// </summary>
/// <param name="key">ID.</param>
/// <param name="name"> Наименование. </param>
public abstract class ConstantItemGeneric<TKey>(TKey key, string name)
    where TKey : notnull
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public TKey Key => key;

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name => name;
}