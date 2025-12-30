partial class Program
{
    static void Generics()
    {
        string[] names = ["Juan","Luis", "Diana"];
        int[] numbers = [1, 2, 3, 4, 5];
        Console.WriteLine($" Without Generics {GetStringArrayLength(names)}");
        Console.WriteLine($" Without Generics {GetIntArrayLength(numbers)}");
        Console.WriteLine($" With Generics {GetArrayLength(names)}");
        Console.WriteLine($" With Generics {GetArrayLength(numbers)}");

        Box<int> intBox = new()
        {
            Content = 123
        };
        intBox.Show();

        Box<string> strBox = new()
        {
            Content = "Hello Generics"
        };
        strBox.Show();
    }

    // Methods Without Generics
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }
        
    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    // Methods With Generics
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}

class Box<T>
{
    public T? Content { get; set; }

    public void Show()
    {
        Console.WriteLine(Content);
    }
}