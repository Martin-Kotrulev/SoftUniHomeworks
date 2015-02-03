import java.util.Arrays;
import java.util.Scanner;

/**
 * Generate 3-Letter Words
 * Write a program to generate and print all 3-letter
 * words consisting of given set of characters. For
 * example if we have the characters 'a' and 'b', all
 * possible words will be "aaa", "aab", "aba", "abb",
 * "baa", "bab", "bba" and "bbb". The input characters are
 * given as string at the first line of the input.
 * Input characters are unique (there are no repeating characters)
 */

public class ThreeLetterGenerator {

    static void printPermutation(char[] target) {
        for (char c : target)
            System.out.print(c + " ");
        System.out.println();
    }

    static void printPermutation(char[] arr, int[] helper) {
        for (int i = 0; i < arr.length; i++)
            System.out.print(arr[helper[i]]);
        System.out.println();
    }

    static void iterativePermutate(char[] arr) {
        // initialising helper
        int[] helper = new int[arr.length];
        for (int i = 0; i < helper.length; i++)
            helper[i] = 0;

        int currentPos;
        while (true) {
            printPermutation(arr, helper);
            currentPos = arr.length - 1; // setting position to the last element
            helper[currentPos]++; // next element in arr through helper iteration
            while(helper[currentPos] > arr.length - 1) { // if helper value is more than the elements in arr
                helper[currentPos] = 0; // restarting current position
                currentPos--; // back one element
                if (currentPos < 0) // no more iterations
                    return;
                helper[currentPos]++; // next element on the new position
            }
        }
    }

    static void recursivePermutate(char[] arr, char[] target, int i) {
        if (i == arr.length) {
            printPermutation(target);
            return;
        }

        for (int j = 0; j < arr.length; j++) {
            target[i] = arr[j];
            recursivePermutate(arr, target, i + 1);
        }
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        char[] arr = in.next().toCharArray();
        Arrays.sort(arr);

        char[] target = new char[arr.length];
        iterativePermutate(arr);
        recursivePermutate(arr, target, 0);
    }
}
