import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

/**
 * Days between Two Dates
 * Write a program to calculate the difference between two
 * dates in number of days. The dates are entered at two
 * consecutive lines in format day-month-year. Days are in range
 * [1…31]. Months are in range [1…12]. Years are in range [1900…2100].
 */

public class DaysBetweenDatesCalculator {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("d-MM-yyyy");

        LocalDate date1 = LocalDate.parse(in.next(), formatter);
        LocalDate date2 = LocalDate.parse(in.next(), formatter);

        long diff = ChronoUnit.DAYS.between(date1, date2);

        System.out.println(diff);
    }
}
