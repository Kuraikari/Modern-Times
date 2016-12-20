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
    public Status status;

    //constructors
    public Status(uint id, string name, float duration, Status status)
    {
        this.id = id;
        this.name = name;
        this.duration = duration;
        this.status = status;
    }

    public Status()
    {
        id = 0;
    }

    //methods


}