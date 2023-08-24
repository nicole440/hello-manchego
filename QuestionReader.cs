using System;
using System.IO;
using System.Collections.Generic;

namespace HelloManchego;

public class QuestionReader
{
    private const string FILE_PATH = "questions.txt";
    private Dictionary<string, string> questionsAnswers = new Dictionary<string, string>();

    public QuestionReader(string FILE_PATH, Dictionary questionsAnswers)
    {
        this.FILE_PATH = FILE_PATH;
        this.questionsAnswers = questionsAnswers;
    }

    // TODO Add getters & setters

    void addQuestionsToDict()
    {
        try
        {
            using (StreamReader fileInput = new StreamReader(FILE_PATH))
            {
                // Read each line from questions.txt
                string line;
                while ((line = fileInput.ReadLine()) != null)
                {
                    // Assign each line as a new key/value pair in questionsAnswers dictionary, separated by the colon
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}