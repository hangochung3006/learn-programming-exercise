public static class Triangle
{
    private static bool IsValid(double a, double b, double c) =>
        (a + b > c) && (b + c > a) && (a + c > b);
    public static bool IsScalene(double side1, double side2, double side3) =>
        IsValid(side1, side2, side3) &&
        (side1 != side2 && side1 != side3 && side2 != side3);

    public static bool IsIsosceles(double side1, double side2, double side3) =>
        IsValid(side1, side2, side3) &&
        (side1 == side2 || side1 == side3 || side2 == side3);

    public static bool IsEquilateral(double side1, double side2, double side3) =>
        IsValid(side1, side2, side3) &&
        (side1 == side2 && side2 == side3);
}