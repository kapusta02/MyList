namespace MyList;

public class Init
{
    public void Start()
    {
        MyList<int> newList = new MyList<int>();
        newList.Add(2);
        newList.Add(1);
        newList.Add(3);

        Console.WriteLine($"Элемент на позиции 1: {newList[1]}");
        Console.WriteLine($"Общее количество элементов: {newList.Count}");
        
        newList.Remove(0);
        Console.WriteLine($"Количество элементов в массиве: {newList.Count}");
    }
}