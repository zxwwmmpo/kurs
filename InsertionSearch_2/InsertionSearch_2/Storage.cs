
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InsertionSearch_2;
/// <summary>
/// класс - хранилище
/// </summary>
[Serializable]
public class Storage
{
    private readonly string _statusSeparator = "|";
    private readonly string _keyValueSeparator = ":";
    private readonly string _dictElemsSeparator = ",";
    private readonly string _itemSeparator = ";";

    private List<Status> statusList;

    private int currentIndex;

    public int StatusCount => statusList.Count;

    public Storage()
    {
        statusList = new List<Status>();
        currentIndex = -1;
    }

    public void AddStatus(Status status)
    {
        statusList.Add(status);
        currentIndex = StatusCount - 1;
    }
    public Status GetNext()
    {
        if (currentIndex < StatusCount - 1)
        {
            currentIndex++;
            return statusList[currentIndex];
        }
        return statusList[currentIndex];
    }
    public Status GetPrevious()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            return statusList[currentIndex];
        }
        return statusList[currentIndex];
    }
    public Status? Reset()
    {
        if (statusList.Count > 0)
        {
            currentIndex = 0;
            return statusList[currentIndex];
        }
        return null;
    }

    public void SaveToFile(string filePath)
    {
        using (FileStream fs = new(filePath, FileMode.Create))
        {
            #pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new();
            formatter.Serialize(fs, this);
            #pragma warning restore SYSLIB0011
        }

        //if (statusList.Count == 0)
        //{
        //    return false;
        //}
        //if (File.Exists(path))
        //{
        //    File.Delete(path);
        //}
        //StringBuilder sb = new();
        //foreach (Status status in statusList)
        //{
        //   //sb.Append(_itemSeparator);
        //    //sb.Append(currentIndex);
        //    sb.Append(_statusSeparator);
        //    for (int i = 0; i < status.dataArray.Length; i++)
        //    {
        //        sb.Append(Convert.ToString(status.dataArray[i]) + " ");// изменить
        //    }

        //    sb.Append(_statusSeparator);
        //    int count = 0;
        //    int amount = 0;
        //    //sb.Append(_statusSeparator + amount);
        //}
        //using FileStream fs = new(path, FileMode.Create);
        //byte[] info = new UTF8Encoding(true).GetBytes(sb.ToString());
        //fs.Write(info, 0, info.Length);
        //return true;
    }

    public void LoadFromFile(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            #pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new();
            statusList = ((Storage)formatter.Deserialize(fs)).statusList;
            #pragma warning restore SYSLIB0011
        }


        //if (!File.Exists(path))
        //{
        //    return false;
        //}
        //string bufferTextFromFile = "";
        //using (FileStream fs = new(path, FileMode.Open))
        //{
        //    byte[] b = new byte[fs.Length];
        //    UTF8Encoding temp = new(true);
        //    while (fs.Read(b, 0, b.Length) > 0)
        //    {
        //        bufferTextFromFile += temp.GetString(b);
        //    }
        //}
        //string[] strs = bufferTextFromFile.Split(_itemSeparator,
        //StringSplitOptions.RemoveEmptyEntries);
        //if (strs == null || strs.Length == 0)
        //{
        //    return false;
        //}
        //statusList.Clear();
        //foreach (string data in strs)
        //{            
        //    string[] record = data.Split(_statusSeparator,
        //    StringSplitOptions.RemoveEmptyEntries);
        //    //if (record.Length != 3)
        //    //{
        //    //    continue;
        //    //}
        //    int[] mass = new int[10];
        //    for(int i = 0; i < 10; i++)
        //    {
        //        mass[i] = Convert.ToInt32(record[1].Split(" ")); //?         
        //    }
        //    Status status = new Status(mass, 0);

        //    statusList.Add(status);
        //}
        //return true;

    }
}
