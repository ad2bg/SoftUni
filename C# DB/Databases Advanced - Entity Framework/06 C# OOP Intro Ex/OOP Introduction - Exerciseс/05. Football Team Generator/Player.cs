﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;
    private decimal avgStats;

    public Player()
    {

    }
    
    public Player(string name,
    int endurance,
    int sprint,
    int dribble,
    int passing,
    int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
    }

    public decimal AverageStats()
    {
        decimal avg = (this.Endurance + this.Sprint + this.Dribble +
            this.Passing + this.Shooting) / 5.0m;

        return avg;
    }

    public decimal AvgStats
    {
        get
        {
            return this.avgStats;
        }
        set
        {
            this.avgStats = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            this.name = value;
        }
    }
    public int Endurance
    {
        get
        {
            return this.endurance;
        }
        set
        {
            if(value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            this.endurance = value;
        }
    }
    public int Sprint
    {
        get
        {
            return this.sprint;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Sprint should be between 0 and 100.");
            }
            this.sprint = value;
        }
    }
    public int Dribble
    {
        get
        {
            return this.dribble;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Dribble should be between 0 and 100.");
            }
            this.dribble = value;
        }
    }
    public int Passing
    {
        get
        {
            return this.passing;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Passing should be between 0 and 100.");
            }
            this.passing = value;
        }
    }
    public int Shooting
    {
        get
        {
            return this.shooting;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Shooting should be between 0 and 100.");
            }
            this.shooting = value;
        }
    }
}