using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Spel_API_Uppgift.Controllers
{        
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController: Controller
    {
        [HttpGet("{player_id}")]
        public ActionResult<Player> GetPlayerID(int player_id)
        {
            Player player = new Player()
            {
                player_id = player_id,
                player_name = "Sven",
                level = 200,
                experience = 1500,
                coins = 100,
                ranking = 150
            };
            return Ok(player);
        }

        [HttpGet("{player_id}/latest_game")]
        public ActionResult<List<latest_game>> GetLatestGame()
        {
            latest_game latestGame = new latest_game()
            {
                game_id = 10,
                score = 79012,
                player_name = "Sven",
                ranking = 150,
                duration_minutes = 76,
                timestamp = new DateTime(2023, 10, 20, 5, 10, 20)
                
            };
            return Ok(latestGame);
        }

        [HttpGet("{player_id}/top_characters")]
        public ActionResult<List<TopCharacters>> GetTop_Characters()
        {
            TopCharacters topCharacters = new TopCharacters()
            {
                player_name = "Agata",
                ranking = 7,
            };
            topCharacters.top_characters.Add(new Character() { character_id = 1, character_name = "Agneta", playtime_hours = 76});
            topCharacters.top_characters.Add(new Character() { character_id = 2, character_name = "Stefan", playtime_hours = 1001 });
            topCharacters.top_characters.Add(new Character() { character_id = 3, character_name = "Johanna", playtime_hours = 56 });
            topCharacters.top_characters.Add(new Character() { character_id = 4, character_name = "Fredrik", playtime_hours = 21 });
            topCharacters.top_characters.Add(new Character() { character_id = 5, character_name = "Jens", playtime_hours = 341 });
            return Ok(topCharacters);
        }

        [HttpDelete("{player_id}")]
        public ActionResult deletePlayer(string message)
        {
            message = "Player deleted successfully";
            return Ok(message);
        }
    }
}