import java.io.IOException;
import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class JeopardyCLI {
    Questions questions = new Questions();
    public static Map<String, String> questionsAnswers = new LinkedHashMap<>();
    static ArrayList<String> questionsList = new ArrayList<>();
    Scanner userInput = new Scanner(System.in);
    boolean isPlaying = true;
    int points = 0;
    final int POINTS_PER_QUESTION = 10;

    public static void main (String[]args) throws IndexOutOfBoundsException, IOException {
        Questions.mapQuestionsAnswers();
        JeopardyCLI cli = new JeopardyCLI();
        cli.play();
    }

    public void play() throws IOException {
        greetPlayer();
        if (isPlaying) {
            askQuestion();
        }
    }

    public void greetPlayer() throws IndexOutOfBoundsException {
        System.out.println("Welcome to Hello Manchego, a Jeopardy-esque command line game, but where the only topic is cheese.");
        System.out.println("Are you ready to play? (Y/N)");
        String readyToPlay = userInput.nextLine();

        if (readyToPlay.equalsIgnoreCase("Y")) {
            System.out.println("Okay, here's your first question...");
            askQuestion();
        } else if (readyToPlay.equalsIgnoreCase("N")) {
            System.out.println("Okay, bye!");
            isPlaying = false;
        } else {
            System.out.println("Please enter a valid response (Y/N)");
        }
    }

    public void askQuestion() throws IndexOutOfBoundsException {
        for (int i = 0; i < Questions.questionsAnswers.size(); i++) {
            System.out.println(Questions.getQuestion(i));
            System.out.println();
            System.out.print("What is... ");
            String userResponse = userInput.nextLine();
            if (userResponse.equalsIgnoreCase(Questions.questionsAnswers.get(i))) { // TODO fix this line so it compares user's response to the value of the paired key
                System.out.println("That is correct!");
                awardPoints();
            } else System.out.println("I'm sorry, that is incorrect.");
        }
    }

    public int awardPoints() {
        points += POINTS_PER_QUESTION;
        return points;
    }
}
