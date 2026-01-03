partial class Program
{
    static void WriteFileExample()
    {
        var filePath = "./05-Files/ExampleWrite.txt";
        var content = "Hello, this is a sample text written to the file.";

        var streamWriter = new StreamWriter(filePath, append: true); // Open the file in append mode
        streamWriter.WriteLine(content); // Writing content to the file
        streamWriter.WriteLine("The current date and time is: " + DateTime.Now); // Writing additional line
        streamWriter.Dispose(); // Close the stream to release the file
        
        WriteLine($"File created successfully at: {Path.GetFullPath(filePath)}");
    }
}