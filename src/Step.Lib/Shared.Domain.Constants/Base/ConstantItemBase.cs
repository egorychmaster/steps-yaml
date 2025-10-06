namespace Step.Lib.Shared.Domain.Constants.Base;

/// <summary>
/// Базовый класс для элемента константы.
/// </summary>
/// <param name="key">ID.</param>
/// <param name="name"> Наименование. </param>
public abstract class ConstantItemBase(short key, string name)
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public short Key => key;

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name => name;
}