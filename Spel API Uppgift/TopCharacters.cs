using System.Security.Cryptography.X509Certificates;

namespace Spel_API_Uppgift
{
    public class TopCharacters
    {
        public string player_name { get; set; } = string.Empty;
        public int ranking { get; set; }
        public List<Character> top_characters { get; set; } = new List<Character>();
    }
}
