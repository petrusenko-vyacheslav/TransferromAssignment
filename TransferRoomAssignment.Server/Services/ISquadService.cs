using TransferRoomAssignment.Server.Models.Responses;

namespace TransferRoomAssignment.Server.Services
{
    public interface ISquadService
    {
        Task<GetSquadResponse> GetSquad(string team);
    }
}
