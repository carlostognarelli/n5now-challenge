using Microsoft.AspNetCore.Mvc;
using n5now_challenge.Domain.Entities;
using n5now_challenge.Domain.Interfaces;
using n5now_challenge.Infraestructure.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace n5now_challenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        // GET: <PermissionController>
        [HttpGet(Name = "GetPermission")]
        public async Task<IEnumerable<Permission>> Get()
        {
            var permissions = await _permissionRepository.GetPermissions();

            return permissions.ToArray();
        }
    }
}
