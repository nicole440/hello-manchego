using System;
using System.IO;
using System.Collections.Generic;

namespace HelloManchego
{
  class Program
  {
    private bool isPlaying = true;
    private int points = 0;
    private const int POINTS_PER_QUESTION = 10;
    private const string filePath = "questions.txt";
    Dictionary<string, string> questionsAnswers = new Dictionary<string, string>();
    // static string[] questionsArray;

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
      getQuestion();
      Console.WriteLine("What is... ");
      string question = Console.ReadLine();

    }

    void questionsAndAnswersToDict()
    {
      try
      {
        using (StreamReader fileInput = new StreamReader(filePath))
        {
          // Read each line from questions.txt
          // Assign each line as a new key/value pair in questionsAnswers dictionary, separated by the colon
        }
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    string getQuestion()
    {
      return "";
    }

    int awardPoints()
    {
      points += POINTS_PER_QUESTION;
      return points;
    }
  }
}