namespace ArchiAndMartyBakery.Web.Areas.Administration.Controllers
{
    using ArchiAndMartyBakery.Common;
    using ArchiAndMartyBakery.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
