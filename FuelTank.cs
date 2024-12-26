public class FuelTank
{
    public decimal Capacity { get; set; }
    public decimal CurrentFuel { get; set; }

    public FuelTank(decimal capacity)
    {
        Capacity = capacity;
        CurrentFuel = 0;
    }

    public void Refuel(decimal amount)
    {
        if (CurrentFuel + amount <= Capacity)
        {
            CurrentFuel += amount;
        }
        else
        {
            CurrentFuel = Capacity;
        }
    }
}
