
namespace InsertionSearch_2;

public class Realizer
{
    private int _index;
    private int value;
    private int valueToSearch;
    public int[] dataArray;
    public int step;

    public Realizer(Parametrs parametrs)
    {
        dataArray = parametrs.dataArray;
        _index = parametrs.index;
        //value
    }

    public void SetStatus(Status obj)
    {
        dataArray = obj.dataArray;
        _index = obj.Index; //?
    }

    public Status GetStatus()
    {
        return new Status(dataArray, _index);
    }

    public void MakeStep(int step)
    {
        try
        {
            dataArray[step] = dataArray[step - 1];
            step = step - 1;
        }
        catch (Exception e)
        {
            //MessageBox.Show("операция выполнена");
        }
    }

    public void PerformInseart()
    {
        if (dataArray.Length < 12)
        {
            int[] newarr = new int[dataArray.Length + 1];
            for (int i = 0; i < dataArray.Length; i++)
            {
                newarr[i] = dataArray[i];
            }
            newarr[dataArray.Length] = 0;
            dataArray = newarr;
        }
        step = dataArray.Length - 1;
    }

    public void Insert(int index, int value)
    {
        dataArray[index] = value;
    }

    public void InseartionProcess(int index)
    {
        if (dataArray.Length < 12)
        {
            int[] newarr = new int[dataArray.Length + 1];
            for (int i = dataArray.Length; i > index; i--) //i = dataArray.Length
            {
                newarr[i] = dataArray[i - 1];
            }
            for (int i = 0; i < index; i++)
            {
                newarr[i] = dataArray[i];
            }
            dataArray = newarr; //? this.dataArray
        }
    }

    //****************************************************************//
    public void Resize(int[] dataArray)
    {
        if (dataArray.Length < 12)
        {
            int[] newarr = new int[dataArray.Length + 1];
            for (int i = 0; i < dataArray.Length; i++)
            {
                newarr[i] = dataArray[i];
            }
            newarr[dataArray.Length] = 0;
            dataArray = newarr; //?
        }
    }

    public bool AbleToStep()
    {
        if (dataArray[step] == null || step <= _index)
        {
            return false;
        }
        return true;
    }
}
