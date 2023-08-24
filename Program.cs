using System;

namespace HelloManchego
{
  // Command Line Interface
  class Program
  {
    private bool isPlaying = true;
    private Score score = new Score();
    private QuestionReader allQuestions = new QuestionReader();

    static void Main(string[] args)
    {
      Program program = new Program();
      program.run();
    }

    void run()
    {
      Console.WriteLine("Welcome to Hello Manchego, a Jeopardy-esque command line game where the only topic is cheese.");
      gaugeReadinessPrompt();
    }

    void gaugeReadinessPrompt()
    {
      Console.WriteLine("Are you ready to play? (Y/N)");
      string response = Console.ReadLine();
      readyToPlay(response);
    }

    bool readyToPlay(string response)
    {
      if (response.ToUpper() == "Y")
      {
        Console.WriteLine("Okay, here's your first question...");
        // askQuestion();
      }
      else if (response.ToUpper() == "N")
      {
        Console.WriteLine("Okay, bye!");
        isPlaying = false;
      }
      else
      {
        Console.WriteLine("Please enter a valid response (Y/N).");
        gaugeReadinessPrompt();
      }
      return isPlaying;
    }

    void askQuestion()
    {
      // Get the next question from list of questions
      // Then print to console

      Console.WriteLine("What is... ");
      string question = Console.ReadLine();

    }
  }
}