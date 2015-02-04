import java.util.Scanner;
import java.util.TreeSet;

/**
 * Problem 10.Extract All Unique Words
 * At the first line at the console you are given a piece of text.
 * Extract all words from it and print them in alphabetical order.
 * Consider each non-letter character as word separator.
 * Take the repeating words only once. Ignore the character casing.
 * Print the result words in a single line, separated by spaces.
 */

public class UniqueWordsExtractor {
    private static void printUniques(TreeSet<String> uniques) {
        for (String unique : uniques)
            System.out.print(unique != uniques.last() ? unique + " " : unique);
    }

    private static void extractUniqueWords(String[] input) {
        TreeSet<String> uniques = new TreeSet<>();

        for (String word : input) {
            if (uniques.contains(word.toLowerCase())) continue;
            uniques.add(word.toLowerCase());
        }

        printUniques(uniques);
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String[] input = in.nextLine().split("\\W+");

        extractUniqueWords(input);
    }
}
