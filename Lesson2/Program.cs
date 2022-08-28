BankAccount a1 = new BankAccount();
BankAccount b1 = new BankAccount(43.21m);
BankAccount c1 = new BankAccount("credit");
BankAccount d1 = new BankAccount(123.65m,"deposit");
a1.Info();
b1.Info();
c1.Info();
d1.Info();
public class BankAccount
{
    private static int _randomid=1;
    private int _id;
    public int SeeId()
    {
       return _id;
    }
    public BankAccount() : this(2)
    {
    }
    private decimal _balance;
        private Type _type;
    public BankAccount(decimal balance):this(balance,"budgetary")
    {
    }
    public BankAccount(string type): this (0,type)
    {
    }
    public BankAccount( decimal balance, string type)
    {
        _balance = balance;
        switch (type)
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
                Console.WriteLine("Указан неккоректный тип счета");
                break;
        }
        _id = _randomid++;
    }

    public decimal SeeBalance()
    {
        return _balance;
    }
        private enum Type
    {
        settlement,
        credit,
        deposit,
        budgetary
    }
     public string SeeType()
    {
        return _type.ToString();
    }
    public void Info()
    {
        Console.WriteLine($"{SeeId()},{SeeBalance()},{SeeType()}");
    }
}


