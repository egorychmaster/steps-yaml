using Step.Lib.Shared.Domain.Constants.Base;
using Step.Lib.Shared.Domain.Constants.Extensions;

namespace Step.Lib.Shared.Domain.Constants.Extensions;

/// <summary>
/// Расширения для констант.
/// </summary>
public static class ConstantExtensions
{
    /// <summary>
    /// Получение константы из списка констант по ключу.
    /// </summary>
    /// <typeparam name="TConstantItem">Тип константы</typeparam>
    /// <param name="constantItems">Список констант.</param>
    /// <param name="key">Ключ константы.</param>
    /// <returns>Найденная константа из <paramref name="constantItems"/>.</returns>
    /// <exception cref="InvalidOperationException"> если ключ не найден в коллекции</exception>
    public static TConstantItem Get<TConstantItem>(this IEnumerable<TConstantItem> constantItems, short key)
        where TConstantItem : ConstantItemBase
        => constantItems.First(x => x.Key == key);

    /// <summary>
    /// Получение константы из списка констант по ключу.
    /// </summary>
    /// <typeparam name="TConstantItem">Тип константы.</typeparam>
    /// <typeparam name="TKey">Тип ключа константы.</typeparam>
    /// <param name="constantItems">Список констант.</param>
    /// <param name="key">Ключ константы.</param>
    /// <returns>Найденная константа из <paramref name="constantItems"/>.</returns>
    /// <exception cref="InvalidOperationException"> если ключ не найден в коллекции</exception>
    public static TConstantItem Get<TConstantItem, TKey>(this IEnumerable<TConstantItem> constantItems, TKey key)
        where TConstantItem : ConstantItemGeneric<TKey>
        where TKey : notnull
        => constantItems.First(x => x.Key!.Equals(key));

    /// <summary>
    /// Получение константы из списка констант по ключу или <see langword="null"/>.
    /// </summary>
    /// <typeparam name="TConstantItem">Тип константы.</typeparam>
    /// <param name="constantItems">Список констант.</param>
    /// <param name="key">Ключ константы.</param>
    /// <returns>Константа или <see langword="null"/>.</returns>
    public static TConstantItem? FirstOrDefault<TConstantItem>(this IEnumerable<TConstantItem> constantItems, short key)
        where TConstantItem : ConstantItemBase
        => constantItems.FirstOrDefault(x => x.Key == key);
}