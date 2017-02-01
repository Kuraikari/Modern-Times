using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialManager{

    List<Interest> interests = new List<Interest>();

    public List<Interest> createInterests()
    {
        //DEFAULT
        interests.Add(new Interest(0, "INTERESTS", "DEFAULT"));
        //FOOD
        interests.Add(new Interest(1, "SUSHI", "FOOD"));
        interests.Add(new Interest(2, "SASHIMI", "FOOD"));
        interests.Add(new Interest(3, "TAKOYAKI", "FOOD"));
        interests.Add(new Interest(4, "OMURAISU", "FOOD"));
        interests.Add(new Interest(5, "KARREIRAISU", "FOOD"));
        interests.Add(new Interest(6, "RAMEN", "FOOD"));
        interests.Add(new Interest(7, "UDON", "FOOD"));
        interests.Add(new Interest(8, "TAMAGO", "FOOD"));
        interests.Add(new Interest(9, "MELONPAN", "FOOD"));

        return createInterests();
    }

}
