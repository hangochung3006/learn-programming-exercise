class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class

    public int speed;
    public int batteryDrain;
    protected int distanceDiDuoc = 0;
    protected int battery = 100;
    
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    public bool BatteryDrained() => (battery < batteryDrain);

    public int DistanceDriven() => distanceDiDuoc;

    public void Drive()
    {
       if(!BatteryDrained()){
           distanceDiDuoc += speed;
       }
       battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);

}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;
    
    public RaceTrack (int distance){
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car) => (100 / car.batteryDrain * car.speed >= distance);

}
