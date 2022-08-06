using System;
using UnityEngine;

[Serializable]
public abstract class Item : ScriptableObject{

    [SerializeField] private string _name;
    [TextArea] private string _description;
    [SerializeField] private double _weight;
    [SerializeField] private Rarity _rarity;

    public string Name { get=> _name;}
    public string Description {get=> _description; set=> _description=value;}
    public double Weight {get=> _weight;}
    public Rarity Rarity{get=> _rarity;}

    public Item(string name,string desc,double weight,Rarity rar){
        _name = name;
        _description = desc;
        _weight = weight;
        _rarity = rar;
    }
}