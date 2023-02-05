using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class SomeBool
{
    public static bool operator ==(SomeBool someBool, bool value)
    {
        return true;
    }
    public static bool operator !=(SomeBool someBool, bool value)
    {
        return true;
    }
    public override bool Equals(object? obj)
    {
        return true;
    }
    public override int GetHashCode()
    {
        return 1;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        SomeBool someBool = new SomeBool();
       
        Console.WriteLine(someBool == true && someBool == false);
    }
}