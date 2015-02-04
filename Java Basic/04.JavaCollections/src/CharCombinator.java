import java.util.*;

/**
 * Problem 9. Combine Lists of Letters
 * Write a program that reads two lists of letters
 * l1 and l2 and combines them: appends all letters c
 * from l2 to the end of l1, but only when c does not
 * appear in l1. Print the obtained combined list. All
 * lists are given as sequence of letters separated by
 * a single space, each at a separate line.
 * Use ArrayList<Character> of chars to keep the input and output lists.
 */

public class CharCombinator {
    private static ArrayList<Character> proccesChars(String l1, String l2) {
        ArrayList<Character> letters = new ArrayList<>();
        for (char c : l1.toCharArray()) {
            if (c == ' ') continue;
            letters.add(c);
        }

        for (char c : l2.toCharArray()) {
            if (c == ' ' || letters.contains(c)) continue;
            letters.add(c);
        }

        return letters;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String first = in.nextLine();
        String second = in.nextLine();

        ArrayList<Character> letters = proccesChars(first, second);
        
        for (char c : letters) {
            System.out.print(
                    letters.indexOf(c) != letters.size() - 1 ? c + " " : c);
        }
    }
}
