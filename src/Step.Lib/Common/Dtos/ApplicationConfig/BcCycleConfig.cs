using Step.Lib.Services.Vns.Core.Shared.Domain.Enums;
using Step.Lib.Vns.Core.Shared.Domain.Constants.Enums;

namespace Step.Lib.Common.Dtos.ApplicationConfig;

/// <summary>
/// Модель конфигурации циклов БК.
/// </summary>
public sealed class BcCycleConfig
{
    /// <summary>
    /// Доступные типы циклов БК.
    /// </summary>
    public required IReadOnlyCollection<BcCycleType> Types { get; init; }

    /// <summary>
    /// Общий список доступных типов атрибутов, в соотношении с типом цикла БК.
    /// </summary>
    public IReadOnlyCollection<BcCycleToAttribute> AttributesFlattened => Types
        .SelectMany(cycle => cycle.AttributeTypes
            .Select(attr => new BcCycleToAttribute(cycle, attr)))
        .ToList();

    /// <summary>
    /// Строчные ключи доступных типов циклов БК.
    /// </summary>
    /// <seealso cref="Types"/>
    public IReadOnlyCollection<string> TypesOnly => Types.Select(x => x.Type).ToList();

    /// <summary>
    /// Типы циклов для процесса <see cref="BcProcessType.Fbk"/>, доступные для текущего приложения.
    /// </summary>
    public IReadOnlyCollection<BcCycleType> TypesFbk => Types.Where(x => x.BcProcessType is BcProcessType.Fbk).ToList();

    /// <summary>
    /// Типы циклов для процесса <see cref="BcProcessType.Uibk"/>, доступные для текущего приложения.
    /// </summary>
    public IReadOnlyCollection<BcCycleType> TypesUibk => Types.Where(x => x.BcProcessType is BcProcessType.Uibk).ToList();

    /// <summary>
    /// Получает тип цикла по строчному ключу.
    /// </summary>
    /// <param name="type">Строчный ключ типа цикла.</param>
    /// <returns>Тип цикла.</returns>
    /// <exception cref="ArgumentException">Если передан строчный ключ, тип по которому не найден.</exception>
    public BcCycleType Get(string type)
    {
        return Types.SingleOrDefault(x => x.Type == type)
            ?? throw new ArgumentException($"Не найден тип цикла по ключу \"{type}\"");
    }

    /// <summary>
    /// Получает тип цикла БК со сдвигом приоритета относительно текущего типа цикла.
    /// </summary>
    /// <param name="currentCycleType">Текущий тип цикла БК.</param>
    /// <param name="offset">Сдвиг приоритета.</param>
    /// <param name="isCrossProcess">
    /// Если <see langword="true"/> - будет искать тип цикла в том числе с другим типом процесса
    /// (см. <see cref="BcCycleType.BcProcessType"/>) (например если на вход получен последний по приоритету
    /// тип цикла в рамках процесса), иначе - только в рамках того же типа процесса.
    /// </param>
    /// <returns>Тип цикла БК с запрошенным сдвигом приоритета или <see langword="null"/>, если такой тип не найден.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если текущий тип цикла не найден в конфигурации.</exception>
    /// <seealso cref="BcCycleType"/>
    public BcCycleType? GetCycleTypeByPriorityOffset(string currentCycleType, int offset, bool isCrossProcess = false)
    {
        var currentType = Types.SingleOrDefault(x => x.Type == currentCycleType)
                          ?? throw new ArgumentException($"Тип цикла '{currentCycleType}' не найден в конфигурации.", nameof(currentCycleType));
        var typesToFindFrom =
            isCrossProcess ? Types : Types.Where(x => x.BcProcessType == currentType.BcProcessType);

        var targetPriority = currentType.Priority + offset;
        return typesToFindFrom.SingleOrDefault(x => x.Priority == targetPriority);
    }
}

/// <summary>
/// Модель конфигурации типа цикла БК.
/// </summary>
public sealed class BcCycleType
{
    /// <summary>
    /// Строчный тип (ключ) цикла.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Тип группы циклов, к которой относится данный тип цикла.
    /// </summary>
    /// <seealso cref="BcCycleGroupType"/>
    public required string GroupType { get; init; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Полное наименование.
    /// </summary>
    public required string FullName { get; init; }

    /// <summary>
    /// Приоритет.
    /// </summary>
    public required short Priority { get; init; }

    /// <summary>
    /// Нормативный срок выполнения, в днях.
    /// </summary>
    public required short NormativeInDays { get; init; }

    /// <summary>
    /// Тип процесса, к которому относится цикл.
    /// </summary>
    public required BcProcessType BcProcessType { get; init; }

    /// <summary>
    /// Разрешено ли копирование данных версии БК до данного типа цикла.
    /// </summary>
    public bool IsBcVersionDataCopyAllowed { get; init; } = true;

    /// <summary>
    /// Является ли шаг опциональным.
    /// </summary>
    public bool IsOptional { get; init; } = false;

    /// <summary>
    /// Типы экономических показателей, заполняемых на данном типе цикла.
    /// </summary>
    public IReadOnlyCollection<EconomicIndicatorType> EconomicIndicatorTypes { get; init; } = [];

    /// <summary>
    /// Типы загрузчиков, соотносимые к данному типу цикла.
    /// </summary>
    public required IReadOnlyCollection<string> LoaderTypes { get; init; }

    /// <summary>
    /// Типы атрибутов, соотносимые к данному типу цикла.
    /// </summary>
    public required IReadOnlyCollection<BcCycleAttributeType> AttributeTypes { get; init; }
}

/// <summary>
/// Модель содержащая тип цикла БК и тип атрибута, который относится к циклу БК.
/// </summary>
public sealed class BcCycleToAttribute(BcCycleType cycle, BcCycleAttributeType attribute)
{
    /// <summary>
    /// Тип цикла БК.
    /// </summary>
    public BcCycleType Cycle { get; } = cycle;

    /// <summary>
    /// Тип атрибута, который относится к типу цикла БК.
    /// </summary>
    public BcCycleAttributeType Attribute { get; } = attribute;
}