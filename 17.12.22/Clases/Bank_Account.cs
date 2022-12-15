using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._12._22.Clases
{
    class Bank_Account
    {
        private Queue<BankTransaction> Queue = new Queue<BankTransaction>();
        public BankTransaction this[int index] => Queue.ToArray()[index]; // 13.2 CW индексаторы

        private string owner;
        private byte id;
        private decimal Balance { get; set; }
        public enum Acc_Type : byte
        {
            Сберегательный,
            Накопительный
        }

        private Acc_Type type;
        public byte ID //13.1 CW
        {
            get => id;
            set => id = value;// 13.1 HW
        }
        public Acc_Type Type // 13.1 CW
        {
            get => type;
            set => type = value; // 13.1 HW
        }
        public string Owner // 13.1 CW
        {
            get => owner;
            set => owner = value;
        }
        public Bank_Account() { }
        public Bank_Account(byte iD, decimal balance, Acc_Type type, string owner)
        {
            ID = iD;
            Balance = balance;
            Type = type;
            Owner = owner;
        }
        public void Print() => Console.WriteLine($"Id: {ID}\nДержатель счета {Owner}: \nБаланс : {Balance}\nТип счета : {Type}");
        public void Add(decimal cash)
        {
            Balance += cash;
            Console.WriteLine($"Счет пополнен. Ваш баланс : {Balance}");
            Queue.Enqueue(new BankTransaction(cash));
        }
        public void Lower(decimal cash)
        {
            if (Balance > 0)
            {
                if (Balance - cash > 0)
                {
                    Balance -= cash;
                    Console.WriteLine($"Вы сняли средства со счета. Баланс : {Balance}");
                }
                else
                {
                    Console.WriteLine($"Недостаточно средств : {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
            Queue.Enqueue(new BankTransaction(cash));
        }
        public void Transition(Bank_Account acc1, decimal perevod)
        {
            if (acc1.Balance > perevod)
            {
                acc1.Balance -= perevod;
                Balance += perevod;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
            Queue.Enqueue(new BankTransaction(perevod));
        }
        //public void Dispose()
        //{
        //    foreach (var i in Queue)
        //    {
        //        StreamWriter t = new StreamWriter("path.txt");
        //        t.WriteLine(i.ToString());
        //    }
        //}

    }
}
