public static class Darts
{
    public static int Score(double x, double y)
    {
       double doDai = Math.Sqrt(x * x + y * y);
       if (doDai > 10) return 0;
       else if (doDai <= 10 && doDai > 5) return 1;
       else if (doDai <= 5 && doDai > 1) return 5;
       else return 10;
    }
}
