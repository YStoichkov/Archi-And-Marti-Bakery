namespace ArchiAndMartyBakery.Services.Data
{
    using Microsoft.AspNetCore.Http;

    public interface IUnitOfWork
    {
        void UploadImage(IFormFile file);
    }
}
