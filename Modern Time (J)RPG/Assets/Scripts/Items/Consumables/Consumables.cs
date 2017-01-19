using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumables : Item {

    public bool isUsed { get; set; }

    public Consumables (int id, string name, string description, double buyPrice, double sellPrice, int count, bool isUsed) : base(id, name, description, buyPrice, sellPrice, count)
    {
        this.isUsed = isUsed; ;

    }


}
