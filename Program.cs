namespace multiplication;

class Program
{
    static void Main(string[] args)
    {
        // Instruktioner:
        // Be användaren att ange ett nummer.
        Console.WriteLine("Please enter a number:");
        int inputNumber = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Multiplication table for {inputNumber}:");
        // Använd en for-loop för att iterera från 1 till 10.
        // Inuti loop, multiplicera inmatningstalet med det aktuella iterationsvärdet
        // (loopvariabel).
        
        for (int i = 1; i <= 10; i++)
        {  
            int result = inputNumber * i;
            Console.WriteLine($"{inputNumber} x {i} = {result}");
        }
        
    }
}
