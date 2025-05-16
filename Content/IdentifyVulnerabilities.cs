public static string BadReadFileContent(string fileName)
{
    string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
    if (File.Exists(filePath))
    {
        return File.ReadAllText(filePath);
    }
    else
    {
        return "File not found.";
    }
}