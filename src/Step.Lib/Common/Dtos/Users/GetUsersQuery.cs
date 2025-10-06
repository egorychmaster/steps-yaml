using Step.Lib.Common.Dtos.Filter.Sorting;
using Step.Lib.Common.Dtos.Users.Enums;
using System.Linq.Expressions;

namespace Step.Lib.Common.Dtos.Users;

public class GetUsersQuery : BaseSortFilter<UserDto, UserSortPropertyName>
{
    /// <summary>
    /// Идентификаторы.
    /// </summary>
    public Guid[]? Ids { get; init; }

    /// <summary>
    /// Email.
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// Общий фильтр поиска по строке.
    /// <br/>Поиск осуществляется по следующим полям: фамилия, имя, отчество, email.
    /// <br/>При поиске по нескольким словам(например "Иванов Иван") каждое слово ищется отдельно во всех полях.
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Фильтр по ролям, к которым относится пользователь.
    /// <br/>Возвращает пользователей, которым присвоена хотя бы одна роль по ключу из указанных.
    /// </summary>
    public string[]? RoleKeys { get; init; }

    /// <summary>
    /// **Ключи сортировки:**
    /// - Name
    /// - Surname
    /// - CreatedDate
    /// 
    /// **Пример использования:** `sortOptions=Name.asc&amp;sortOptions=Surname.desc&amp;sortOptions=CreatedDate`
    /// <br/>Приоритет для `Name` - 1, для `Surname` - 2, для `CreatedDate` - 3. 
    /// <br/>Сортировки: `asc` - восходящая, `desc` - нисходящая.
    /// <br/>Если ни `desc` ни `asc` не предоставлен - сортировка производится как `asc` (как например для `{CreatedDate}` в примере).
    /// <br/>Если `sortOptions` не переданы - по умолчанию действует сортировка по `{CreatedDate}`.
    /// </summary>
    public override string[]? SortOptions { get; init; }

    /// <summary>
    /// Поддерживаемые сортировки.
    /// </summary>
    protected override Dictionary<UserSortPropertyName, Expression<Func<UserDto, object>>> SupportedSortings =>
        new()
        {
            [UserSortPropertyName.Name] = x => x.Name,
            [UserSortPropertyName.Surname] = x => x.Surname,
            [UserSortPropertyName.DateCreated] = x => x.DateCreated
        };
}
