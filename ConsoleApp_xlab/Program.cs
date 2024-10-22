internal class Program
{
    
    private static void Main(string[] args)
    {
        // MyList myList = new MyList();
        // myList.Add(1);
        // myList.Add(2);
        // myList.Add(3);
        // myList.Add(4);

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        Console.WriteLine($"list - {string.Join(", ", list)}");
        list.Remove(3);
        Console.WriteLine($"list - {string.Join(", ", list)}");
    }

}