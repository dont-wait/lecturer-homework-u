public class Dog extends Animal{
    
    private String breed;
    public Dog(String name, String height, String id, String breed) {
            super(name, height, id);
            this.breed = breed;
        }
    @Override
    public void makeSound() {
        System.out.println("Dog make sound gau gau");
    }
    
    public void playWithHuman() {
        System.out.println("Dog play with human");
    }
}