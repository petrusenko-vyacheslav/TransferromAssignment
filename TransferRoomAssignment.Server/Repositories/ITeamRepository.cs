using TransferRoomAssignment.Server.Models.Entities;

namespace TransferRoomAssignment.Server.Repositories
{
    public interface ITeamRepository
    {
        Task<Team?> Get(string name);
    }
}
