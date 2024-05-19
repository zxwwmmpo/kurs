using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertionSearchArray;

public partial class MainForm : Form
{
    Visualizer? _visualizer;
    //Parametrs? _parametrs;
    //Realizer _realizer;
    //вместо realizer:
    Manager? _manager;
    //Storage _storage;

    public MainForm()
    {
        InitializeComponent();
    }

    private void BuildArray(Parametrs parametrs)
    {
        _manager = new Manager(parametrs);
    }

    private void Draw()
    {
        if (_visualizer == null)
        {
            return;
        }
        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        Graphics g = Graphics.FromImage(bmp);
        _visualizer.DrawingProcess(g, _manager._realizer.value);
        pictureBox1.Image = bmp;
    }

    private void button1_Click(object sender, EventArgs e)
    {        
        _manager.PerformOperation();
        if (_manager._storage == null)
        {
            return;

        }
        _visualizer = new Visualizer(_manager._storage._conditions[0]);
        Draw();
    }

    int j = 0;
    private void button2_Click(object sender, EventArgs e)
    {
        if (_manager._storage == null || j + 1 >= _manager._storage._conditions.Count)
        {
            return;
        }
        else
        {
            j++;
        }
        _visualizer = new Visualizer(_manager._storage._conditions[j]);
        Draw();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (_manager._storage == null || j - 1 < 0)
        {
            return;
        }
        else
        {
            j--;
        }
        _visualizer = new Visualizer(_manager._storage._conditions[j]);
        Draw();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Initial form = new Initial();
        form.AddEvent(BuildArray);
        form.Show();
    }

    //-------------------//
    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
}
