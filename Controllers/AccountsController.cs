using BankingApp.Context;
using BankingApp.Models;
using BankingApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Controllers
{
    public class AccountsController : Controller
    {
        private SQLiteDBContext _context;
        private IAccountService _accountService;

        public AccountsController(SQLiteDBContext context, IAccountService service)
        {
            _context = context;
            _accountService = service;
        }

        // GET: Accounts
        public ActionResult Index()
        {
            return View(_accountService.GetAccounts());
        }

        // GET: Accounts/Details/5
        public ActionResult Details(int id)
        {
            var model = _context.Accounts.Find(id);
            return View(model);
        }

        // GET: Accounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accounts/CreateAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Accounts model)
        {
            if (ModelState.IsValid)
            {
                model.ACTIVE = true;
                _context.Accounts.Add(model);
                _context.SaveChanges();
            }
            else
            {
                return View();
            }
            return RedirectToAction("Index", "Accounts");
        }

        // GET: Accounts/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _context.Accounts.Find(id);
            return View(model);
        }

        // POST: Accounts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Accounts model)
        {
            if (ModelState.IsValid)
            {
                _context.Accounts.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: Accounts/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _context.Accounts.Find(id);
            return View(model);
        }

        // POST: Accounts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Accounts model)
        {
            try
            {
                var modeltodelete = _context.Accounts.Find(id);
                _context.Accounts.Remove(modeltodelete);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}