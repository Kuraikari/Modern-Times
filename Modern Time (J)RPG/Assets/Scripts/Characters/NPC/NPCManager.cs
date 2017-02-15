using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ***************************************************************
 * ***************************************************************
 * ***************** Classname: NPC Manager      *****************
 * ***************** Project:   Modern Times     ***************** 
 * ***************** Author:    Kuraikari        *****************
 * ***************************************************************
 * *************************************************************** */

public class NPCManager{

    public List<Character> characters;
    
    void createCharacters()
    {
        //Category
        characters.Add(new Character("Non-Functional Character", new NonPlayerCharacter(0, false), 10000, 10, 50, 10000, 5000));

        //Create Characters
        //Family
        characters.Add(new Character("Mom", new NonPlayerCharacter(1, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Dad", new NonPlayerCharacter(2, false), 800, 0, 8, 5, 25));
        characters.Add(new Character("Brother", new NonPlayerCharacter(3, false), 650, 0, 6, 20, 10));
        characters.Add(new Character("Sister", new NonPlayerCharacter(4, false), 480, 0, 4, 15, 5));
        characters.Add(new Character("Grandpa", new NonPlayerCharacter(5, false), 500, 0, 10, 15, 15));

        //Classmates
        characters.Add(new Character("Classmate 01", new NonPlayerCharacter(11, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 02", new NonPlayerCharacter(12, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 03", new NonPlayerCharacter(13, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 04", new NonPlayerCharacter(14, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 05", new NonPlayerCharacter(15, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 06", new NonPlayerCharacter(16, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 07", new NonPlayerCharacter(17, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 08", new NonPlayerCharacter(18, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 09", new NonPlayerCharacter(19, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 10", new NonPlayerCharacter(20, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 11", new NonPlayerCharacter(21, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 12", new NonPlayerCharacter(22, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 13", new NonPlayerCharacter(23, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 14", new NonPlayerCharacter(24, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 15", new NonPlayerCharacter(25, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 16", new NonPlayerCharacter(26, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 17", new NonPlayerCharacter(27, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 18", new NonPlayerCharacter(28, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 19", new NonPlayerCharacter(29, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Classmate 20", new NonPlayerCharacter(30, false), 500, 0, 7, 30, 10));

        //Students
        characters.Add(new Character("Student 01", new NonPlayerCharacter(31, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 02", new NonPlayerCharacter(32, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 03", new NonPlayerCharacter(33, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 04", new NonPlayerCharacter(34, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 05", new NonPlayerCharacter(35, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 06", new NonPlayerCharacter(36, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 07", new NonPlayerCharacter(37, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 08", new NonPlayerCharacter(38, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 09", new NonPlayerCharacter(39, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 10", new NonPlayerCharacter(40, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 11", new NonPlayerCharacter(41, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 12", new NonPlayerCharacter(42, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 13", new NonPlayerCharacter(43, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 14", new NonPlayerCharacter(44, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 15", new NonPlayerCharacter(45, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 16", new NonPlayerCharacter(46, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 17", new NonPlayerCharacter(47, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 18", new NonPlayerCharacter(48, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 19", new NonPlayerCharacter(49, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Student 20", new NonPlayerCharacter(50, false), 500, 0, 7, 30, 10));

        //Teachers
        characters.Add(new Character("Teacher 01", new NonPlayerCharacter(61, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Teacher 02", new NonPlayerCharacter(62, false), 500, 0, 7, 30, 10));
        characters.Add(new Character("Teacher 03", new NonPlayerCharacter(63, false), 500, 0, 7, 30, 10));

        //Category
        characters.Add(new Character("Functional Character", new NonPlayerCharacter(70, false), 10000, 10, 50, 10000, 5000));

        //Create Character
        characters.Add(new Character("Vendor", new NonPlayerCharacter(71, "Vendor", true, new Functions(0, new Vendor())), 10000, 10, 50, 10000, 5000));
        characters.Add(new Character("TradeMaster", new NonPlayerCharacter(72, "TradeMaster", true, new Functions(0, new TradeMaster())), 10000, 10, 50, 10000, 5000));
        characters.Add(new Character("StorageKeeper", new NonPlayerCharacter(73, "StorageKeeper", true, new Functions(0, new StorageKeeper())), 10000, 10, 50, 10000, 5000));
    }
}
