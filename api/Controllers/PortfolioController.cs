using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Extensions;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/portfolio")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IStockRepository _stockRepo;
        private readonly IPortfolioRepository _portfolioRepo;

        public PortfolioController(UserManager<AppUser> userManager, IStockRepository stockRepo,
         IPortfolioRepository portfolioRepo)
        {
            _userManager = userManager;
            _stockRepo = stockRepo;
            _portfolioRepo = portfolioRepo;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserPortfolio()
        {
            // Get the username of the logged-in user
            var username = User.GetUsername();

            // Find the user in the database
            var appUser = await _userManager.FindByNameAsync(username);
            if (appUser == null)
            {
                return NotFound("User not found");
            }

            // Get the user's portfolio
            var userPortfolio = await _portfolioRepo.GetUserPortfolio(appUser);
            if (userPortfolio == null || userPortfolio.Count == 0)
            {
                return NotFound("No portfolio found for the user");
            }

            return Ok(userPortfolio);
        }
    }
}
