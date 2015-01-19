import java.util.Scanner;

public class P3_InputSumator {

    public static void main(String[] args) {

        System.out.println("Enter two numbers:");

        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();

        System.out.println("Result: "+(a+b));
    }
}
