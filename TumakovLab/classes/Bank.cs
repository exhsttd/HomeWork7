// Упражнение 8.1
namespace TumakovLab.Classes
{
    public class Account
    {

        private decimal balance;
        public TypeOfCheck TypeOfCheck { get; private set; }

        public Account(decimal initialBalance, TypeOfCheck accountTypeOfCheck)
        {
            balance = initialBalance;
            TypeOfCheck = accountTypeOfCheck;
        }

        public void Add(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"На счет добавлено {amount}. Текущий баланс: {balance}");
        }

        public void Drop(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств на счете!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Снято {amount}. Остаток на счете: {balance}");
            }
        }

        public void GetAccountDetails()
        {
            Console.WriteLine($"Тип счета: {TypeOfCheck}, Баланс: {balance}");
        }
        
        // Упражнение 8.1 В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить
        // метод, который переводит деньги с одного счета на другой.
        public void Transfer(Account toAccount, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма должна быть больше нуля.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств для перевода.");
                return;
            }
            
            this.Drop(amount);
            toAccount.Add(amount);
            Console.WriteLine($"Переведено {amount} с счета типа {this.TypeOfCheck} на счет типа {toAccount.TypeOfCheck}.");
        }
    }
}

