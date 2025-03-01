namespace BTVN_04;

public class Cabinet<T>
{
    private List<T>? items = new List<T>();
    
    public void Add(T item)
    {
        items.Add(item);
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

}