// See https://aka.ms/new-console-template for more information
namespace Rockpaperscissors
{
  class Game
  {
    public bool gameOver { get; private set; }
    public int wins { get; private set; }
    public int losses { get; private set; }
    public int ties { get; private set; }

    public string endGame { get; private set; }

    public int gamesPlayed { get; private set; }
    public Game()
    {
      Console.WriteLine("Please choose Rock, Paper, or Scissors.");
      gameOver = false;
      int wins = 0;
      int losses = 0;
      int ties = 0;
      int gamesPlayed = 0;
      endGame = " ";
      while (!gameOver)
      {
        if (endGame == "y")
        {
          gameOver = true;
          Console.WriteLine("Thanks for playing");
          Console.WriteLine("Your score was");
          Console.WriteLine("Wins" + wins);
          Console.WriteLine("Losses" + losses);
          Console.WriteLine("Ties" + ties);
          break;
        }
        string userInput = Console.ReadLine().ToLower();
        Random rand = new Random();
        int computerChoice = rand.Next(1, 4);
        {

          switch (computerChoice)
          {
            case 1:
              Console.WriteLine("The computer chose Rock");
              gamesPlayed++;
              if (userInput == "rock")
              {
                Console.WriteLine("It's a tie");
                ties++;
              }
              else if (userInput == "paper")
              {
                Console.WriteLine("You win");
                wins++;
              }
              else
              {
                Console.WriteLine("You lose");
                losses++;
              }
              break;

            case 2:
              Console.WriteLine("The computer chose Scissors");
              gamesPlayed++;
              if (userInput == "rock")
              {
                Console.WriteLine("You win");
                wins++;
              }
              else if (userInput == "paper")
              {
                Console.WriteLine("You lose");
                losses++;
              }
              else
              {
                Console.WriteLine("It's a tie");
                ties++;
              }
              break;

            case 3:
              Console.WriteLine("The computer chose Paper");
              gamesPlayed++;
              if (userInput == "rock")
              {
                Console.WriteLine("You lose");
                losses++;
              }
              else if (userInput == "paper")
              {
                Console.WriteLine("It's a tie");
                ties++;
              }
              else
              {
                Console.WriteLine("You win");
                wins++;
              }
              break;

            default:

              Console.WriteLine("invalid entry!");

              break;
          }
          if (gamesPlayed >= 5)
          {

            Console.WriteLine("Do you want to quit?");
            Console.WriteLine("Choose Y or N");
            endGame = Console.ReadLine().ToLower();
          }
        }
      }
    }
  }
}