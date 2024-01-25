using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12_1.Models
{
    /// <summary>
    /// Ковариантный интерфейс для перевода между счетами текущего клиента
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAccount<out T>
    {
        T Type { get; }
        decimal Amount { get; set; }
        void TopUp(decimal amount);
    }

    /// <summary>
    /// Контрвариантный интерфейс для перевода между счетами разных клиентов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITransfer<in T>
    {
        T Type { set; }
        decimal Amount { get; set; }
        void TransferTo(IAccount<T> destinationAccount, decimal amount);
    }

}
