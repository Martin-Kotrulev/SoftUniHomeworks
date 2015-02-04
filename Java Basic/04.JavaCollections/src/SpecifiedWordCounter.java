import java.util.Scanner;

/**
 * Problem 6. Count Specified Word
 * Write a program to find how many times a word
 * appears in given text. The text is given at the
 * first input line. The target word is given at the
 * second input line. The output is an integer number.
 * Please ignore the character casing. Consider that
 * any non-letter character is a word separator.
 */

public class SpecifiedWordCounter {

    static int countWord(String[] input, String word) {
        int ctr = 0;
        for (int i = 0; i < input.length; i++) {
            if (input[i].equalsIgnoreCase(word)) ctr++;
        }
        return ctr;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String[] input = in.nextLine().split("\\W");

        System.out.println(countWord(input, in.next()));
    }
}
