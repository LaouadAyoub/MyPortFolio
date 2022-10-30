using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _portfolio;
        private readonly IUnitOfWork<Email> _email;

        public HomeController(IUnitOfWork<Owner> owner, IUnitOfWork<PortfolioItem> portfolio, IUnitOfWork<Email> email)
        {
            _owner = owner;
            _portfolio = portfolio;
            _email = email;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _portfolio.Entity.GetAll().ToList()
            };
            return View(homeViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string name, string email, string phone, string message)
        {
            var emails = new Email
            {
                Name = name,
                Emaill = email,
                Number = phone,
                Message = message
            };
            _email.Entity.Insert(emails);
            _email.save();
            try
            {
                SendMail(name,email,message);
            }
            catch (Exception)
            {

            }
            TempData["Message"] = "Email Send Successfully.";
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _portfolio.Entity.GetAll().ToList()
            };
            return View(homeViewModel);
        }
        public void SendMail(string name,string email,string messagge)
        {
            MailMessage mc = new MailMessage("Laouad98@outlook.fr", "Laouad98@outlook.fr");
            mc.Subject = "Inquiry";
            mc.Body = name + "\n" + email + "\n" + messagge;
            mc.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
            smtp.Timeout = 1000000;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            NetworkCredential nc = new NetworkCredential("Laouad98@outlook.fr", "yourpassword");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = nc;
            smtp.Send(mc);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
