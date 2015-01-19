import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class P2_DateTimePrinter {

    private static DateTimeFormatter dtf = DateTimeFormatter.ofPattern("d MMMM, yyyy HH:mm");
    private static String dateAndTime = dtf.format(LocalDateTime.now());

    public static void main(String[] args) {

        System.out.println(dateAndTime);
    }
}
