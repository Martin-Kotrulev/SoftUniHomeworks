import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

/**
 * Sum Numbers from a Text File
 * Write a program to read a text file "Input.txt" holding a
 * sequence of integer numbers, each at a separate line. Print
 * the sum of the numbers at the console. Ensure you close
 * correctly the file in case of exception or in case of
 * normal execution. In case of exception (e.g. the file is missing),
 * print "Error" as a result.
 * */

 public class SumFromAFileCalculator {
    public static void main(String[] args) throws IOException {

        int result = 0;
        try (BufferedReader br =
            new BufferedReader(new FileReader("input.txt"))) {
            String line;

            while ((line = br.readLine()) != null) {
                result += Integer.parseInt(line);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

        System.out.println(result);
    }
}
