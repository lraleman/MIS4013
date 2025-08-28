using System.Runtime.InteropServices;

Random r = new Random();
int rando = r.Next(1, 5+1);
int guess;
int count = 0;
do
{
    Console.WriteLine("Please guess a number between 1 and 5 <<");
    string userGuess = Console.ReadLine();
    Console.WriteLine($"You guessed {userGuess}");
    guess = Convert.ToInt32( userGuess);
    count++;
    if (guess == rando)
    {
        
    }
    else if(guess > rando)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect: Too High");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine("Incorrect: Too Low");
        Console.ForegroundColor=ConsoleColor.White;
    }
    //Console.WriteLine($"Generated a random number with the value {rando}");
}
while (guess != rando);
Console.WriteLine($"You guessed correctly and it only took {count} attempts");