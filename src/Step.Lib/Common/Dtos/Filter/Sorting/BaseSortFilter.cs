using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Step.Lib.Common.Dtos.Filter.Sorting;

/// <summary>
/// Базовый класс DTO с сортировкой.
/// </summary>
/// <typeparam name="TEntity">Сущность, по которой будет производится сортировка.</typeparam>
/// <typeparam name="TPropertyEnum">Перечисление со полями по которым допускается сортировка.</typeparam>
public abstract class BaseSortFilter<TEntity, TPropertyEnum>
    where TEntity : class
    where TPropertyEnum : struct, Enum
{
    // 🧱 Поля
    /// <summary>
    /// Разделитель значений в объекте строки.
    /// </summary>
    private const char ValueDelimiter = '.';


    // 🎯 Свойства
    /// <summary>
    /// **Ключи сортировки:**
    /// Переопределите в наследнике, задав необходимое описание.
    /// </summary>
    public virtual string[]? SortOptions { get; init; }

    /// <summary>
    /// Поддерживаемые сортировки.
    /// Переопределите в наследнике, задав поддерживаемые сортировки.
    /// </summary>
    protected virtual Dictionary<TPropertyEnum, Expression<Func<TEntity, object>>> SupportedSortings { get; } = new();


    // ⚙️ Методы
    /// <summary>
    /// Получить поддерживаемые сортировки.
    /// </summary>
    /// <returns></returns>
    public Dictionary<TPropertyEnum, Expression<Func<TEntity, object>>> GetSupportedSortings() => SupportedSortings;

    /// <summary>
    /// Параметры сортировки.
    /// </summary>
    public List<SortOption<TPropertyEnum>> GetSortOptions() => ConvertSortOptions(SortOptions);

    private static List<SortOption<TPropertyEnum>> ConvertSortOptions(string[]? sortOptions)
    {
        if (sortOptions is null) return [];

        return sortOptions
            .Where(value => !string.IsNullOrEmpty(value))
            .Select(value =>
            {
                var sortOptionValues = value.Split(ValueDelimiter);
                if (!Enum.TryParse(sortOptionValues[0], ignoreCase: true, out TPropertyEnum keyEnum))
                    throw new ValidationException(
                        $"String with value '{sortOptionValues[0]}' cannot be converted to Enum type '{nameof(TPropertyEnum)}'. " +
                        $"This type contains values: {string.Join(",", Enum.GetNames(typeof(TPropertyEnum)))}."
                        );

                return new SortOption<TPropertyEnum>(
                    key: keyEnum,
                    directionType: GetDirectionType(sortOptionValues.ElementAtOrDefault(1)));
            })
            .ToList();
    }

    private static OrderDirectionType GetDirectionType(string? value)
    {
        // Если не передано направление сортировки, то по умолчанию она возрастающая.
        if (string.IsNullOrWhiteSpace(value))
            return OrderDirectionType.Asc;

        if (!Enum.TryParse(value, ignoreCase: true, out OrderDirectionType orderEnum))
            throw new ValidationException(
                $"String with value '{value}' cannot be converted to Enum type '{nameof(OrderDirectionType)}'. " +
                $"This type contains values: {string.Join(",", Enum.GetNames(typeof(OrderDirectionType)))}."
                );

        return orderEnum;
    }
}