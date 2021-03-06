using System;
using System.Collections.Generic;
using Categorise.Data;
using System.Linq;

namespace Categorise.Services
{
    /// <summary>
    /// Service for exposing common actions for Transaction.
    /// </summary>
    public interface ITransactionService
    {
        /// <summary>
        /// Retrieve all transactions for the specified user.
        /// </summary>
        IEnumerable<Transaction> GetTransactions(string userId);

        /// <summary>
        /// Retrieve a single transaction for the specified user by transaction unique identifier.
        /// </summary>
        Transaction GetTransaction(Guid id);

        /// <summary>
        /// Creates a single transaction for the specified user.
        /// </summary>
        Transaction CreateTransaction(Transaction transaction, string userId);

        /// <summary>
        /// Updates a transaction owned by the specified user.
        /// </summary>
        void UpdateTransaction(Transaction transaction);

        /// <summary>
        /// Deletes a transaction owned by the specified user.
        /// </summary>
        void DeleteTransaction(Guid id);
    }

    /// <summary>
    /// Service for exposing common actions for Transaction.
    /// </summary>
    public class TransactionService : ITransactionService
    {
        private CategoriseContext _context;

        /// <summary>
        /// Constructor for TransactionService.
        /// </summary>
        public TransactionService(CategoriseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieve all transactions for the specified user.
        /// </summary>
        public IEnumerable<Transaction> GetTransactions(string userId)
        {
            return _context.Transactions.Where(t => t.UserId == userId).ToList();
        }

        /// <summary>
        /// Retrieve a single transaction for the specified user by transaction unique identifier.
        /// </summary>
        public Transaction GetTransaction(Guid id)
        {
            return _context.Transactions.Find(id);
        }

        /// <summary>
        /// Creates a single transaction for the specified user.
        /// </summary>
        public Transaction CreateTransaction(Transaction transaction, string userId)
        {
            transaction.UserId = userId;
            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            return transaction;
        }

        /// <summary>
        /// Updates a transaction owned by the specified user.
        /// </summary>
        public void UpdateTransaction(Transaction transactionParam)
        {
            Transaction transaction = _context.Transactions.Find(transactionParam.Id);

            // Update transaction properties.
            transaction.Account = transactionParam.Account;
            transaction.Amount = transactionParam.Amount;
            transaction.Category = transactionParam.Category;
            transaction.IsShared = transactionParam.IsShared;

            _context.Transactions.Update(transaction);
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes a transaction owned by the specified user.
        /// </summary>
        public void DeleteTransaction(Guid id)
        {
            var transaction = _context.Transactions.Find(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
        }
    }
}