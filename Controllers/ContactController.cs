using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestFinal.Models;
using TestFinal.Models.Repositores;
using TestFinal.ViewModels;

namespace TestFinal.Controllers
{
    public class ContactController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        private readonly IContactService contactService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        public UserManager<ApplicationUser> UserManager { get; }

        public ContactController(IWebHostEnvironment _hostingEnvironment, IContactService _contactService,
            RoleManager<IdentityRole> _roleManager,
               UserManager<ApplicationUser> _userManager)
        {
            hostingEnvironment = _hostingEnvironment;
            contactService = _contactService;
            roleManager = _roleManager;
            userManager = _userManager;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult ContactList()
        {
            var contact = contactService.ListAllContact();
            return View("ListContact", contact);
        }

        [HttpGet]
        [Authorize(Roles = "User,Admin")]
        public IActionResult CreateContact()
        {
            return View("CreateContact");
        }

        [HttpPost]
        [Authorize(Roles = "User,Admin")]
        public async Task<IActionResult> CreateContact(CreateContactViewModel model)
        {
            if (ModelState.IsValid)
            {

                Contact contact = new Contact
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message

                };

                await contactService.AddContactAsync(contact);

                return RedirectToAction("Index", "home");
            }

            return View("CreateContact", model);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await contactService.GetContactByIdAsync(id);

            await contactService.DeleteContactAsync(contact);

            return RedirectToAction("ContactList", "contact");
        }
    }
}
