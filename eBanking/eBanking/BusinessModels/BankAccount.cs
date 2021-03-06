﻿using System.Collections.Generic;

namespace eBanking.BusinessModels
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public decimal Balance { get; set; }
        public List<Transaction> TransactionsFrom { get; set; }
        public List<Transaction> TransactionsTo { get; set; }
    }
}
