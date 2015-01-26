

import java.util.Scanner;

public class Substring_Broken {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String text = input.nextLine();
        int jump = Integer.parseInt(input.nextLine());

        String p = "p"; // added
        boolean hasMatch = false;
        int search = p.charAt(0);
        int len = text.length(); // added

        for (int i = 0; i < len; i++) {

            if (text.charAt(i) == search) {
                hasMatch = true;

                int endIndex = i + jump;

                // modified
                if (endIndex >= len) {
                    endIndex = len - 1;
                }

                String matchedString = text.substring(i, endIndex + 1); // added + 1
                System.out.println(matchedString);
                i += jump;
            }
        }

        if (!hasMatch) {
            System.out.println("no");
        }
    }
}

