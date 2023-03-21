public class Client
{
    private int id;
    private string rut;
    private string name;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Rut
    {
        get { return rut; }
        set { rut = value; }
    }

    public Client(int id, string rut, string name)
    {
        this.id = id;
        this.rut = rut;
        this.name = name;
    }

    public override string ToString()
    {
        return $"ID: {id}, RUT: {rut}, Name: {name}";
    }
}