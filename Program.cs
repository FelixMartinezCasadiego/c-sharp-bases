
partial class Program {
    static void Main(string[] args)
    {
        Methods();
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}