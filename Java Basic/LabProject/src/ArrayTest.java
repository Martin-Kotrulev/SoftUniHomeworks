

import java.util.Scanner;

public class ArrayTest {
    public static void main(String[] args) {
        @SuppressWarnings("resource")
        Scanner scn = new Scanner(System.in);

        int sizeOfArray = scn.nextInt();
        long[] array = new long[sizeOfArray];

        for (int i = 0; i < array.length; i++) {
            array[i] = scn.nextLong();
        }

        String command = scn.next();

        while (!command.equals("stop")) { // edited to stop
            String line = scn.nextLine().trim();
            int[] params = new int[2];

            if(command.equals("add") || command.equals("subtract") || command.equals("multiply")) { // edited to subtract
                String[] stringParams = line.split(" ");
                params[0] = Integer.parseInt(stringParams[0]) - 1; // added - 1
                params[1] = Integer.parseInt(stringParams[1]);

                performAction(array, command, params);
            } else { performAction(array,command, params);}


            // deleted second action
            printArray(array);
            System.out.print('\n');

            command = scn.next();
        }
    }

    static void performAction(long[] arr, String action, int[] params){

        int pos = params[0];
        int value = params[1];

        switch (action) {
            case "multiply":
                arr[pos] *= value;
                break;
            case "add":
                arr[pos] += value;
                break;
            case "subtract":
                arr[pos] -= value;
                break;
            case "lshift":
                arrayShiftLeft(arr);
                break;
            case "rshift":
                arrayShiftRight(arr);
                break;
        }
    }

    private static void arrayShiftRight(long[] array) {
        long last = array[array.length - 1];
        for (int i = array.length-1; i >= 1 ; i--) {
            array[i] = array[i - 1];
        }
        array[0] = last;
    }

    private static void arrayShiftLeft(long[] array) {
        long first = array[0];
        for (int i = 0; i < array.length - 1; i++) {
            array[i] = array[i+1];
        }
        array[array.length - 1] = first;
    }

    private static void printArray(long[] array) {

        for (int i = 0; i < array.length; i++) {
            System.out.print(array[i] + " ");
        }

    }
}