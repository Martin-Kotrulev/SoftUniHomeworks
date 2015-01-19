import java.util.Scanner;

public class P4_ArraySorter {

    static String[] selection_sort(String[] arr) {

        for (int i = 0; i < arr.length - 1; i++ ) {

            int index = i;

            for (int j = i + 1; j < arr.length; j++) {

                if (arr[j].compareToIgnoreCase(arr[index]) < 0)
                    index = j;
            }

            String smallerValue = arr[index];
            arr[index] = arr[i];
            arr[i] = smallerValue;
        }

        return arr;
    }

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        int n = in.nextInt();

        String[] toBeSorted = new String[n];
        for (int i = 0; i < n; i++)
            toBeSorted[i] = in.next();

        String[] sorted = selection_sort(toBeSorted);
        for (String name : sorted)
            System.out.printf("%s ", name);
    }
}
