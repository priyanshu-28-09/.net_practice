namespace Priyanshu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string name;
            name = "Priyanshu";
            Console.WriteLine(int.TryParse(name,out a));


            //Console.Write("Hello! ");
            //Console.WriteLine("Priyanshu");

            //Console.WriteLine("your name ");
            //name = Console.ReadLine();

            //Console.Write("Enter the first number: ");
            //a = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine(a + b);
            //Console.WriteLine("sum of : " + a + b);
            //Console.WriteLine("sum of : " + (a + b));
            //Console.WriteLine(a + b + " : is sum of a+b  ");
        }
    }
}


// convert - class
//following static method
//int a = 17;
//1. ToInt16() short b = Convert.ToInt16(a);
//2. ToInt32() int c = Convert.ToInt32(a);
// 3. ToInt64() long d = Convert.ToInt64(a);
//4. ToString() string e = Convert.ToString(a);
// 5. ToDouble() double f = Convert.ToDouble(a);
//6. ToBoolean() bool g = Convert.ToBoolean(a);
//7. ToChar() char h = Convert.ToChar(a);
// 8 todecimal() decimal i = Convert.ToDecimal(a);
//9.ToDateTime() DateTime j = Convert.ToDateTime(a);
//10 ToSingle() float k = Convert.ToSingle(a);
//11.ToByte() byte l = Convert.ToByte(a);

// extra 

//12.ToSByte() sbyte m = Convert.ToSByte(a);
//13.ToUInt16() ushort n = Convert.ToUInt16(a);
//14.ToUInt32() uint o = Convert.ToUInt32(a);
//15.ToUInt64() ulong p = Convert.ToUInt64(a);
//16.ToBase64String() string q = Convert.ToBase64String(a);
//17.ToBase64CharArray() char[] r = Convert.ToBase64CharArray(a);


// Parse Methods

// String = "123";
// int a = int.Parse(String);

//for string conversion
// string f;
// f = "pri";
// int b = int.tryParse(f);
// it return the boolean value if the string is converted to int or not;
