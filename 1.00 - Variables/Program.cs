internal class Program
{
    private static void Main(string[] args)
    {
        // The default value is 0
        // Different ways to declare a variable and also numeric types
        int value = 123;
        int value2;
        const int value3 = 123;
        System.Int32 value4 = 123;

        byte value5 = 200;
        sbyte value6 = -20;
        long value7 = -21321312;


        Console.WriteLine(value);
        // Console.WriteLine(value2); unassigned value
        Console.WriteLine(value3);
        Console.WriteLine(value4);
        Console.WriteLine(value5);
        Console.WriteLine(value6);
        Console.WriteLine(value7);



        // Floating points numeric types

        // float
        float n1 = 1.2F;
        Console.WriteLine(n1);

        // double
        // The most used for scientific purposes due to its
        // large range of values
        double n2 = 1.234D;
        Console.WriteLine(n2);

        // decimal
        // The most used for financial market due to its 
        // high precision with decimal places
        decimal n3 = 1.43435M;
        Console.WriteLine(n3);


        // For float and decimal types, it's necessary to add
        // F and M respectively at the end of the value
        // it's recommended to add D for decimal though


        // Compairing the decimal precision of them
        Console.WriteLine("Float " + 1F / 3F);
        Console.WriteLine("Double " + 1D / 3D);
        Console.WriteLine("Decimal " + 1M / 3M);


        // non-numeric types

        // bool is obtained from logical comparisons, the default value is false
        bool v1 = true;
        Console.WriteLine(v1);


        // char the default value is '\0  - the unicode representation of NULL
        // char is enclosed in single quotes, while a string in double quotes 
        char v2 = 'A';
        Console.WriteLine(v2);

    }
}