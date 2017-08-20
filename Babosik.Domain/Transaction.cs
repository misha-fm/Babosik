using System;

namespace Babosik.Domain
{
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
