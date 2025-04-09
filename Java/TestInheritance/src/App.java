public class App {
    public static void main(String[] args) throws Exception {
        Animal animal = new Animal("Animal", "100 cm", "ID-001") {

        };
        animal.makeSound();
        Animal dogs = new Dog("BETO", "59kg", "D-08", "Rau dai");
        dogs.makeSound();
        ((Dog)dogs).playWithHuman();
        
    }
}
