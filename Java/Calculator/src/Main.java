import java.util.Scanner;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {
        // String Messages
        String welcomeMsg = "Welcome to my Java Calculator App. Please input two numbers and select an operator";
        System.out.println(welcomeMsg);

        Scanner scanner = new Scanner(System.in);

        System.out.println("First number:");
        int num1 = scanner.nextInt();
        System.out.println("Second number:");
        int num2 = scanner.nextInt();

        scanner.nextLine(); // Consumes the newLine character left in buffer

        System.out.println("Now select an operator from the following: + - * /");
        String op = scanner.nextLine();

        int result = 0; //initiate result variable
        switch(op){
            case "+": result = num1 + num2; break;
            case "-": result = num1 - num2; break;
            case "*": result = num1 * num2; break;
            case "/": result = num1 / num2; break;
            default: System.out.println("Error occurred please restart the program."); return;
        }
        System.out.println("The result is " + result);
    }
}