using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item {

    public int id { get; protected set; } 
    public string name { get; protected set; }
    public string description { get; protected set; }
    public double buyPrice { get; protected set; }
    public double sellPrice { get; protected set; }
    public int count { get; protected set; }

    public Item(int id, string name, string description, double buyPrice, double sellPrice, int count)
    {

        this.id = id; ;
        this.name = name;
        this.description = description;
        this.buyPrice = buyPrice;
        this.sellPrice = sellPrice;
        this.count = count;
    }

    public Item(int id, string name, int count)
    {

        this.id = id; ;
        this.name = name;
        description = "Sample Text";
        buyPrice = 0.00;
        sellPrice = 0.00;
        this.count = count;
    }

    public Item() {

        id = -1;
        name = "default";
        description = "Sample Text";
        buyPrice = 10000.00;
        sellPrice = 0.00;
        count = 0;
    }

}
