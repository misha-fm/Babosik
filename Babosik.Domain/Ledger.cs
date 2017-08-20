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
}
