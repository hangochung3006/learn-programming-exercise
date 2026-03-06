public class SpaceAge
{
    private int giay;
    private double motNam = 31557600;
    private double[] cacSao = {0.2408467
                            , 0.61519726
                            , 1.8808158
                            , 11.862615
                            , 29.447498
                            , 84.016846
                            , 164.79132
                              };
    
    public SpaceAge(int giay)
    {
        this.giay = giay;
    }
    
    public double OnEarth() => giay / motNam;

    public double OnMercury() => OnEarth() / cacSao[0];

    public double OnVenus() => OnEarth() / cacSao[1];

    public double OnMars() => OnEarth() / cacSao[2];

    public double OnJupiter() => OnEarth() / cacSao[3];

    public double OnSaturn() => OnEarth() / cacSao[4];

    public double OnUranus() => OnEarth() / cacSao[5];

    public double OnNeptune() => OnEarth() / cacSao[6];

}