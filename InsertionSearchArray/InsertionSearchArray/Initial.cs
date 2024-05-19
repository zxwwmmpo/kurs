using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InsertionSearchArray;

public partial class Initial : Form
{
    private Realizer? realizer;

    private Parametrs? parametrs;

    //public delegate void ArrayDelegate(int[] dataArray);
    public event Action<Parametrs> changeData;


    public Initial()
    {
        InitializeComponent();
    }

    public void AddEvent(Action<Parametrs> action)
    {
        changeData += action;
    }

    private void textBoxInputNumber_TextChanged(object sender, EventArgs e)
    {
        buttonAddNumber.Enabled = textBoxInputNumber.TextLength != 0;
    }

    private void buttonAddNumber_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        parametrs = new Parametrs();
        for (int i = 0; i < parametrs._dataArray.Length; i++)
        {
            parametrs._dataArray[i] = random.Next(0, 10);
            richTextBoxOutPut.Text += Convert.ToString(parametrs._dataArray[i]) + " ";
        }

    }

    private void buttonAddData_Click(object sender, EventArgs e)
    {
        changeData?.Invoke(parametrs);
        Close();
    }
}
