class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[7] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1] += 1;

    public bool HasDayWithoutBirds()
    {
        bool a = false;
        foreach (int pTu in birdsPerDay){
            if (pTu == 0){
                a = true;
                break;
            }
        }
        return a;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int tong = 0;
        for (int i = 0; i < numberOfDays; i++){
            tong += birdsPerDay[i];
        }
        return tong;
    }

    public int BusyDays()
    {
        int busyDays = 0;
         foreach (int pTu in birdsPerDay){
             if(pTu >= 5){
                 busyDays++;
             }
         }
        return busyDays;
    }
}
