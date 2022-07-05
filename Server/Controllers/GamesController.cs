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


        //שליפה עם קוד משחק עמור האנימייט
        [HttpGet("byCode/{gameCode}")]
        public async Task<IActionResult> GetGameByCode(int gameCode)
        {
            //Game gameToReturn = await _context.Games.FirstOrDefaultAsync(g => g.GamePin == gameCode);
            /// שיטה כשיש עוד טבלאות
            Game gameToReturn = await _context.Games.Include(g => g.GameAnswers).FirstOrDefaultAsync(g => g.GamePin == gameCode);           
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


        //שליפה לפי ID משחק בשביל עמוד עריכה
        [HttpGet("byGameId/{userId}/{gameId}")]
        public async Task<IActionResult> GetGameAndAllAnswers(int userId, int gameId)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
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
        public async Task<IActionResult> DeleteGame(int userId, int gameId)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {
                    Game DeleteGame = await _context.Games.Include(g => g.GameAnswers).FirstOrDefaultAsync(g => g.ID == gameId);
                    if (DeleteGame != null)
                    {
                        //מחיקת תמונה מנהחייה
                        if (DeleteGame.GameQuestionImge != null)
                        {
                            string ImgToDelete = DeleteGame.GameQuestionImge;
                            await _fileStorage.DeleteFile(ImgToDelete, "uploadedFiles");
                        }

                        //מחיקת תמונה ממסיחים
                        //ומחיקת מסיח
                        foreach(Answer a in DeleteGame.GameAnswers)
                        {
                            if (a.HaveImge == true)
                            {
                                string ImgToDelete = a.Content;
                                await _fileStorage.DeleteFile(ImgToDelete, "uploadedFiles");
                            }

                            _context.Answers.Remove(a);
                        }

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









        //עדכון רשומה
        [HttpPost("Update/{userId}")]
        public async Task<IActionResult> UpdateGame(int userId, Game TheGame)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {
                    Game GameFromDb = await _context.Games.FirstOrDefaultAsync(g => g.ID == TheGame.ID);

                    if (GameFromDb != null)
                    {
                        GameFromDb.GamePin = TheGame.GamePin;
                        GameFromDb.GameTopic = TheGame.GameTopic;
                        GameFromDb.GameQuestionText = TheGame.GameQuestionText;
                        GameFromDb.GameQuestionImge = TheGame.GameQuestionImge;
                        GameFromDb.IsPublish = TheGame.IsPublish;

                        await _context.SaveChangesAsync();
                        Game gameToReturn = await _context.Games.Include(a => a.GameAnswers).FirstOrDefaultAsync(g => g.ID == TheGame.ID);
                        if (gameToReturn != null)
                        {
                            return Ok(gameToReturn);
                        }
                    }
                    else
                    {
                        return BadRequest("Game not found");
                    }
                }
                return BadRequest("User not login");
            }
            return BadRequest("EmptySession");
        }






        //יצירת משחק חדש
        [HttpPost("NewGame/{userId}")]

        public async Task<IActionResult> CreatGame(int userId, Game NewGame)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {

                    if (NewGame != null)
                    {
                        _context.Games.Add(NewGame);
                        await _context.SaveChangesAsync();
                        return Ok(NewGame.ID);
                    }
                    else
                    {
                        return BadRequest("No game sent");
                    }
                }
                return BadRequest("User not login");
            }
            return BadRequest("EmptySession");
        }


        //העלאת תמונה
        [HttpPost("upload/{userId}")]
        public async Task<IActionResult> UploadFile([FromBody] string imageBase64, int userId)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {
                    byte[] picture = Convert.FromBase64String(imageBase64);
                    string url = await _fileStorage.SaveFile(picture, "jpg", "uploadedFiles");
                    return Ok(url);
                }
                return BadRequest("User not login");
            } 
            return BadRequest("EmptySession");
        }






        //מחיקת תמונה
        [HttpPost("deleteImages/{userId}")]
        public async Task<IActionResult> DeleteImages([FromBody] List<string> images, int userId)
        {
            string sessionContent = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(sessionContent) == false)
            {
                int sessionId = Convert.ToInt32(sessionContent);
                if (sessionId == userId)
                {
                    foreach (string img in images)
                    {
                        await _fileStorage.DeleteFile(img, "uploadedFiles");
                    }
                    return Ok("deleted");
                }
                return BadRequest("User not login");
            }
            return BadRequest("EmptySession");
        }












    }
}

