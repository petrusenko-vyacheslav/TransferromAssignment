using System.Text.Json;
using TransferRoomAssignment.Server.Models.DTOs;
using TransferRoomAssignment.Server.Models.Responses;
using TransferRoomAssignment.Server.Repositories;

namespace TransferRoomAssignment.Server.Services
{
    public class SquadService : ISquadService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly HttpClient _httpClient;

        public SquadService(ITeamRepository teamRepository, HttpClient httpClient)
        {
            _teamRepository = teamRepository;
            _httpClient = httpClient;
        }

        public async Task<GetSquadResponse> GetSquad(string teamName)
        {
            var team = await _teamRepository.Get(teamName);
            if (team == null)
            {
                throw new Exception($"Team {teamName} does not exist or is not supported");
            }

            var getSquadhttpResponse = await _httpClient.GetAsync($"players/squads?team={team.Id}");
            var getSquadhttpResponseString = await getSquadhttpResponse.Content.ReadAsStringAsync();
            var apiSportsSquad = JsonSerializer.Deserialize<ApiSportsSquadDto>(getSquadhttpResponseString);

            return new GetSquadResponse
            {
                Team = team.Name,
                Players = apiSportsSquad.Response.First().Players.Select(p => new PlayerDto { Age = p.Age, Name = p.Name, Position = p.Position, ProfilePictureUrl = p.Photo }).ToArray(),
            };
        }
    }
}
