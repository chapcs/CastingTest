using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(string[] args)
    {
        int myInt = 10;
        byte myByte = (byte)myInt;
        double myDouble = (double)myByte;
        // bool myBool = (bool)myDouble;
        string myString = "false";
        bool myBool = true;
        // myBool = (bool)myString;
        // myString = (string)myInt;
        myString = myInt.ToString();
        // myBool = (bool)myByte;
        // myByte = (byte)myBool;
        short myShort = (short)myInt;
        char myChar = 'x';
        myString = myChar.ToString();
        long myLong = (long)myInt;
        decimal myDecimal = (decimal)myLong;
        myString = myString + myInt + myByte + myDouble + myChar;
        Console.WriteLine(myString);

        // automatic conversions
        long l = 139401930;
        short s = 516;
        double d = l - s;
        Console.WriteLine(d);
        d = d / 123.456;
        Console.WriteLine("After dividing, the answer is " + d);

        // concatenate example
        string text = "The number for this example is " + l;
        Console.WriteLine(text);
        text = l.ToString();
        Console.WriteLine(text);

        int val = MyMethod(myBool);
        Console.WriteLine(val);
    }

    public static int MyMethod(bool add3)
    {
        int value = 12;

        if (add3) 
            value += 3;
        else 
            value -= 2;
        return value;
    }
}