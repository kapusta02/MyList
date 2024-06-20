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
        Console.WriteLine($"Суммарное количество элементов в массиве: {newList.Count}");

        Console.WriteLine("Полученные элементы в массиве:");
        foreach (var item in newList)
        {
            Console.WriteLine(item);
        }

        var filteredList = newList.Where(item => item > 1);
        Console.WriteLine("Отфильтрованный массив");
        foreach (var item in filteredList)
        {
            Console.WriteLine(item);
        }
    }
}