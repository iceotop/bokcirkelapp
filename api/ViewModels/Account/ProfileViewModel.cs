namespace api.ViewModels.Account;

public class ProfileViewModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<BookBaseViewModel>? Books { get; set; }
}