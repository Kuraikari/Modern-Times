/* This script describes the logic of the different statuses. 
 * At the moment it won't do much complicated. 
 * It's only interesting for later use.
 *
 * Author: zian Wermelinger 
 * Project: Modern Time (J)RPG */

using System.Collections.Generic;

public class Status
{
    //attributes
    public uint id;
    public string name;
    public float duration;

    //constructors
    public Status(uint id, string name, float duration)
    {
        this.id = id;
        this.name = name;
        this.duration = duration;
    }

    public Status()
    {
        id = 0;
    }

    //Getters
    public uint getID() { return id; }
    public string getString() { return name; }
    public float getDuration() { return duration;  }


    //Setters
    public void setID(uint id) { this.id = id; }
    public void setString(string name) { this.name = name; }
    public void setDuration(float duration) { this.duration = duration; }
}