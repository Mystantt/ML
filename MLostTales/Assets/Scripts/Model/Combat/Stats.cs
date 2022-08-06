using System;
using UnityEngine;

/* One of many possible implementation of stats in the game yet to be decided
* Date : 03/08/2022
* Author : Dompey Fabien
* Version : 1.0.0
*/
[Serializable]
public class Stats : IStats{

    //Ability that manages attack speed and movement speed
    [SerializeField] private int _swiftness;

    //Ability that manages carrying capacity and status resistance
    [SerializeField] private int _endurance;

    //Ability that manages any weapon damages
    [SerializeField] private int _will;

    //Ability that manages any capacity damages
    [SerializeField] private int _potential;

    public Stats(int swift,int endurance,int will,int potential){
        _swiftness = swift;
        _endurance = endurance;
        _will = will;
        _potential = potential;
    }

    public double GetMovementSpeed(){
        return _swiftness;
    }
    
    public double GetAttackSpeed(){
        return 1 + _swiftness;
    }

    public int GetPhysicalDamages(){
        return _will;
    }

    public int GetSpecialDamages(){
        return _potential;
    }

    public int GetCarryingCapacity(){
        return 100 + _endurance;
    }

    public int GetStatusResistance(){
        return _endurance;
    }

    public IStats CreateStats(){
        return new Stats(_swiftness,_endurance,_will,_potential);
    }
}