using System;

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

    public override double getMovementSpeed(){
        return _swiftness;
    }
    
    public override double getAttackSpeed(){
        return 1 + _swiftness;
    }

    public int getPhysicalDamages(){
        return will;
    }

    public int getSpecialDamages(){
        return potential;
    }

    public int getCarryingCapacity(){
        return 100 + endurance;
    }

    public int getStatusResistance(){
        return endurance;
    }

    public IStats createStats(){
        return new Stats(_swiftness,_endurance,_will,_potential);
    }
}