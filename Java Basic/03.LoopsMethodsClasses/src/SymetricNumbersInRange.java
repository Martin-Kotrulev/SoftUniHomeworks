import java.util.Scanner;

/**
 * Symmetric Numbers in Range
 * Write a program to generate and print all symmetric
 * numbers in given range [start…end] (0 ≤ start ≤ end ≤ 999).
 * A number is symmetric if its digits are symmetric toward
 * its middle. For example, the numbers 101, 33, 989
 * and 5 are symmetric, but 102, 34 and 997 are not symmetric.
 */

public class SymetricNumbersInRange {
    static boolean checkForSymetry(int n) {
        int result = 0;
        int compare = n;
        while (n > 0) {
            result *= 10;
            result += n % 10;
            n /= 10;
        }
        return compare == result;
    }

    static void iterate(int start, int end) {
        for (int i = start; i <= end; i++) {
            if (checkForSymetry(i))
                System.out.println(i);
        }
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int start = in.nextInt();
        int end = in.nextInt();
        iterate(start, end);
    }
}
