using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Controllers.Contracts;

public class RegistrationRequest
{
    [Required(ErrorMessage = "First Name is required")]
    [MinLength(1, ErrorMessage = "Needs to be more than 1 character")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "First Name is required")]
    [MinLength(1, ErrorMessage = "First Name needs to be more than 1 character")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email Field is required")]
    [MinLength(1, ErrorMessage = "Email needs to be more than 1 character")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password Field is required")]
    [MinLength(7, ErrorMessage = "Password needs to be more than 7 character")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm Password Field is required.")]
    [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
    public string ConfirmPassword { get; set; }
    public string? PhoneNumber { get; set; }
    public string? DefaultShippingAddress { get; set; }
    public string? BillingAddress { get; set; }

    public RegistrationRequest(
        string firstName,
        string lastName,
        string email,
        string password,
        string confirmPassword,
        string? phoneNumber,
        string? defaultShippingAddress,
        string? billingAddress
    )
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Password = password;
        DefaultShippingAddress = defaultShippingAddress;
        BillingAddress = billingAddress;
        ConfirmPassword = confirmPassword;
    }
}
