import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

/**
 * Created by martinbkotr on 16.01.15.
 */
public class P2_DateTimePrinter {

    private static DateTimeFormatter dtf = DateTimeFormatter.ofPattern("d MMMM, yyyy HH:mm");
    private static String dateAndTime = dtf.format(LocalDateTime.now());

    public static void main(String[] args) {
        System.out.println(dateAndTime);
    }
}
