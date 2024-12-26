using System;

public class PassengerAirplane : Airplane, IFuelCapacity
{
    public FuelTank FuelTank { get; set; }  // Агрегация с FuelTank
    public int PassengerCapacity { get; set; }
    public bool HasBusinessClass { get; set; }

    // Конструктор для инициализации
    public PassengerAirplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, int passengerCapacity, bool hasBusinessClass)
        : base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        PassengerCapacity = passengerCapacity;
        HasBusinessClass = hasBusinessClass;
        FuelTank = new FuelTank(3000);  // Создаем FuelTank для каждого самолета
    }

    // Реализация метода Refuel интерфейса IFuelCapacity
    public void Refuel(decimal amount)
    {
        FuelTank.Refuel(amount);  // Заправка топливного бака
    }

    // Переопределение GetInfo, если нужно добавить дополнительную информацию
    public override string GetInfo()
    {
        return base.GetInfo() + $"\nВместимость пассажиров: {PassengerCapacity}\nНаличие бизнес-класса: {(HasBusinessClass ? "Да" : "Нет")}";
    }
}
