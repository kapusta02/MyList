namespace MyList;

public class Init
{
    public void Start()
    {
        var newList = new MyList<int>
        {
            2,
            1,
            3
        };

        Console.WriteLine($"Элемент на позиции 0: {newList[0]}");
        Console.WriteLine($"Общее количество элементов: {newList.Count}");

        newList.Remove(0);
        Console.WriteLine($"Суммарное количество элементов в массиве: {newList.Count}");

        Console.WriteLine("Полученные элементы в массиве:");
        foreach (var item in newList)
        {
            Console.WriteLine(item);
        }

        var filteredList = newList.Where(item => item > 1);
        Console.WriteLine("Элементы отфильтрованного массив:");
        foreach (var item in filteredList)
        {
            Console.WriteLine(item);
        }
    }
}