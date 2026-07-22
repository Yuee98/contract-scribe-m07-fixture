namespace SampleLibrary;

public class Catalog
{
    public string Name { get; set; } = string.Empty;

    public int Count { get; } = 1;

    public string Find(int id) => id.ToString();

    public string Find(string key) => key;

    public static string Format(string value) => value.ToUpperInvariant();

    public class Nested
    {
        public void Reset()
        {
        }
    }
}
