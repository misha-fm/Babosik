using System.Collections.Generic;

namespace Babosik.Domain
{
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
}
