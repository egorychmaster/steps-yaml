namespace Step.Lib.Common.Dtos.Users;

/// <summary>
/// Dto для Services.Common.Identity.Domain.Features.IdentityModule.UserBcVersionCycleType
/// </summary>
public class UserBcVersionCycleTypeDto
{
    /// <summary>
    /// Константа типа шага категории процесса.
    /// </summary>
    public string BcVersionCycleType { get; set; } = null!;

    /// <summary>
    /// Константа Shared.Domain.Constants.ProcessCategoryTypeConstants.
    /// </summary>
    public int ProcessCategoryType { get; set; }
}