using System;
namespace BankAccountNS
    {
    /// <summary>
    /// Программа по учету операций на банковских счетах(дебит и кредит)
    /// <summary>;
    /// <param name="debit">Снятие денежных средств со счета</param>
    /// <param name="credit">Поступление денежных средств на счет</param>
    /// <exeption cref="ArgumentOutOfRangeException">Ограничевает вывод средств больше чем баланс на счету</exeption>
    /// <exeption cref="ArgumentOutOfRangeException">Ограничевает вывод средств менее чем 0</exeption>
    /// <exeption cref="ArgumentOutOfRangeException">Ограничевает пополнение средств менее чем 0</exeption>
    /// <return>Баланс банковского счета</return>
    public class BankAccount
        {
            private readonly string m_customerName;
            private double m_balance;
            private BankAccount() { }
            public BankAccount(string customerName, double balance)
            {
                m_customerName = customerName;
                m_balance = balance;
            }
            public string CustomerName
            {
                get { return m_customerName; }
            }
            public double Balance
            {
                get { return m_balance; }
            }
            public void Debit(double amount)
            {
                if (amount > m_balance)
{
                    throw new ArgumentOutOfRangeException("amount");
                }
                if (amount < 0)
{
                    throw new ArgumentOutOfRangeException("amount");
                }
                m_balance += amount;
            }
            public void Credit(double amount)
            {
                if (amount < 0)
{
                    throw new ArgumentOutOfRangeException("amount");
                }

                m_balance += amount;
            }
            public static void Main()
            {
                BankAccount ba = new BankAccount("Mr.Roman Abramovich",11.99);
                ba.Credit(5.77);
                ba.Debit(11.22);
                Console.WriteLine("Current balance is ${0}", ba.Balance);
                Console.ReadLine();
            }
        }
    }

