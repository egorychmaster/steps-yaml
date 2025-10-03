namespace Step.Lib.Common.Dtos.Users;

/// <summary>
/// Пользователь.
/// </summary>
public class UserDto
{
    /// <summary>
    /// Id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Числовое ID (из БД монолита).
    /// </summary>
    public long? IdInt { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Фамилия.
    /// </summary>
    public string Surname { get; set; } = null!;

    /// <summary>
    /// Отчество.
    /// </summary>
    public string Patronymic { get; set; } = null!;

    /// <summary>
    /// Полное имя (ФИО).
    /// </summary>
    public string FullName { get; set; } = null!;

    /// <summary>
    /// Email.
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Роли, назначенные на пользователя.
    /// </summary>
    public List<RoleCroppedDto> Roles { get; set; } = new();

    /// <summary>
    /// Типы шагов, на которые назначен пользователь.
    /// </summary>
    public List<UserBcVersionCycleTypeDto> BcVersionCycleTypes { get; set; } = new();

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }
}