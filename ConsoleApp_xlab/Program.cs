internal class Program
{
    class TestClass 
    {
        int j = 1;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //var ansfer = Console.ReadLine();
        //Console.WriteLine(ansfer);

        bool b = true;
        byte bt = 0;
        short s = 0;
        int i = 0;
        float f = 0f;
        long l = 0;

        Console.WriteLine($"short - size: {sizeof(short)} min{short.MinValue} max{short.MaxValue}");
        Console.WriteLine($"ushort - size: {sizeof(ushort)} min{ushort.MinValue} max{ushort.MaxValue}");
        Console.WriteLine($"{Convert.ToString(int.MaxValue, 2)}");
 
        char c = 'e';
        ushort cs = c;
        string str = "abcd";
        str = str + "e";
        str = str.Insert(0, "f");

        byte[] by = new byte[8];

        Console.WriteLine($"{c} - {cs} // {str}");

        int ii = 0;
        long ll = int.MaxValue;
        ii = (int)ll;

        object o = ii;
        Console.WriteLine($"{o}");


        TestClass j = new TestClass();

        func(ref i);
        Console.WriteLine(j);

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        Console.WriteLine($"list - {string.Join(", ", list)}");
        list.Remove(3);
        Console.WriteLine($"list - {string.Join(", ", list)}");


        MyList myList = new MyList();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
    }

    public static void func(ref int o)
    {
        o++;
        Console.WriteLine(o);
    }
}