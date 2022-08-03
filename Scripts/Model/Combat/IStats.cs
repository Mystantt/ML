
public interface IStats{

    public double getMovementSpeed();
    
    public double getAttackSpeed();

    public int getPhysicalDamages();

    public int getSpecialDamages();

    public int getCarryingCapacity();

    public int getStatusResistance();

    public IStats createStats();
}