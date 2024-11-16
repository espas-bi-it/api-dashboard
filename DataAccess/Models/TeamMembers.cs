namespace DataAccess.Models
{
    public class TeamMembers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamRole { get; set; }
        public string Website { get; set; }
        public int SiteViews { get; set; }
        public DateTime CreatedAt { get; set; }

        // Konstruktor, der das Erstellungsdatum auf das aktuelle Datum setzt
        public TeamMembers()
        {
            CreatedAt = DateTime.Now.Date; // Nur das Datum ohne Uhrzeit
        }
    }
}

