using System;
using System.Collections.Generic;

namespace Babosik.Domain
{
    /// <summary>
    /// Бухгалтерская книга
    /// </summary>
    public class Ledger
    {
        /// <summary>
        /// Список счетов
        /// </summary>
        public List<Account> Accounts => new List<Account>();

        /// <summary>
        /// Список статей дохода
        /// </summary>
        public List<IncomeItem> IncomeItems => new List<IncomeItem>();

        /// <summary>
        /// Список статей затрат
        /// </summary>
        public List<CostItem> CostItems => new List<CostItem>();

        /// <summary>
        /// Список транзакций
        /// </summary>
        public List<Transaction> Transactions => new List<Transaction>();
    }

    /// <summary>
    /// Счёт
    /// </summary>
    public class Account
    {
        public Account(string name, float initialBalance)
        {
            Name = name;
            InitialBalance = initialBalance;
        }

        /// <summary>
        /// Наименование счёта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Текущий баланс счёта
        /// </summary>
        public float Balance { get; set; }

        /// <summary>
        /// Начальный баланс
        /// </summary>
        public float InitialBalance { get; set; }

        /// <summary>
        /// Транзакции по счёту
        /// </summary>
        public IEnumerable<Transaction> Transactions => new List<Transaction>();

        /// <summary>
        /// Пополняет счёт
        /// </summary>
        /// <param name="from">Источник дохода</param>
        /// <param name="amount">Сумма пополнения</param>
        public void Replenish(IncomeItem from, float amount)
        {

        }

        /// <summary>
        /// Снимает со счёта
        /// </summary>
        /// <param name="to">Направление расхода</param>
        /// <param name="amount">Сумма рахсода</param>
        public void Withdraw(CostItem to, float amount)
        {

        }

    }

    /// <summary>
    /// Статья доходов
    /// </summary>
    public class IncomeItem
    {

    }

    /// <summary>
    /// Статья затрат
    /// </summary>
    public class CostItem
    {

    }

    /// <summary>
    /// Транзакция
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Источник
        /// </summary>
        public Account From { get; set; }

        /// <summary>
        /// Направление
        /// </summary>
        public CostItem To { get; set; }

        /// <summary>
        /// Размер транзакции
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Метка времени проведения транзакции
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
