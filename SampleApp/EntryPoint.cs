namespace SampleApp;

public static class EntryPoint
{
    public static string Execute() => SampleLibrary.Catalog.Format("m07");
}

public class AppResult
{
    public int Code { get; set; }
}
