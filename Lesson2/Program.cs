BankAccount b1 = new BankAccount(43.21m);
BankAccount c1 = new BankAccount("credit");
BankAccount d1 = new BankAccount(123.65m,"deposit");
BankAccount a1 = new BankAccount();
Console.WriteLine($"{b1.Balance},{b1.Id},{b1.TypeAcc}");
Console.WriteLine($"{c1.Balance},{c1.Id},{c1.TypeAcc}");
Console.WriteLine($"{d1.Balance},{d1.Id},{d1.TypeAcc}");
Console.WriteLine($"{a1.Balance},{a1.Id},{a1.TypeAcc}");
a1.Transfer(b1, 15.3214m);
public class BankAccount
{
    private static int _randomid=1;
    private int _id;
    public int Id { get { return _id; } }
    public BankAccount() : this(213,"deposit")
    {
    }
    private decimal _balance;
    public decimal Balance { get { return _balance; }set { _balance = value; } }
    private Type _type;
    public BankAccount(decimal balance):this(balance,"budgetary")
    {
    }
    public BankAccount(string type): this (0,type)
    {
    }
    public BankAccount( decimal balance, string type)
    {
        Balance = balance;
        TypeAcc=type;
        _id= _randomid++;
    }
    private enum Type
    {
        settlement,
        credit,
        deposit,
        budgetary
    }
    public void Transfer(BankAccount sender, decimal sum)
    {
        if (sum<=sender.Balance)
        {
            sender.Balance -= sum;
            Balance += sum;
            Console.WriteLine("Перевод выполнен");
            Console.WriteLine(sender.Balance);
            Console.WriteLine(Balance);
        }
        else
        {
            Console.WriteLine("Недостаточно средств");
        }
    }
    public string TypeAcc
    {
        get
        {
            return _type.ToString();
        }
        set
        {
            switch (value)
            {
                case "settlement":
                    _type = Type.settlement;
                    break;
                case "credit":
                    _type = Type.credit;
                    break;
                case "deposit":
                    _type = Type.deposit;
                    break;
                case "budgetary":
                    _type = Type.budgetary;
                    break;
                default:
                    _type = Type.settlement;
                    break;
            }
        }
    }
}