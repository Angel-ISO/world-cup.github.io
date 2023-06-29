using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaWorldCup_app.Entities
{
    public class Teams
    {
        private string ? idTeam;
        private string ? nameTeam;
        private List<Player>  players = new List<Player>();
        private List<TeamTechnical>  technicals = new List<TeamTechnical>();
        private List<TeamMedical>  medicals = new List<TeamMedical>();
        private DataTable ? tableTeam;

        public string? IdTeam { get => idTeam; set => idTeam = value; }
        public string? NameTeam { get => nameTeam; set => nameTeam = value; }
        public List<Player> Players { get => players; set => players = value; }
        public List<TeamTechnical> Technicals { get => technicals; set => technicals = value; }
        public List<TeamMedical>  Medicals { get => medicals; set => medicals = value; }
        public DataTable? DataTable { get => tableTeam; set => tableTeam = value; }

    }
}