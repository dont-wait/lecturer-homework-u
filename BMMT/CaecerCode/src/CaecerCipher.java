package src;

import java.util.HashMap;

public class CaecerCipher {

    public StringBuilder decrypt(String decode, int key) {
        return encrypt(decode, 26 - key);
    }

    public StringBuilder encrypt(String plainText, int key) {
        StringBuilder encrypted = new StringBuilder();

        for(Character c : plainText.toCharArray()) {
            if(c != ' ' && Character.isLowerCase(c)) {
                int originalAlphaPosition = c - 'a';
                int newPosition = (originalAlphaPosition + key) % 26;
                encrypted.append((char) (newPosition + 'a'));
            }

            else if(c != ' ' && Character.isUpperCase(c)) {
                int originalAlphaPosition = c - 'A';
                int newPosition = (originalAlphaPosition + key) % 26;
                encrypted.append((char) (newPosition + 'A'));
            }
            else
                encrypted.append(c);
        }
        return encrypted;
    }
}
