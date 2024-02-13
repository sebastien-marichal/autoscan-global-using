// See https://aka.ms/new-console-template for more information

using Global.Usings;
using Global.Usings.Net7;

string json = """
              {
                "name": "John",
                "age": 30
              }
              """;

var person = JsonSerializer.Deserialize<Person>(json,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");