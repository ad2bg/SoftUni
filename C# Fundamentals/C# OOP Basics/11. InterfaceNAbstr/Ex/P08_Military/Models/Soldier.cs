﻿using System;

public class Soldier : ISoldier
{
    private int id;
    private string firstName;
    private string lastName;
    
    public int Id
    {
        get
        {
            return this.id;
        }
        private set
        {
            this.id = value;
        }
    }
    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        private set
        {
            this.lastName = value;
        }
    }

    public Soldier(int id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
    }
}
