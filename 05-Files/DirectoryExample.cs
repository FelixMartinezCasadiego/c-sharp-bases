partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files/";
        Directory.CreateDirectory($"{directoryPath}/DirExample");

        if (Directory.Exists($"{directoryPath}/DirExample"))
        {
            WriteLine("The directory was created successfully.");
        }

        Directory.Delete($"{directoryPath}/DirExample",recursive: true);
    }

}