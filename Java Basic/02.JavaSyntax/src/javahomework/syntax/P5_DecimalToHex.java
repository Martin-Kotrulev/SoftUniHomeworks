package javahomework.syntax;
import java.util.Scanner;

/**
 * Problem 5. Decimal to Hexadecimal
 * Write a program that enters a positive integer 
 * number num and converts and prints it in 
 * hexadecimal form. You may use some 
 * built-in method from the standard Java libraries. 
 */

public class P5_DecimalToHex {
    public static void main (String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println(Integer.toHexString(in.nextInt()).toUpperCase());
    }
}
