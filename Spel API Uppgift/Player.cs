namespace Spel_API_Uppgift
{
    public class Player
    {
        public int player_id { get; set; }
        public string player_name { get; set; } = string.Empty;
        public int level { get; set; }
        public int experience { get; set; }
        public int coins { get; set; }
        public int ranking { get; set; }
    }
}
