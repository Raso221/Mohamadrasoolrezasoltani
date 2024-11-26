using System;

class Program
{
    static void Main()
    {
       
        string johnsMessage = "Hello Mike, how are you?";
        string mikesMessage = "I'm fine thankyou John, thanks for asking!";

      
        int johnsScore = CalculateScore(johnsMessage);
        int mikesScore = CalculateScore(mikesMessage);

        
        Console.WriteLine($"John's score: {johnsScore}");
        Console.WriteLine($"Mike's score: {mikesScore}");
    }

    static int CalculateScore(string message)
    {
        int score = 0;

        foreach (char c in message.ToUpper())
        {
            if (char.IsLetter(c))
            {
                score += c - 'A' + 1; 
            }
        }

        return score;
    }
}

