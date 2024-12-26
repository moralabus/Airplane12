using System;

public class CargoAirplane : Airplane, IFuelCapacity
{
    public FuelTank FuelTank { get; set; }  // Агрегация с FuelTank
    public int CargoCapacity { get; set; }
    public string CargoType { get; set; }

    // Конструктор для инициализации
    public CargoAirplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, int cargoCapacity, string cargoType)
        : base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        CargoCapacity = cargoCapacity;
        CargoType = cargoType;
        FuelTank = new FuelTank(5000);  // Создаем FuelTank для каждого самолета
    }

    // Реализация метода Refuel интерфейса IFuelCapacity
    public void Refuel(decimal amount)
    {
        FuelTank.Refuel(amount);  // Заправка топливного бака
    }

    // Переопределение GetInfo, если нужно добавить дополнительную информацию
    public override string GetInfo()
    {
        return base.GetInfo() + $"\nГрузоподъемность: {CargoCapacity} кг\nТип груза: {CargoType}";
    }
}
