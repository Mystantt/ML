using UnityEngine;
using System;

/* Class which represents every possible character Mobs + Hero that we can fight in the game
* Date : 04/08/2022
* Version : 1.0.0
* Author : DOMPEY Fabien
*/
[Serializable]
public abstract class FightableCharacter : Character{

    [SerializeField] private IStats _stats;
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _maxEnergy;
    private int _currentHP;
    private int _currentEnergy;

    public int MAXHP{get=> _maxHealth;}
    public int MAXEnergy{get=> _maxEnergy;}

    public FightableCharacter(string name,string desc,int maxhp,int maxen,IStats stats) : base(name,desc){
        _maxEnergy = maxen;
        _maxHealth = maxhp;
        _stats = stats.createStats();
        _currentEnergy = _maxEnergy;
        _currentHP = _maxHealth;
    }

    ///Access to stats usable in game
    
    public virtual double getMovementSpeed(){
        return _stats.getMovementSpeed();
    }
    
    public virtual double getAttackSpeed(){
        return _stats.getAttackSpeed();
    }

    public virtual int getPhysicalDamages(){
        return _stats.getPhysicalDamages();
    }

    public virtual int getSpecialDamages(){
        return _stats.getSpecialDamages();
    }

    public virtual int getCarryingCapacity(){
        return _stats.getCarryingCapacity();
    }

    //Heal energy and health of the character to the max
    public void replenishAll(){
        energizeFull();
        revitalizeFull();
    }

    //Heal the character fully
    public void revitalizeFull(){
        _currentHP = _maxHealth;
    }

    //Gives full energy to the character
    public void energizeFull(){
        _currentEnergy = _maxEnergy;
    }

    //Health management

    /// <param> mod, Positive modifier used for healing </param>
    public void heal(int mod){
        changeHealth(mod);
    }
    /// <param> mod, Positive modifier used for damages </param>
    public void takeDamages(int mod){
        changeHealth(-mod);
    }
    private void changeHealth(int mod){
        if(_currentHP+mod < 0){
            _currentHP = 0
        }else if(_currentHP+mod > _maxHealth){
            revitalizeFull();
        }else{
            _currentHP += mod;
        }
    }
    //Energy management

    /// <param> mod, Positive modifier used for replenishing this amount of energy </param>
    public void energize(int mod){
        changeEnergy(mod);
    }
    /// <param> mod, Positive modifier used for amount of energy used </param>
    public void useEnergy(int mod){
        changeEnergy(-mod);
    }
    private void changeEnergy(int mod){
        if(_currentEnergy+mod < 0){
            _currentEnergy = 0
        }else if(_currentEnergy+mod > _maxEnergy){
            energizeFull();
        }else{
            _currentEnergy += mod;
        }
    }


}