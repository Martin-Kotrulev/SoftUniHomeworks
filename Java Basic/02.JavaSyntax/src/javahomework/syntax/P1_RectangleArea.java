package javahomework.syntax;

/** 
 * Problem 1. Rectangle Area
 * Write a program that enters the sides of a rectangle 
 * (two integers a and b) and calculates and prints 
 * the rectangle's area. 
 */

import java.util.Scanner;

public class P1_RectangleArea {

    static int rectArea(int width, int height) {
        return width * height;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int result = rectArea(in.nextInt(), in.nextInt());
        System.out.println(result);
    }
}
