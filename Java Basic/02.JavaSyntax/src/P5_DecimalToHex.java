
import java.util.Scanner;


public class P5_DecimalToHex {
    public static void main (String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println(Integer.toHexString(in.nextInt()).toUpperCase());
    }
}
