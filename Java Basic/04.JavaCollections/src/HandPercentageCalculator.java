import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Problem 12.Cards Frequencies
 * We are given a sequence of N playing cards from a standard deck.
 * The input consists of several cards (face + suit), separated by a space.
 * Write a program to calculate and print at the console the frequency of
 * each card face in format "card_face -> frequency".
 * The frequency is calculated by the formula appearances / N and is
 * expressed in percentages with exactly 2 digits after the decimal point.
 * The card faces with their frequency should be printed in the order of the
 * card face's first appearance in the input. The same card can appear
 * multiple times in the input, but it's face should be listed only once in the output.
 */

public class HandPercentageCalculator {
    private static void calculatePercentage(String[] input) {
        TreeMap<String, Double> cards = new TreeMap<>();

        for (String card : input) {
            if (!cards.containsKey(card)) {
                cards.put(card, 1.0);
            }
            else cards.put(card, cards.get(card) + 1);
        }

        for (Map.Entry<String, Double> entry : cards.entrySet()) {
            entry.setValue((entry.getValue() / input.length) * 100);
            System.out.printf("%s -> %.2f%%\n", entry.getKey(), entry.getValue());
        }
    }

    public static void main(String[] str) {
        Scanner in = new Scanner(System.in);
        String[] input = in.nextLine().split("\\W+");

        calculatePercentage(input);
    }
}
