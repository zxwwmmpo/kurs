namespace InsertionSearch_2;

public class Parametrs
{
    public int[] dataArray { get; private set; }
    public int index { get; private set; }
    public Parametrs(int[] _dataArray, int index)
    {
        dataArray = _dataArray;
        this.index = index;
    }
}
