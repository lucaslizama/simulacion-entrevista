﻿public class Bank
{
    private int id;
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

    public Bank(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public override string ToString()
    {
        return $"ID: {id}, Name: {name}";
    }
}