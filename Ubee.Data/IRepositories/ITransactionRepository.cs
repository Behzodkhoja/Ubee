﻿using System.Transactions;

namespace Ubee.Data.IRepositories;

public interface ITransactionRepository
{
    ValueTask<Transaction> InsertTransactionAsync(Transaction transaction);
    ValueTask<Transaction> UpdateTransactionAsync(Transaction transaction);
    ValueTask<bool> DeleteTransactionAysnyc(long id);
    ValueTask<Transaction> SelectTransactionById(long id);
    IQueryable<Transaction> SelectAllTransactions();
}
