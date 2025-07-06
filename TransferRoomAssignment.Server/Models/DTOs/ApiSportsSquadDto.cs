using System.Text.Json.Serialization;

namespace TransferRoomAssignment.Server.Models.DTOs
{
    public class ApiSportsSquadDto
    {
        [JsonPropertyName("response")]
        public ApiSportsSquadResponseDto[] Response { get; set; }
    }

    public class ApiSportsSquadResponseDto
    {
        [JsonPropertyName("players")]
        public ApiSportsPlayerDto[] Players { get; set; }
    }

    public class ApiSportsPlayerDto
    {
        [JsonPropertyName("age")]
        public int Age { get; set; }
        [JsonPropertyName("photo")]
        public string Photo { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("position")]
        public string Position { get; set; }
    }
}
