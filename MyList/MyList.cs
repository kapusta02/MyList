using System.Collections;

namespace MyList;

public class MyList<T>: IEnumerable<T>
{
    private T[] _items = new T[4];
    private int _count = 0;

    public void Add(T item)
    {
        if (_count == _items.Length)
            Array.Resize(ref _items, _items.Length * 2);
        _items[_count] = item;
        _count++;
    }

    public T this[int index]
    {
        get
        {
            if (index >= _count || index < 0)
            {
                Console.WriteLine("Index out of range");
            }
            return _items[index];
        }
    }

    public int Count => _count;

    public void Remove(int index)
    {
        if (index >= _count || index < 0)
            Console.WriteLine("Index out of range");
        for (int i = index; i<_count-1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _count--;
        _items[_count] = default(T) ?? throw new InvalidOperationException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}