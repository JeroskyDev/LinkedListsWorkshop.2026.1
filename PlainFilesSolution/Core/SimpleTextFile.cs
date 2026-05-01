namespace Core;

public class SimpleTextFile
{
    private readonly string _path;

    public SimpleTextFile(string path)
    {
        _path = path; //storage route/path
    }

    public void WriteLines(string[] lines)
    {
        var directory = Path.GetDirectoryName(_path);
        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        File.WriteAllLines(_path, lines); //write inside the path of storage the lines.
    }


    public string[] ReadLines()
    {
        if (!File.Exists(_path))
        {
            var directory = Path.GetDirectoryName(_path);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            File.WriteAllText(_path, string.Empty);
            return Array.Empty<string>();
        }
        return File.ReadAllLines(_path); //to read all of the lines inside of the path 
    }
}
