partial class Program
{
    static void FileExample()
    {
        var path = "./05-Files/Ejemplo.txt";

        var contentFile = File.ReadAllText(path);
        // WriteLine(contentFile);

        var lines = File.ReadAllLines(path);
        foreach (var itemline in lines)
        {
            WriteLine(itemline);
        }

        WriteLine("-----");
        WriteLine(lines[1]);

        File.Copy(path, "./05-Files/EjemploCopia.txt",overwrite: true); // true to overwrite if the file exists
        File.Delete("./05-Files/EjemploCopia.txt");
    }
}