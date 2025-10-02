namespace Step.Lib.Common.Dtos.BcCycles;

/// <summary>
/// Исполнитель цикла БК (данных версии БК).
/// </summary>
/// <remarks>Включается в <see cref="BcCycleDto"/>.</remarks>
public class BcCycleImplementerDto
{
    /// <summary>
    /// ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ID пользователя (из Identity сервиса).
    /// </summary>
    public Guid UserId { get; set; }
}