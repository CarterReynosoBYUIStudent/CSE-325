var currentTime = DateTime.Now;
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is: {currentTime}");
Console.WriteLine($"Days till Christmas: {(new DateTime(currentTime.Year, 12, 25) - currentTime).Days}");