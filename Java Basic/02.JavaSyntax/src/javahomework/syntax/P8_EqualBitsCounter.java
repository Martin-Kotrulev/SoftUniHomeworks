package javahomework.syntax;
import java.util.Scanner;

/**
 * Problem 8. * Count of Equal Bit Pairs
 * Write a program to count how many sequences 
 * of two equal bits ("00" or "11") can be 
 * found in the binary representation of 
 * given integer number n (with overlapping).
 */
public class P8_EqualBitsCounter {
    public static int countEquals(int n) {
        int count = 0;
        int current = n & 1;
        n >>= 1;
        while (n > 0) {
            if ((n & 1) == current)
                count++;
            else current = n & 1;
            n >>= 1;
        }
        return count;
    }
    
    public static void main (String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println(countEquals(in.nextInt()));
    }
}
