import java.util.Scanner;

public class BitRotation_Broken {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        byte number = Byte.parseByte(input.nextLine());
        byte rotations = Byte.parseByte(input.nextLine());

        for (int i = 0; i < rotations; i++) {
            String direction = input.nextLine();

            if (direction.equals("right")) { // changed comparison to 'equals' method
                int rightMostBit = number & 1;
                number >>= 1;
                number |= rightMostBit << 5; //changed shift to 5
            } else if (direction.equals("left")) { // changed comparison to 'equals' method
                int leftMostBit = (number >> 5) & 1; // changed shift to 5
                number <<= 1;
                number |= leftMostBit; // added shift 5 position to left
            }
            number &= ~(1 << 6); // added for assuring the 7th bit always stays 0
        }
        System.out.println(number);
    }
}
