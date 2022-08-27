BankAccount a1 = new BankAccount();
BankAccount b1 = new BankAccount();
BankAccount c1 = new BankAccount();
a1.SetId();
b1.SetId();
c1.SetId();
Console.WriteLine($"{a1.SeeId()},{b1.SeeId()},{c1.SeeId()}");
public class BankAccount
{
    private static int _randomid=1;
    private int _id;
    public int SeeId()
    {
       return _id;
    }
    public void SetId()
    {
                _id = _randomid++;
    }
      private decimal _balance;
    public decimal SeeBalance()
    {
        return _balance;
    }
    public void SetBalance(decimal balance)
    {
        _balance = balance;
    }
    private enum Type
    {
        settlement,
        credit,
        deposit,
        budgetary
    }
    private Type _type;
    public void SetType(string type)
    {
        switch(type)
        {
            case "settlement":
                _type=Type.settlement ;
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
                default : 
                Console.WriteLine("Указан неккоректный тип счета");
                break;
        }
    }
    public string SeeType()
    {
        return _type.ToString();
    }
}

