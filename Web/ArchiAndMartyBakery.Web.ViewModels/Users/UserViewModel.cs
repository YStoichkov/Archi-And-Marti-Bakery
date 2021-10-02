namespace ArchiAndMartyBakery.Web.ViewModels.Users
{
    using ArchiAndMartyBakery.Data.Models;
    using ArchiAndMartyBakery.Services.Mapping;

    public class UserViewModel : IMapFrom<ApplicationUser>
    {
        public string Username { get; set; }

        public string ImagePath { get; set; }
    }
}
