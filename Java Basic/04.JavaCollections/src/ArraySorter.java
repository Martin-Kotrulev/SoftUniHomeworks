import java.util.Arrays;
import java.util.Scanner;

/**
 * Problem 1. Sort Array of Numbers
 * Write a program to enter a number n and n integer
 * numbers and sort and print them.
 * Keep the numbers in array of integers: int[].
 */

public class ArraySorter {
    public static void main (String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++) {
            numbers[i] = in.nextInt();
        }
        Arrays.sort(numbers);

        for (int i = 0; i < n; i++) {
            System.out.print(i != n - 1 ? numbers[i] + " " : numbers[i]);
        }
    }
}
