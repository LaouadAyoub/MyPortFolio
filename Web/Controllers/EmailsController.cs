using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.ViewModels;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Web.Controllers
{
    [Authorize]
    public class EmailsController : Controller
    {
        private readonly IUnitOfWork<Email> _email;
        private readonly IHostingEnvironment _hosting;

        public EmailsController(IUnitOfWork<Email> email, IHostingEnvironment hosting)
        {
            _email = email;
            _hosting = hosting;
        }
        public IActionResult Index()
        {
            return View(_email.Entity.GetAll());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emailItem = _email.Entity.GetById(id);
            if (emailItem == null)
            {
                return NotFound();
            }

            return View(emailItem);
        }

       
     
    }
}