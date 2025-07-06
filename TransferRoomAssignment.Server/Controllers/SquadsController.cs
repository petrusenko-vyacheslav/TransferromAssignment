using Microsoft.AspNetCore.Mvc;
using TransferRoomAssignment.Server.Models.Responses;
using TransferRoomAssignment.Server.Services;

namespace TransferRoomAssignment.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SquadsController : ControllerBase
    {
        private readonly ISquadService _squadsService;

        public SquadsController(ISquadService squadsService)
        {
            _squadsService = squadsService;
        }

        [HttpGet]
        public async Task<ActionResult<GetSquadResponse>> Get([FromQuery] string team)
        {
            try
            {
                return await _squadsService.GetSquad(team);
            }
            catch (Exception ex)
            {

                return BadRequest(new BadRequestResponse { Error = ex.Message });
            }
        }
    }
}
