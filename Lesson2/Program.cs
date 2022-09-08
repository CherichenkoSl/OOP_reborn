string s = "My name is Slava";
Reverse(ref s);
Console.WriteLine(s);
string Reverse (ref string s)
{
    string srev="";
    for(int i=s.Length-1;i>=0;i--)
    {
        srev += s[i];
    }
    s = srev;
    return s;
}