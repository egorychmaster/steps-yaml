namespace Step.Lib.Common.Dtos.Users;

/// <summary>
/// Роль - упрощенное DTO.
/// </summary>
public class RoleCroppedDto
{
    /// <summary>
    /// ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Ключ.
    /// </summary>
    public string Key { get; set; } = null!;
}