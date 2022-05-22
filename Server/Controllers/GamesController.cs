using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePowerOfKnowledge.Server.Data;
using ThePowerOfKnowledge.Shared.Entities;

namespace TriangleProject_AlumaAppel_AnastasiaZolotoohin.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly DataContext _context;

        public GamesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("byUserId/{userId}")]
        public async Task<IActionResult> GetAllGames(int userId)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {
                    User userToReturn = await _context.Users.Include(u => u.UserGames).ThenInclude(g => g.GameAnswers).FirstOrDefaultAsync(u => u.ID == userId);
                    if (userToReturn != null)
                    {
                        return Ok(userToReturn);
                    }
                    return BadRequest("User not found");
                }
                return BadRequest("User not login");
            }
            return BadRequest("EmptySession");
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














    }
}

