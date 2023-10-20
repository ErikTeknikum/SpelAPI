namespace Spel_API_Uppgift
{
    public class latest_game
    {
        public int game_id { get; set; }
        public DateTime timestamp { get; set; }
        public int score { get; set; }
        public int duration_minutes { get; set; }
        public string player_name { get; set; } = string.Empty;
        public int ranking { get; set; }
    }
}
