using TransferRoomAssignment.Server.Models.Entities;

namespace TransferRoomAssignment.Server.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private Team[] teams = new Team[20]
        {
            new Team { Id = 40, Name = "Liverpool", Nickname = "The Reds"},
            new Team { Id = 42, Name = "Arsenal", Nickname = "The Gunners"},
            new Team { Id = 50, Name = "Manchester City", Nickname = "The Citizens"},
            new Team { Id = 49, Name = "Chelsea", Nickname = "The Blues"},
            new Team { Id = 34, Name = "Newcastle", Nickname = "The Magpies"},
            new Team { Id = 66, Name = "Aston Villa", Nickname = "The Villans"},
            new Team { Id = 65, Name = "Nottingham Forest", Nickname = "The Tricky Trees"},
            new Team { Id = 51, Name = "Brighton", Nickname = "The Seagulls"},
            new Team { Id = 35, Name = "Bournemouth", Nickname = "The Cherries"},
            new Team { Id = 55, Name = "Brentford", Nickname = "The Bees"},
            new Team { Id = 36, Name = "Fulham", Nickname = "The Cottagers"},
            new Team { Id = 52, Name = "Crystal Palace", Nickname = "The Eagles"},
            new Team { Id = 45, Name = "Everton", Nickname = "The Toffees"},
            new Team { Id = 48, Name = "West Ham", Nickname = "The Hammers"},
            new Team { Id = 33, Name = "Manchester United", Nickname = "The Red Devils"},
            new Team { Id = 39, Name = "Wolverhampton Wanderers", Nickname = "Wolves"},
            new Team { Id = 47, Name = "Tottenham", Nickname = "The Spurs"},
            new Team { Id = 46, Name = "Leicester City", Nickname = "The Foxes"},
            new Team { Id = 57, Name = "Ipswich", Nickname = "The Tractor Boys"},
            new Team { Id = 41, Name = "Southampton", Nickname = "The Saints"}
        };

        public Task<Team?> Get(string name)
        {
            return Task.FromResult(teams.FirstOrDefault(t => t.Name == name || t.Nickname == name));
        }
    }
}
