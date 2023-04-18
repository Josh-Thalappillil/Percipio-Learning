import java.util.Scanner;

public class Engine {
    Scanner scanner = new Scanner(System.in); // Initialise Scanner
    public int getNum1() {
        int num1 = scanner.nextInt();
        return num1;
    }
    public int getNum2() {
        int num2 = scanner.nextInt();
        return num2;
    }
    public void buffer(){
        scanner.nextLine();
    }
    public String operator(){
        String op = scanner.nextLine();
        return op;
    }
    public void calculate(int num1, int num2, String op){
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
