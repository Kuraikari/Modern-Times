using System;
using System.Collections.Generic;

[System.Serializable]
public class Interest
{
    public int id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public string subCategory { get; set; }

    public List<string> categories = new List<string>();
    public List<string> subCategories = new List<string>();

    public Interest()
    {
        id = -1;
    }

    public Interest(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public Interest(int id, string name, string category)
    {
        this.id = id;
        this.name = name;
        this.category = category;

        if (isCatAlreadyExisting(category) == false)
            categories.Add(category);

    }

    public Interest(int id, string name, string category, string subCategory)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.subCategory = subCategory;

        if (isCatAlreadyExisting(category) == false)
            categories.Add(category);

        if (isSubCatAlreadyExisting(subCategory) == false)
            subCategories.Add(subCategory);
    }

    //getters
    public int getID() { return id; }
    public string getName() { return name; }
    public string getCategory() { return category; }
    public string getSubCategory() { return subCategory; }

    //setters
    public void setID(int id) { this.id = id; }
    public void setName(string name) { this.name = name; }
    public void setCategory(string cat) { this.category = cat; }
    public void setSubCategory(string sub) { this.subCategory = sub; }

    //Create
    public Interest newInterest(int id, string name)
    {
        int thisID = id;
        string thisName = name;
        return newInterest(thisID, thisName);
    }

    public bool isCatAlreadyExisting(string cat)
    {
        return (categories.Contains(cat));
    }

    public bool isSubCatAlreadyExisting(string cat)
    {
        return (subCategories.Contains(cat));
    }
}
