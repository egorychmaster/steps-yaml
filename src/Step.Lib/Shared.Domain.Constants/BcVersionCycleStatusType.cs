using Step.Lib.Shared.Domain.Constants.Base;
using Step.Lib.Shared.Domain.Constants.Enums;
using Step.Lib.Shared.Domain.Constants.Extensions;

namespace Step.Lib.Shared.Domain.Constants;

/// <summary>
/// Статусы шага.
/// </summary>
public static class BcVersionCycleStatusType
{
    /// <summary>
    /// Коллекция всех констант.
    /// </summary>
    public static IReadOnlyCollection<BcVersionCycleStatusTypeItem> All
        => new List<BcVersionCycleStatusTypeItem>() { Waiting, InWork, Finished, OnApproval, Excluded };

    /// <summary>
    /// Получение константы из списка всех констант по ключу.
    /// </summary>
    /// <param name="key"> Ключ. </param>
    /// <returns> Константа. </returns>
    public static BcVersionCycleStatusTypeItem Get(short key) => All.Get(key);

    /// <summary>
    /// Получение константы из списка всех констант по ключу.
    /// </summary>
    /// <param name="key"> Ключ. </param>
    /// <returns> Константа. </returns>
    public static BcVersionCycleStatusTypeItem Get(BcCycleStatusType key) => All.Get((short)key);

    /// <summary>
    /// Получает статус по ключу
    /// </summary>
    /// <param name="key">Ключ - идентификатор константы</param>
    /// <returns>Статус:<br/>
    /// <see langword="true"/> - константа с таким идентификатором существует в справочнике;<br/>
    /// <see langword="false"/> - неизвестный идентификатор (нет такой константы в справочнике).
    /// </returns>
    public static bool Contains(short key) => All.FirstOrDefault(key) != null;

    /// <summary>
    /// Получает статус по ключу.
    /// </summary>
    /// <param name="key">Ключ - идентификатор константы из <see langword="enum"/> <see cref="BcCycleStatusType"/>.</param>
    /// <returns></returns>
    public static bool Contains(BcCycleStatusType key) => All.FirstOrDefault((short)key) != null;

    /// <summary>
    /// Статус шага.
    /// </summary>
    /// <param name="key">ID.</param>
    /// <param name="name"> Наименование. </param>
    public class BcVersionCycleStatusTypeItem(short key, string name) : ConstantItemBase(key, name) { }

    /// <summary>
    /// В ожидании.
    /// </summary>
    public static readonly BcVersionCycleStatusTypeItem Waiting = new((short)BcCycleStatusType.Waiting, "В ожидании");

    /// <summary>
    /// В работе.
    /// </summary>
    public static readonly BcVersionCycleStatusTypeItem InWork = new((short)BcCycleStatusType.InWork, "В работе");

    /// <summary>
    /// Завершен.
    /// </summary>
    public static readonly BcVersionCycleStatusTypeItem Finished = new((short)BcCycleStatusType.Finished, "Завершен");

    /// <summary>
    /// На согласовании.
    /// </summary>
    public static readonly BcVersionCycleStatusTypeItem OnApproval = new((short)BcCycleStatusType.OnApproval, "На согласовании");

    /// <summary>
    /// Отменен.
    /// </summary>
    public static readonly BcVersionCycleStatusTypeItem Excluded = new((short)BcCycleStatusType.Excluded, "Исключен");

    /// <summary>
    /// Следующий статус шага БК.
    /// </summary>
    /// <param name="currentStatusId"> Текущий идентификатор статуса. </param>
    /// <returns> Следующий статус. </returns>
    public static BcVersionCycleStatusTypeItem? NextStatusById(short? currentStatusId)
        => currentStatusId == null
            ? Waiting
            : currentStatusId == Waiting.Key
                ? InWork
                : currentStatusId == InWork.Key
                    ? Finished
                    : null;

    /// <summary>
    /// Следующий статус шага БК.
    /// </summary>
    /// <param name="currentStatus"> Текущий статус. </param>
    /// <returns> Следующий статус. </returns>
    public static BcVersionCycleStatusTypeItem? NextStatusById(BcVersionCycleStatusTypeItem? currentStatus)
        => currentStatus == null
            ? Waiting
            : currentStatus == Waiting
                ? InWork
                : currentStatus == InWork
                    ? Finished
                    : null;
}