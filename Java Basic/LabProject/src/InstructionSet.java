import java.util.Scanner;

public class InstructionSet {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String opCode = input.nextLine();

        while (!opCode.equals("END")) {
            String[] codeArgs = opCode.split(" ");

            long result = 0;
            switch (codeArgs[0]) {
                case "INC": {
                    long operandOne = Long.parseLong(codeArgs[1]);
                    // changed from result = operandOne to result = (operandOne + 1)
                    result = (operandOne + 1);
                    break;
                }
                case "DEC": {
                    long operandOne = Long.parseLong(codeArgs[1]);
                    // changed from result = operandOne-- to result = (operandOne - 1)
                    result = (operandOne - 1);
                    break;
                }
                case "ADD": {
                    int operandOne  = Integer.parseInt(codeArgs[1]);
                    int operandTwo = Integer.parseInt(codeArgs[2]);
                    result = (long)operandOne + (long)operandTwo;
                    break;
                }
                case "MLA": {
                    int operandOne  = Integer.parseInt(codeArgs[1]);
                    int operandTwo = Integer.parseInt(codeArgs[2]);
                    result = (long)operandOne * (long)(operandTwo);
                    break;
                }
                default:
                    break;
            }
            // added the second line
            opCode = input.nextLine();
            System.out.println(result);
        }
    }
}
