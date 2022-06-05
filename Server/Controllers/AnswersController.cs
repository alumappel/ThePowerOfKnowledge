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
using TriangleProject_AlumaAppel_AnastasiaZolotoohin.Server.Controllers;

namespace ThePowerOfKnowledge.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly FileStorage _fileStorage;

        public AnswersController(DataContext context, FileStorage fileStorage)
        {
            _context = context;
            _fileStorage = fileStorage;
        }


        //עדכון רשומה
        [HttpPost("Update/{userId}/{gameId}")]
        public async Task<IActionResult> UpdateGame(int userId, int gameId, Answer TheAnswer)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {
                    if (gameId == TheAnswer.GameID)
                    {
                        Answer AnswerFromDb = await _context.Answers.FirstOrDefaultAsync(a => a.ID == TheAnswer.ID);

                        if (AnswerFromDb != null)
                        {
                            AnswerFromDb.Content = TheAnswer.Content;
                            AnswerFromDb.CorrectAnswer = TheAnswer.CorrectAnswer;
                            AnswerFromDb.HaveImge = TheAnswer.HaveImge;                            


                            await _context.SaveChangesAsync();
                            Game gameToReturn = await _context.Games.Include(a => a.GameAnswers).FirstOrDefaultAsync(g => g.ID == gameId);
                            if (gameToReturn != null)
                            {
                                return Ok(gameToReturn);
                            }
                            return BadRequest("Game not found");

                        }
                        else
                        {
                            return BadRequest("Answer not found");
                        }
                    }
                    return BadRequest("GameId Not Match");
                }
                return BadRequest("User not login");
            }
            return BadRequest("EmptySession");
        }



        //יצירת מסיח חדש
        [HttpPost("NewAnswer/{userId}/{gameId}")]
        public async Task<IActionResult> CreatAnswer(int userId, int gameId, Answer TheAnswer)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {
                    if (gameId == TheAnswer.GameID)
                    {
                        Answer AnswerFromDb = await _context.Answers.FirstOrDefaultAsync(a => a.ID == TheAnswer.ID);

                        if (TheAnswer != null)
                        {
                            _context.Answers.Add(TheAnswer);
                            await _context.SaveChangesAsync();
                            Game gameToReturn = await _context.Games.Include(a => a.GameAnswers).FirstOrDefaultAsync(g => g.ID == gameId);
                            if (gameToReturn != null)
                            {
                                return Ok(gameToReturn);
                            }
                            return BadRequest("Game not found");                            
                        }
                        else
                        {
                            return BadRequest("No game sent");
                        }
                    }
                    return BadRequest("GameId Not Match");
                }
                return BadRequest("User not login");
            }
            return BadRequest("EmptySession");
        }




        //מחיקת רשומה
        [HttpDelete("{userId}/{gameId}/{AnswerGameId}/{answerId}")]
        public async Task<IActionResult> DeleteGame(int userId, int gameId, int AnswerGameId, int answerId)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {
                    if (gameId == AnswerGameId)
                    {
                        Answer DeleteAnswer = await _context.Answers.FirstOrDefaultAsync(a => a.ID == answerId);
                        if (DeleteAnswer != null)
                        {
                            _context.Answers.Remove(DeleteAnswer);
                            await _context.SaveChangesAsync();
                            Game gameToReturn = await _context.Games.Include(g => g.GameAnswers).FirstOrDefaultAsync(g => g.ID == gameId);
                            if (gameToReturn != null)
                            {
                                return Ok(gameToReturn);
                            }
                            return BadRequest("Game not found");
                        }
                        return BadRequest("Answer not found");
                    }
                    return BadRequest("Game Id not Mach");
                }
                return BadRequest("User not login");
            }
            return BadRequest("EmptySession");
        }























    }
}
