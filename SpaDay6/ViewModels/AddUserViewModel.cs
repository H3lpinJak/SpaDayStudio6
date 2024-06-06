using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModels;

public class AddUserViewModel
{
    [Required(ErrorMessage = "Username is required")]

    [StringLength (15, MinimumLength=5, ErrorMessage ="Username must be between 5 nd 15 characters")]
    public string? Username { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [StringLength (20, MinimumLength =6, ErrorMessage = "Password must be between 6 and 20 characters")]
    public string? Password { get; set; }
    [Required(ErrorMessage = "Verify Password is required")]
    [StringLength (20, MinimumLength =6, ErrorMessage = "Password must be between 6 and 20 characters")]
    public string? VerifyPassword { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
}