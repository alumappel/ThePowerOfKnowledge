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
	public class UsersController : ControllerBase
	{
		private readonly DataContext _context;

		public UsersController(DataContext context)
		{
			_context = context;
		}


		[HttpGet("{mail}")]
		public async Task<IActionResult> LoginUser(string mail)
		{
			string SessionID = HttpContext.Session.GetString("UserId");

			User userToReturn = await _context.Users.FirstOrDefaultAsync(u => u.Email == mail.ToLower());
			if (userToReturn != null)
			{
				HttpContext.Session.SetString("UserId", userToReturn.ID.ToString());
				return Ok(userToReturn.ID);
			}
			return BadRequest("User not found");

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

//שליפה עמור התפריט העליון
		[HttpGet("EmailbyUserId/{userId}")]
		public async Task<IActionResult> GetUserEmail(int userId)
		{
			string sessionContent = HttpContext.Session.GetString("UserId");
			if (string.IsNullOrEmpty(sessionContent) == false)
			{
				int sessionId = Convert.ToInt32(sessionContent);
				if (sessionId == userId)
				{
					User userToReturn = await _context.Users.FirstOrDefaultAsync(u => u.ID == userId);
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






	}
}