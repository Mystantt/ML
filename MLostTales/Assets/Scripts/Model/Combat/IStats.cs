
public interface IStats{

    public double GetMovementSpeed();
    
    public double GetAttackSpeed();

    public int GetPhysicalDamages();

    public int GetSpecialDamages();

    public int GetCarryingCapacity();

    public int GetStatusResistance();

    public IStats CreateStats();
}