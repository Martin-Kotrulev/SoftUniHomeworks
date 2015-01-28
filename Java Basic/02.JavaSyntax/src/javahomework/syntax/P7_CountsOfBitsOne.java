package javahomework.syntax;
import java.util.Scanner;

/**
 * Problem 6. Formatting Numbers
 * Write a program that reads 3 numbers: 
 * an integer a (0 ≤ a ≤ 500), a floating-point 
 * b and a floating-point c and prints them in 
 * 4 virtual columns on the console. 
 * Each column should have a width of 10 characters. 
 * The number a should be printed in hexadecimal, 
 * left aligned; then the number a should be 
 * printed in binary form, padded with zeroes, 
 * then the number b should be printed with 2 
 * digits after the decimal point, right aligned; 
 * the number c should be printed with 3 digits 
 * after the decimal point, left aligned.
 */

public class P7_CountsOfBitsOne {
    
    public static int countBinOnes(int n) {
        int count = 0;
        while (n > 0) {
            if ((n & 1) == 1)
                count++;
            n >>= 1;
        }
        return count;
    }
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        System.out.println(countBinOnes(n));
    }
}
