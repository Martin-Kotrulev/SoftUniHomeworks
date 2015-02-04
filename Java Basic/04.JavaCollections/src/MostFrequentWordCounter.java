import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Problem 11.Most Frequent Word
 * Write a program to find the most frequent word in a text and
 * print it, as well as how many times it appears in format
 * "word -> count". Consider any non-letter character as a
 * word separator. Ignore the character casing. If several
 * words have the same maximal frequency, print all of them in alphabetical order.
 */

public class MostFrequentWordCounter {
    private static void printMostFrequent(TreeMap<String, Integer> words, int best) {
        for (Map.Entry<String, Integer> entry : words.entrySet()) {
            if (entry.getValue() == best) {
                System.out.println(entry.getKey() + " -> " + best + " times");
            }
        }
    }

    private static void exctractMostFrequentWord(String[] input) {
        TreeMap<String, Integer> words = new TreeMap<>();
        int best = 0;

        for (String word : input) {
            if(words.containsKey(word)) {
                words.put(word, words.get(word) + 1);
            }
            else words.put(word, 1);

            if (words.get(word) > best) {
                best = words.get(word);
            }
        }
        printMostFrequent(words, best);
    }



    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String[] input = in.nextLine().split("\\W+");
        
        exctractMostFrequentWord(input);
    }
}
