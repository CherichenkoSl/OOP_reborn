using System.Reflection.Metadata.Ecma335;

RationalNumbers a = new RationalNumbers(5, 2);
RationalNumbers b = new RationalNumbers(10, 4);
RationalNumbers c = a - b;
Console.WriteLine(a.Equals(b));
Console.WriteLine(a==b);
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(a < b);
Console.WriteLine(a.ToString());
Console.WriteLine(c.ToString());
int s =(int) b;
Console.WriteLine(s);
public class RationalNumbers
{
    public int _numerator;
    public int _denominator;
    public RationalNumbers(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    private double fraction()
    {
        return ((double)_numerator / _denominator);
    }
    public static bool operator ==(RationalNumbers r1,RationalNumbers r2)
    {
        return (r1.fraction()==r2.fraction());
    }
    public static bool operator !=(RationalNumbers r1, RationalNumbers r2)
    {
        return(r1.fraction()!=r2.fraction());
    }
    public  bool Equals(RationalNumbers obj)
    {
        return obj.fraction() == this.fraction();   
    }
    public static bool operator<(RationalNumbers r1, RationalNumbers r2)
    {
        return (r1.fraction() < r2.fraction());
    }
    public static bool operator>(RationalNumbers r1, RationalNumbers r2)
    {
        return (r1.fraction() > r2.fraction());
    }
    public static bool operator <=(RationalNumbers r1, RationalNumbers r2)
    {
        return (r1.fraction() <= r2.fraction());
    }
    public static bool operator >=(RationalNumbers r1, RationalNumbers r2)
    {
        return (r1.fraction() >= r2.fraction());
    }
    public override string ToString()
    {
        return this.fraction().ToString();
    }
    public static RationalNumbers operator+(RationalNumbers r1, RationalNumbers r2)
    {
        if(r1._denominator==r2._denominator)
        return new RationalNumbers(r1._numerator + r2._numerator, r2._denominator);
        else
        return new RationalNumbers(r1._numerator*r2._denominator + r2._numerator*r1._denominator, r1._denominator * r2._denominator);
    }
    public static RationalNumbers operator -(RationalNumbers r1, RationalNumbers r2)
    {
        if (r1._denominator == r2._denominator)
            return new RationalNumbers(r1._numerator - r2._numerator, r2._denominator);
        else
            return new RationalNumbers(r1._numerator * r2._denominator - r2._numerator * r1._denominator, r1._denominator * r2._denominator);
    }
    public static explicit operator int(RationalNumbers r1)
    {
        return (int)r1.fraction();
    }
}