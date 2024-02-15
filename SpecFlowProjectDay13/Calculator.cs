namespace SpecFlowProjectDay13;

public class Calculator
{
    public int Fnum { get; set; }
    public int Snum { get; set; }

    public int Add()
    {
        int res;
        res = Fnum + Snum;
        return res;
    }
}