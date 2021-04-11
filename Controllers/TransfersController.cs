using BankingApp.Context;
using BankingApp.Models;
using BankingApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BankingApp.Controllers
{
    public class TransfersController : Controller
    {
        private SQLiteDBContext _context;
        private IAccountService _accountService;
        private ITransactionService _transactionService;
        private ITransactionsViewModel _viewModel;
        private ITransactions _transaction;

        public TransfersController(SQLiteDBContext context, IAccountService accountservice, ITransactionService transactionservice, ITransactionsViewModel viewModel, ITransactions transaction)
        {
            _context = context;
            _accountService = accountservice;
            _transactionService = transactionservice;
            _viewModel = viewModel;
            _transaction = transaction;
        }

        // GET: TransfersController
        public ActionResult Index()
        {
            _viewModel.ListItems = _accountService.GetAccounts();
            _viewModel.Amount = 0;
            _viewModel.LogEntry = _transaction;
            return View(_viewModel);
        }

        // GET: TransfersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransfersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransfersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransfersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransfersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TransactionsViewModel transactions)
        {
            if (ModelState.IsValid)
            {
                var fromModel = _context.Accounts.Find(transactions.FromId);
                fromModel.ACCOUNT_BALANCE -= transactions.Amount;
                _context.Accounts.Update(fromModel);
                var toModel = _context.Accounts.Find(transactions.ToId);
                toModel.ACCOUNT_BALANCE += transactions.Amount;
                _context.Accounts.Update(toModel);
                transactions.LogEntry = _transaction;
                transactions.LogEntry.AMOUNT = transactions.Amount;
                transactions.LogEntry.FROM_ACCOUNT_BALANCE = fromModel.ACCOUNT_BALANCE;
                transactions.LogEntry.TO_ACCOUNT_BALANCE = toModel.ACCOUNT_BALANCE;
                transactions.LogEntry.FROM_ACCOUNT_ID = fromModel.ACCOUNT_ID;
                transactions.LogEntry.TO_ACCOUNT_ID = toModel.ACCOUNT_ID;
                transactions.LogEntry.TRANACTION_TIMESTAMP = DateTime.Now;
                transactions.LogEntry.FROM_ACCOUNT_NAME = fromModel.ACCOUNT_NAME;
                transactions.LogEntry.TO_ACCOUNT_NAME = toModel.ACCOUNT_NAME;
                _context.Transactions.Add((Transactions)transactions.LogEntry);
                _context.SaveChanges();

                return RedirectToAction("Index", "Accounts");
            }
            else
            {
                return View();
            }
        }
    }
}