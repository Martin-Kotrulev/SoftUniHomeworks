import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Problem 7. Count Substring Occurrences
 * Write a program to find how many times given string appears
 * in given text as substring. The text is given at the first i
 * nput line. The search string is given at the second input line.
 * The output is an integer number. Please ignore the character casing.
 */

public class SubstringMatcher {
    static void printOccurances(String text, String ofWord) {
        Pattern pattern = Pattern.compile(
                String.format("(%s)", ofWord), Pattern.CASE_INSENSITIVE);

        Matcher matcher = pattern.matcher(text);

        int ctr = 0;
        while (matcher.find()) {
            ctr++;
        }

        System.out.println(ctr);
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String text = in.nextLine();

        printOccurances(text, in.next());
    }
}
