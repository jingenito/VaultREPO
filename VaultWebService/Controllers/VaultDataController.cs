using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VaultWebService.Services;

namespace VaultWebService.Controllers
{
    [Route("api/VaultData")]
    [ApiController]
    [Authorize]
    public class VaultDataController : ControllerBase
    {
        private IVaultDataService _vaultDataService;

        public VaultDataController(IVaultDataService vaultDataService)
        {
            _vaultDataService = vaultDataService;
        }

        [HttpGet]
        public async Task<IActionResult> GetVaultDataObjects()
        {
            var dObjects = await _vaultDataService.GetVaultDataObjects();
            return Ok(dObjects);
        }

        // GET: api/VaultData/{RecordNumber}
        [HttpGet("{RecordNumber}", Name = "GetVaultDataObject")]
        public async Task<IActionResult> GetVaultDataObject(int RecordNumber)
        {
            var dobj = await _vaultDataService.GetVaultDataObject(RecordNumber);

            if (dobj == null)
                return BadRequest(new { message = "RecordNumber not found" });

            return Ok(dobj);
        }
    }
}
