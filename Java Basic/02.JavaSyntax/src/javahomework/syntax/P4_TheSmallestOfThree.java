package javahomework.syntax;

import java.util.Locale;
import java.util.Scanner;

/**
 * Problem 4. The Smallest of 3 Numbers
 * Write a program that finds the smallest of three numbers. 
 */

public class P4_TheSmallestOfThree {
    static public void main(String[] args){
        Scanner in = new Scanner(System.in);    
        float result = Math.min(Math.min(in.nextFloat(), in.nextFloat()), in.nextFloat());
        if (result == (long) result)
            System.out.printf("%d", (long)result);
        else
            System.out.printf("%.1f", result);
        
    }
}
