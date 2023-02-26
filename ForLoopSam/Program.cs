
int sum = 0;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + 1; 

}

Console.WriteLine($"Final total {sum}");