using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertionSearch_2;

public partial class InitialForm : Form
{    
    Parametrs parametrs;        

    private Action<Parametrs> _paramtersChanged;

    public InitialForm()
    {
        InitializeComponent();
    }
    
    public void AddEvent(Action<Parametrs> action)
    {
        _paramtersChanged += action;
    }

    private void buttonAddRandomArray_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        int[] newarr = new int[10];

        for (int i = 0; i < newarr.Length; i++)
        {
            newarr[i] = random.Next(0, 10);

        }
        parametrs = new Parametrs(newarr, 0);//?
        
        for (int i = 0; i < parametrs.dataArray.Length; i++)
        {
            richTextBoxOutPut.Text += Convert.ToString(parametrs.dataArray[i]) + " ";
        }

    }

    private void buttonAddArray_Click(object sender, EventArgs e)
    {
        int count = (int)numericUpDownAddSize.Value;

        int[] newarr = new int[count];
        string[] str = textBoxAddArray.Text.Split(" ");
        if (count != str.Length)
        {
            MessageBox.Show("размеры не совпадают, переделайте массив или размер");
        }
        for (int i = 0; i < count; i++)
        {
            newarr[i] = int.Parse(str[i]);
            
        }
        parametrs = new Parametrs(newarr, 0);//?
        for(int i = 0; i< parametrs.dataArray.Length; i++)
        {
            richTextBoxOutPut.Text += Convert.ToString(parametrs.dataArray[i]) + " ";
        }
    }

    private void buttonAddSize_Click(object sender, EventArgs e)
    {
        int count = (int)numericUpDownAddSize.Value;
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        _paramtersChanged?.Invoke(parametrs);

        //ParametrsEvent?.Invoke(parametrs);
        Close();
    }
}
