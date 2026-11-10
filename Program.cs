using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var stopwatch = Stopwatch.StartNew();

string filePath = "D:/Нова папка/ООП/Приклади/input.txt";
string? directoryPath = Path.GetDirectoryName(filePath);
if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
{
    Directory.CreateDirectory(directoryPath);
}

if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
{
    File.WriteAllText(filePath, "Приклад тексту у файлі для перевірки роботи програми.");
}

Console.WriteLine("Послідовне виконання:");
Console.WriteLine("Читання файлу та підрахунок символів...");

string fileContent = File.ReadAllText(filePath);
int charCount = fileContent.Length;

Console.WriteLine("Введіть текст з клавіатури (для завершення натисніть Enter на порожньому рядку):");
string? input;
while (!string.IsNullOrEmpty(input = Console.ReadLine()))
{
    Console.WriteLine($"Ви ввели: {input}");
}

Console.WriteLine($"Кількість символів у файлі: {charCount}");

stopwatch.Stop();
Console.WriteLine($"Час виконання: {stopwatch.ElapsedMilliseconds} мс");