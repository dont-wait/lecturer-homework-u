package src;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        CaecerCipher cipher = new CaecerCipher();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please enter your message: ");
        String message = scanner.nextLine();

        StringBuilder decode = cipher.encrypt(message, 4);
        System.out.println(decode);

        System.out.println("Message is: " + cipher.decrypt(decode.toString(), 4));
    }
}
