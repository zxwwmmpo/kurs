namespace InsertionSearchArray;

/// <summary>
/// класс-реализатор
/// </summary>
public class Realizer
{    
    static bool cheak = true;
    public const int MAX_ELEMENTS = 10;
    public int[] dataArray;
    public int count = 0;
    public int Index;
    public int value;
    int tmp = 0;

    /// <summary>
    /// конструктор класса-реализатора
    /// </summary>
    /// <param name="ArrayOfNumbers"></param>
    public Realizer(int[] dataArray, int Index, int value)
    {
        this.dataArray = dataArray;
        this.Index = Index;
        this.value = value;
    }

    public void ReSize(ref int[] dataArray)
    {
        int[] newarr = new int[dataArray.Length+1];
        for(int i=0; i<dataArray.Length; i++)
        {
            newarr[i] = dataArray[i];
        }
        newarr[dataArray.Length] = 0;
        dataArray = newarr;
    }

    /// <summary>
    /// объект класса состояния
    /// </summary>
    /// <param name="dataArray"></param>
    /// <param name="Counts"></param>
    /// <returns></returns>
    public Condition SaveCondition(int[] dataArray, int Index)
    {
        return new Condition(dataArray, Index);
    }

    public void ResStore(Condition condition)
    {
        dataArray = condition.dataArray;
        //count = condition.Counts;
    }

    public void AddElement(ref int[] dataArray, int value)
    {
        if(dataArray.Length < MAX_ELEMENTS)
        {
            dataArray[count] = value;
            count++;
        }
    }

    public void AddElementByIndex(ref int[] dataArray, int index, int number)
    {
        dataArray[index] = number;
    }

    public void InsertElement(int number, int index)
    {
        if (count < MAX_ELEMENTS && index < MAX_ELEMENTS)
        {
            count++;
            for(int i = count; i > index; i--)
            {
                dataArray[i] = dataArray[i - 1];
            }
            dataArray[index] = number;
        }
    }

    public int GetIndex()
    {
        if (count == 0)
        {
            return 0;
        }
        else
        {
            return count - 1;
        }
    }

    public string PrintArrayInREachBox(ref int[] dataAray)
    {
        string text = "";

        for (int i = 0; i < count; i++)
        {
            if (text == "")
            {
                text += dataArray[i].ToString();
            }
            else
            {
                text += ", " + dataArray[i].ToString();
            }
        }

        return text;
    }

    public bool FullMassive()
    {
        if (count == MAX_ELEMENTS)
        {
            return true;
        }
        return false;
    }
}