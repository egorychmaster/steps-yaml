using Step.Lib.Services.Vns.Core.Shared.Domain.Enums;

namespace Step.Lib.Common.Dtos.ApplicationConfig;

/// <summary>
/// Модель конфигурации ключевых показателей (КПЭ).
/// </summary>
public sealed class KeyIndicatorConfig
{
    /// <summary>
    /// Конфигурации доступных типов ключевых показателей.
    /// </summary>
    public required IReadOnlyCollection<KeyIndicatorType> Types { get; init; }

    /// <summary>
    /// Получает конфигурацию ключевого показателя по строчному типу.
    /// </summary>
    /// <param name="type">Строчный тип ключевого показателя.</param>
    /// <exception cref="ArgumentNullException">Если конфигурация по переданному типу не найдена.</exception>
    /// <returns>Найденная конфигурация ключевого показателя.</returns>
    public KeyIndicatorType GetType(string type)
    {
        var indicatorType = Types.SingleOrDefault(x => x.Type == type);

        if (indicatorType == null)
            throw new ArgumentNullException(nameof(type), $"Не найдена конфигурация для типа КПЭ \"{type}\".");

        return indicatorType;
    }

    /// <summary>
    /// Получает правило расчета семантики по типу ключевого показателя.
    /// </summary>
    /// <param name="type">Строчный тип ключевого показателя.</param>
    /// <exception cref="ArgumentNullException">
    /// Если конфигурация ключевого показателя по переданному типу не найдена.
    /// </exception>
    /// <returns>
    /// Правило расчета семантики ключевого показателя. <br/>
    /// Если возвращен <see langword="null"/> - для данного типа ключевого показателя не установлено правило.
    /// </returns>
    public ValueSemanticRule? GetSemanticRule(string type)
        => GetType(type).SemanticRule;
}

/// <summary>
/// Модель конфигурации ключевого показателя (КПЭ).
/// </summary>
/// <seealso cref="KeyIndicator"/>
public sealed class KeyIndicatorType
{
    /// <summary>
    /// Тип показателя.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Родительский тип показателя.
    /// </summary>
    /// <remarks>
    /// В общем случае родительский тип влияет на отображение КПЭ в UI,
    /// где на основе этого будет строиться иерархия.
    /// </remarks>
    public string? ParentType { get; init; }

    /// <summary>
    /// Параметры отображения.
    /// </summary>
    public IReadOnlyCollection<KeyIndicatorViewOption> ViewOptions { get; init; } = [];

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Сущность, к которой относится данное КПЭ.
    /// </summary>
    public required EntityRelation TargetEntity { get; init; }

    /// <summary>
    /// Правило семантики для конечного значения по показателю данного типа.
    /// </summary>
    /// <remarks>
    /// Если не задано - расчет семантики для показателей с данным типом не производится.
    /// </remarks>
    public ValueSemanticRule? SemanticRule { get; init; } = null;

    /// <summary>
    /// Типы циклов БК, к которым относится данный тип показателя.
    /// </summary>
    /// <remarks>
    /// Если равен <see langword="null"/> или пуст - данный тип показателя не относится к циклам.
    /// </remarks>
    public IReadOnlyCollection<string> BcCycleTypes { get; init; } = [];
}