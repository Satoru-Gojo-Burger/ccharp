namespace MyList{

public class MyList
{
    private int[] _array = new int[4];

    public int _count = 0;

    public int Count
    {
        get { return _count; }
    }

    public void Add(int item) 
    {
        items.Add(item);
    }

    public void Remove(int item) {}

    public void RemoveAt(int item) {}

    public void Insert(int index, int item) {}

    public void Clear() {}

    public string ToString() {}
}
}