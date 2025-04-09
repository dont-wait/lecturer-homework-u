

public abstract class Animal {
    protected String name;
    protected String height;
    protected String id;
    
    public Animal(String name, String height, String id) {
        this.name = name;
        this.height = height;
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getHeight() {
        return height;
    }

    public void setHeight(String height) {
        this.height = height;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }
    
    public void makeSound() {
        System.out.println("Animal has sounds");
    }
    
}