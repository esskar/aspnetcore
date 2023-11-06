namespace Microsoft.AspNetCore.Identity;

/// <summary>
/// Contains options for the <see cref="MapIdentityApi"/>.
/// </summary>
public class IdentityApiEndpointRouteOptions
{
    public bool SupportsRegister { get; set; } = true;

    public bool SupportsLogin { get; set; } = true;

    public bool SupportsRefresh { get; set; } = true;

    public bool SupportConfirmEmail { get; set; } = true;

    public bool SupportForgetPassword { get; set; } = true;

    public bool SupportResetPassword { get; set; } = true;

    public bool SupportsManage2FA { get; set; } = true;

    public bool SupportsManageInfo { get; set; } = true;
}