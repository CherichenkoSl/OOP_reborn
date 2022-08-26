BankAccount bank = new BankAccount();
bank.SetId(21376231);
bank.SetBalance(2313.4353m);
bank.SetType("credit");
Console.WriteLine($"ID:{bank.SeeId()} Balance:{bank.SeeBalance()} Type:{bank.SeeType()}");
public class BankAccount
{
    private int _id;
    public int SeeId()
    {
       return _id;
    }
    public void SetId(int id)
    {
        _id=id;
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

