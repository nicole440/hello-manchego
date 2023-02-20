import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

public class Questions {
    private Scanner in;
    public static Map<String, String> questionsAnswers = new LinkedHashMap<>();
    static ArrayList<String> questionsList = new ArrayList<>();

    public static void mapQuestionsAnswers() throws FileNotFoundException {
        // Establish file from which to read questions
        String filePath = "C:\\Users\\Nicole\\Git\\hello-manchego\\hello-manchego\\src\\main\\resources\\questions.txt";
        File questions = new File(filePath);
        // Put questions and answers (divided by colon) into a HashMap, with the questions reflecting the keys and the answers as the values.
        try (Scanner fileScanner = new Scanner(questions)) {
            while (fileScanner.hasNextLine()) {
                String question = fileScanner.nextLine();
                String[] splitLine = question.split(" : ");
                questionsAnswers.put(splitLine[0], splitLine[1]);
            }
        }
    }

    public static String getQuestion(int listIndex) {
        // TODO set up this method to get the next question each time it's called?
        String nextQuestion = "";
        // Put each question (Map key) into an ArrayList
        for (Map.Entry<String, String> question : questionsAnswers.entrySet()) {
            questionsList.add(question.getKey());
        } nextQuestion = questionsList.get(listIndex);
        return nextQuestion;
    }
}
