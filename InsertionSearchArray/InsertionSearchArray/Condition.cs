namespace InsertionSearchArray;

/// <summary>
/// класс-состояние
/// </summary>
public class Condition
{
    private const int MAX_ELEMENTS = 10;
    public int Counts;
    public int[] dataArray;
    public int Index;
    public Condition(int[] dataArray, int Index)
    {
        this.dataArray = dataArray;
        this.Index = Index;
    }
}
