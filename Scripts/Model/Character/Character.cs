
public abstract class Character{

    private String _name;
    private String _description;

    public String Name{ get => _name; }
    public String Description{ get => _description, set=> _description = value;}

    public Character(string name,string description){
        _name = name;
        _description = description;
    }
}