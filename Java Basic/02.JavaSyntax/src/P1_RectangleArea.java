
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
