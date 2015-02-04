import java.util.Scanner;

/**
 * Problem 5. Count All Words
 * Write a program to count the number of words in given sentence.
 * Use any non-letter character as word separator.
 */

public class WordCounter {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String[] words = in.nextLine().split("\\W+"); // one or more non-characters separator
        System.out.println(words.length);
    }
}
