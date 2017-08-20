using System;

namespace Babosik.Domain
{
    /// <summary>
    /// Счёт
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Наименование счёта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Текущий баланс счёта
        /// </summary>
        /// <value>The balance.</value>
        public float Balance { get; set; }

        /// <summary>
        /// Начальный баланс
        /// </summary>
        public float InitialBalance { get; set; }

        public IEnumerable<Transaction> Transactions { get; }
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
        
    }


}
