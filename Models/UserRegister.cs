using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class UserRegisterViewModel
{
    [Required(ErrorMessage = "Tên đăng nhập bắt buộc nhập")]
    [MinLength(3, ErrorMessage = "Tên đăng nhập phải ít nhất 3 ký tự")]
    [MaxLength(20, ErrorMessage = "Tên đăng nhập không quá 20 ký tự")]
    public string UserName { get; set; } = "";

    [Required(ErrorMessage = "Email bắt buộc nhập")]
    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Mật khẩu bắt buộc nhập")]
    [MinLength(6, ErrorMessage = "Mật khẩu phải ít nhất 6 ký tự")]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", 
        ErrorMessage = "Mật khẩu phải có ít nhất 1 chữ hoa, 1 chữ thường và 1 số")]
    public string Password { get; set; } = "";
    public bool Gender { get; set; } = false;

    [Required(ErrorMessage = "Vui lòng chọn quốc gia")]
    public string City { get; set; } = "";
    public List<string> Hobbies { get; set; } = new List<string>();
}
