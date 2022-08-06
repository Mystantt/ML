using System;

[Serializable]
public abstract class Equipment : Item{
    public Equipment(string name,string desc,double weight, Rarity rar) : base(name,desc,weight,rar){
        
    }
}