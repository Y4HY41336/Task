using System.Drawing;
namespace Algorithms;
public class CustomList<T>
{
    private T[] list;
    private int count = 0;
    private int capacity;
    public int Count { get { return count; } }
    public int Capacity { get { return capacity; } }
    public CustomList()
    {
        int capacity = 4;
        this.capacity = capacity;
        list = new T[capacity];
    }
    public CustomList(int capacity)
    {
        if (capacity < 1) capacity = 1;
        this.capacity = capacity;
        list = new T[capacity];
    }              
    public void Add(T newElement)
    {
        if (count == capacity)
        {
            T[] resized = new T[capacity * 2];
            for (int i = 0; i < capacity; i++)
            {
                resized[i] = list[i];
            }
            list = resized;
            capacity = capacity * 2;
        }

        list[count] = newElement;
        count++;
    }
    public T? Find(Predicate<T> match)
    {
        for (int i = 0; i < count; i++)
        {
            if (match(list[i]))
            {
                return list[i];
            }
        }
        return default;
    }
    public CustomList<T> FindAll(Predicate<T> match)
    {
        CustomList<T> list = new CustomList<T>();
        for (int i = 0; i < count; i++)
        {
            if (match(this.list[i]))
            {
                list.Add(this.list[i]);
            }
        }
        return list;
    }
    public bool Contains(T item)
    {                 
        if (count != 0 && Array.IndexOf(list, item) != -1)
        {
            return true;
        }
        return false;
    }
    public void Delete(int index)
    {
        for (int i = index; i < count - 1; i++)
        {
            list[i] = list[i + 1];
        }

        list[count - 1] = default(T);
        count--;
    }
    public bool Remove(T item)
    {
        int index = Array.IndexOf(list,item);
        if (index >= 0)
        {
            Delete(index);
            return true;
        }
        return false;
    }
    public bool Exists(Predicate<T> match)
    {
        foreach(T item in list)
        {
            if (match(item))
            {
                return true;
            }
        }
        return false;
    }
}

