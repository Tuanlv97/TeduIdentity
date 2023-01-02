using Microsoft.AspNetCore.Mvc;
using System.Net;
using TeduMicroservices.IDP.Infrastructure.Repositories;
using TeduMicroservices.IDP.Infrastructure.ViewModels;

namespace TeduMicroservices.IDP.Presentation.Controllers;


[ApiController]
[Route("api/[controller]/roles/{roleId}")]
public class PermissionsController : ControllerBase
{
    private readonly IRepositoryManager _repository;

    public PermissionsController(IRepositoryManager repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<PermissionViewModel>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetPermissions(string roleId)
    {
        var result = await _repository.Permission.GetPermissionsByRole(roleId);
        return Ok(result);
    }
}
