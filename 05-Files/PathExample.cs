partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/ExamplePath.txt";
        var fileName = Path.GetFileName(filePath); // Extracts "ExamplePath.txt"
        var fileExtension = Path.GetExtension(filePath); // Extracts ".txt"
        var directoryName = Path.GetDirectoryName(filePath); // Extracts "./05-Files"
        var combinedPath = Path.Combine("C:","User", "Documents", "Example.txt"); // Combines to "./05-Files/NewFile.txt"
        var fullFilePath = Path.GetFullPath(filePath); // Gets the absolute path

        WriteLine($"File Name: {fileName}");
        WriteLine($"File Extension: {fileExtension}");
        WriteLine($"Directory Name: {directoryName}");
        WriteLine($"Combined Path: {combinedPath}");
        WriteLine($"Full File Path: {fullFilePath}");
    }
}