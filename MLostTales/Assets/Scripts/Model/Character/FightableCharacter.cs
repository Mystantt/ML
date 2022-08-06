using UnityEngine;
using System;

/* Class which represents every possible character Mobs + Hero that we can fight in the game
* Date : 04/08/2022
* Author : DOMPEY Fabien
* Version : 1.0.0
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
        _stats = stats.CreateStats();
        _currentEnergy = _maxEnergy;
        _currentHP = _maxHealth;
    }

    ///Access to stats usable in game
    
    public virtual double GetMovementSpeed(){
        return _stats.GetMovementSpeed();
    }
    
    public virtual double GetAttackSpeed(){
        return _stats.GetAttackSpeed();
    }

    public virtual int GetPhysicalDamages(){
        return _stats.GetPhysicalDamages();
    }

    public virtual int GetSpecialDamages(){
        return _stats.GetSpecialDamages();
    }

    public virtual int GetCarryingCapacity(){
        return _stats.GetCarryingCapacity();
    }

    //Heal energy and health of the character to the max
    public void ReplenishAll(){
        EnergizeFull();
        RevitalizeFull();
    }

    //Heal the character fully
    public void RevitalizeFull(){
        _currentHP = _maxHealth;
    }

    //Gives full energy to the character
    public void EnergizeFull(){
        _currentEnergy = _maxEnergy;
    }

    //Health management

    /// <param> mod, Positive modifier used for healing </param>
    public void Heal(int mod){
        ChangeHealth(mod);
    }
    /// <param> mod, Positive modifier used for damages </param>
    public void TakeDamages(int mod){
        ChangeHealth(-mod);
    }
    private void ChangeHealth(int mod){
        if(_currentHP+mod < 0){
            _currentHP = 0;
        }else if(_currentHP+mod > _maxHealth){
            RevitalizeFull();
        }else{
            _currentHP += mod;
        }
    }
    //Energy management

    /// <param> mod, Positive modifier used for replenishing this amount of energy </param>
    public void Energize(int mod){
        ChangeEnergy(mod);
    }
    /// <param> mod, Positive modifier used for amount of energy used </param>
    public void UseEnergy(int mod){
        ChangeEnergy(-mod);
    }
    private void ChangeEnergy(int mod){
        if(_currentEnergy+mod < 0){
            _currentEnergy = 0;
        }else if(_currentEnergy+mod > _maxEnergy){
            EnergizeFull();
        }else{
            _currentEnergy += mod;
        }
    }


}