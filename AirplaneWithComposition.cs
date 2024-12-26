using System;

public class AirplaneWithComposition : Airplane
{
    public Wing LeftWing { get; set; }
    public Wing RightWing { get; set; }

    public AirplaneWithComposition(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto)
        : base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        LeftWing = new Wing("Left");
        RightWing = new Wing("Right");
    }

    // Переопределение GetInfo для отображения информации о крыльях
    public override string GetInfo()
    {
        return base.GetInfo() + $"\nКрыло слева: {LeftWing.Type}\nКрыло справа: {RightWing.Type}";
    }
}
