var currentDate = DateTime.Now;
Console.WriteLine($"Current date and time: {currentDate}");
Console.WriteLine($"Days till Christmas: {(new DateTime(currentDate.Year, 12, 25) - currentDate).Days}");
Console.WriteLine("This is the first line. \nThis is the second line.");

