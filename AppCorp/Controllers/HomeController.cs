using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppCorp.Models;
using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AppCorp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repo _repo;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public HomeController(Repo repo,
            SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _repo = repo;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login loginModel)
        {
            var result =
                await _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("SendMessages", new { pageNumber = 1 });

            }
            return BadRequest("Invalid username or password");
        }

        public async Task<IActionResult> SendMessages(int pageNumber)
        {
            var pagedData = await _repo.GetPagedProfiles(pageNumber, 10);
            var model = pagedData.Select(d => new SendMessages()
            { UserId = d.Id, UserName = d.UserName, MobileNumber = d.PhoneNumber }).ToList();
            ViewBag.PageNumber = pageNumber;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SendMessages(List<SendMessages> messageses, int pageNumber)
        {
            var messagesModel = messageses.Select(m => new Message() { ProfileId = m.UserId, MessageSent = m.Message })
                .ToList();
            await _repo.LogMessages(messagesModel);
            return RedirectToAction("SendMessages", new { pageNumber = pageNumber + 1 });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
