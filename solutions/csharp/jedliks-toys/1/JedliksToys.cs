class RemoteControlCar
{
    public int khoangCach = 0;
    public int pin = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {khoangCach} meters";
   
    public string BatteryDisplay()
    {
        if (pin == 0) return "Battery empty";
        return $"Battery at {pin}%";
    }

    public void Drive()
    {
        if (pin > 0)
        {
            khoangCach += 20;
            pin--;
        }
    }
}
