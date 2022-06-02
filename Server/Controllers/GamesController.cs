using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePowerOfKnowledge.Server.Data;
using ThePowerOfKnowledge.Server.Helpers;
using ThePowerOfKnowledge.Shared.Entities;

namespace TriangleProject_AlumaAppel_AnastasiaZolotoohin.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        
        private readonly DataContext _context;
        private readonly FileStorage _fileStorage;

        public GamesController(DataContext contex, FileStorage fileStorage)
        {

            _context = contex;
            _fileStorage = fileStorage;
        }
     


        [HttpGet("byCode/{gameCode}")]
        public async Task<IActionResult> GetGameByCode(int gamePin)
        {
            ///Game gameToReturn = await _context.Games.FirstOrDefaultAsync(g => g.GamePin == gamePin);
            /// שיטה כשיש עוד טבלאות
            Game gameToReturn = await _context.Games.Include(g => g.GameAnswers).FirstOrDefaultAsync(g => g.GamePin == gamePin);

            if (gameToReturn != null)
            {
                if (gameToReturn.IsPublish == true)
                {
                    return Ok(gameToReturn);
                }
                return BadRequest("game not publish");
            }
            return BadRequest("game not found");

        }


        //עם שגיאה בבדיקות שולח משחק ולא משתמש
        [HttpGet("byGameId/{gameId}")]
        public async Task<IActionResult> GetGameAndAllA(int gameId)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == gameId)
                {
                    Game gameToReturn = await _context.Games.Include(a => a.GameAnswers).FirstOrDefaultAsync(g => g.ID == gameId);
                    if (gameToReturn != null)
                    {
                        return Ok(gameToReturn);
                    }
                    return BadRequest("Game not found");
                }
                return BadRequest("User not login");
            }
            return BadRequest("EmptySession");
        }



        //מחיקת רשומה
        [HttpDelete("{userId}/{gameId}")]
        public async Task<IActionResult> DeleteGame(int userId , int gameId)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
                if (string.IsNullOrEmpty(sessionContent) == false)
                {
                    int sessionId = Convert.ToInt32(sessionContent);
                    if (sessionId == userId)
                 {
                    Game DeleteGame = await _context.Games.FirstOrDefaultAsync(g => g.ID == gameId);
                    if (DeleteGame != null)
                    {
                        _context.Games.Remove(DeleteGame);
                        await _context.SaveChangesAsync();
                        User userToReturn = await _context.Users.Include(u => u.UserGames).ThenInclude(g => g.GameAnswers).FirstOrDefaultAsync(u => u.ID == userId);
					if (userToReturn != null)
					{
						return Ok(userToReturn);
					}
                        return BadRequest("User not found");
                    }
                    return BadRequest("Game not found");
                }
                    return BadRequest("User not login");
                }
                return BadRequest("EmptySession");
            }
























    















        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile([FromBody] string imageBase64)
        {
            byte[] picture = Convert.FromBase64String(imageBase64);
            string url = await _fileStorage.SaveFile(picture, "jpg", "uploadedFiles");
            return Ok(url);
        }

        [HttpPost("deleteImages")]
        public async Task<IActionResult> DeleteImages([FromBody] List<string> images)
        {
            foreach (string img in images)
            {
                await _fileStorage.DeleteFile(img, "uploadedFiles");
            }
            return Ok("deleted");
        }












    }
}

