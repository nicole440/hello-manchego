import org.junit.Assert;
import org.junit.Test;
import java.io.File;
import java.io.FileNotFoundException;
import static org.junit.Assert.assertEquals;

public class QuestionsTest {
    @Test
     public void test_for_first_question() throws FileNotFoundException {
        // Arrange
        Questions.mapQuestionsAnswers();
        String expected = "This smooth rich slightly sweet double or triple cream cheese from Italy works very nicely in a variety of brulees.";
        // Act
        String actual = Questions.getQuestion(0);
        // Assert
        assertEquals(expected, actual);
    }

    @Test
    public void test_for_second_question() throws FileNotFoundException {
        // Arrange
        Questions.mapQuestionsAnswers();
        String expected = "As Limburger ages, it gains in flavor and this quality for which it is notorious.";
        // Act
        String actual = Questions.getQuestion(1);
        // Assert
        assertEquals(expected, actual);
    }

    @Test
    public void test_for_last_question() throws FileNotFoundException {
        // Arrange
        Questions.mapQuestionsAnswers();
        String expected = "This high-protein cheese made from sheep's milk is produced in the La Mancha region of Spain.";
        // Act
        String actual = Questions.getQuestion(30); // TODO access length of list instead of hard-coding here
        // Assert
        assertEquals(expected, actual);
    }


}
