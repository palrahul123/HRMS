using Core.Application.DTOs.RoleDtos;
using Core.Application.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _service;

        public RoleController(IRoleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var role = await _service.GetByIdAsync(id);
            return role == null ? NotFound() : Ok(role);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRoleDto dto)
        {
            var id = await _service.CreateAsync(dto);
            return Ok(new { Id = id, Message = "Role created" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateRoleDto dto)
        {
            dto.Id = id;
            await _service.UpdateAsync(dto);
            return Ok("Role updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Role deleted");
        }
    }
}
