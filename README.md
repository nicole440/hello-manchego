# hello-manchego
A Jeopardy-esque command line game where the only topic is cheese. I'm building this simple game to gain some hands-on practice while learning C#/.NET.

## Getting Started

### Prerequisites
To play Hello Manchego, you'll need:
- .NET Core SDK installed on your computer

### Installation
1. Clone this repository to your local machine:
```
git clone https://github.com/your-username/hello-manchego.git
```

2. Navigate to the project directory:
```
cd hello-manchego
```

3. Build the project:
```
dotnet build
```

4. Run the game:
```
dotnet run
```

## Gameplay
In Hello Manchego, you will be presented with questions. Your objective is to answer as many questions correctly as possible to earn points. Here's how the game works:
1. Launch the game by running the dotnet run command.
2. You will be asked if you're ready to play. Respond with 'Y' for yes or 'N' for no.
3. If you're ready to play, the first question will be displayed, and you will be prompted to answer it.
4. Enter your answer in the command line and press Enter (We'll give you the "What is..." text, so you only need to type your answer).
5. Your answer will be checked against the correct answer, and you will earn 10 points for a correct answer.
6. The next question will be presented, and the game continues until you decide to exit.

## Questions and Answers
The questions and answers are stored in a file called questions.txt. Each line in this file contains a question and its corresponding answer, separated by a colon. You can add, modify, or remove questions in this file to customize your cheese trivia experience.

To add questions to the game:
1. Open the questions.txt file.
2. Add a new line with the format: Question:Answer
3. Save the file.
4. Restart the game to see your new questions in action.

## License
This project is licensed under the MIT License - see the LICENSE file for details.