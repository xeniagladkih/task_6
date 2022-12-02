using System.Text.Json;

string bookJsonData = File.ReadAllText("Books.json");

var books = JsonSerializer.Deserialize<List<Book>>(bookJsonData);

if (books != null)
{
    foreach (var book in books)
    {
        Console.WriteLine($"{book.PublishingHouseId} {book.Title} {book.PublishingHouse.Id} {book.PublishingHouse.Name} {book.PublishingHouse.Adress}");
    }
}

Console.Read();
