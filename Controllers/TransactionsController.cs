using BankingApp.Context;
using BankingApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Controllers
{
    public class TransactionsController : Controller
    {
        private ITransactionService _transactionService;
        private SQLiteDBContext _context;

        public TransactionsController(SQLiteDBContext context, ITransactionService transactionservice)
        {
            _context = context;
            _transactionService = transactionservice;
        }

        // GET: TransactionsController
        public ActionResult Index()
        {
            return View(_transactionService.GetTransactions());
        }

        // GET: Accounts/Details/5
        public ActionResult Details(int id)
        {
            var model = _context.Transactions.Find(id);
            return View(model);
        }
    }
}