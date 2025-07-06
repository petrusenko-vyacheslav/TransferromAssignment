using TransferRoomAssignment.Server.Models.DTOs;

namespace TransferRoomAssignment.Server.Models.Responses
{
    public class GetSquadResponse
    {
        public string Team { get; set; }
        public PlayerDto[] Players { get; set; }
    }
}
