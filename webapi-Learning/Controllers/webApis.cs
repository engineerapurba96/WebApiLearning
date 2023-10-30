using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi_Learning.Data;
using webapi_Learning.Models;

namespace webapi_Learning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class webApis : ControllerBase
    {
        private readonly apiDbcs _dbContext;

        public webApis(apiDbcs dbContext) {
            _dbContext = dbContext;
            }
        [HttpGet]
        [Route("oops")]
public async Task<IEnumerable<webapi>> GetAll()
        {
            return await _dbContext.webapis.ToListAsync();
        }

        [HttpPost]
        [Route("AddDApi")]
        public async Task<ActionResult<webapi>> AddDisease(webapi disease)
        {
            try
            {
                _dbContext.webapis.Add(disease);
                await _dbContext.SaveChangesAsync();
                return Ok(disease); // Return 200 OK on success
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error"); // Handle exceptions and return a 500 response if needed
            }
        }
    }
}
