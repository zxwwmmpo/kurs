using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InsertionSearch_2;

public partial class MainForm : Form
{
    Visualizer? _visualizer;
    Manager _manager;

    private int j = -1;
    private int k = -1;

    public MainForm()
    {
        InitializeComponent();
    }

    public void InitializeLoad(Status status)
    {
        _visualizer = new Visualizer();
        Parametrs parametrs = new Parametrs(status.dataArray, 0);
        _manager = new Manager(parametrs);
        _manager.storage.AddStatus(status);
        pictureBoxVisualizer.Image = ShowArray(status);
    }

    public void CreateArray(Parametrs parametrs)
    {
        _visualizer = new Visualizer();
        _manager = new Manager(parametrs);
        _manager.storage.AddStatus(_manager.realizer.GetStatus());
        pictureBoxVisualizer.Image = ShowArray(_manager.realizer.GetStatus());
    }

    private Bitmap? DrawInseart(Status status, int k)
    {
        Bitmap bmp = new Bitmap(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);
        Graphics g = Graphics.FromImage(bmp);
        _visualizer.DrawingInseart(g, status, k);
        return bmp;
    }

    private Bitmap? DrawSearch(Status status, int j)
    {
        Bitmap bmp = new Bitmap(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);
        Graphics g = Graphics.FromImage(bmp);
        _visualizer.DrawingSearch(g, status, j);
        return bmp;
    }

    public Bitmap? ShowArray(Status status)
    {
        Bitmap bitmap = new(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);
        Graphics g = Graphics.FromImage(bitmap);
        _visualizer.Visualize(g, status);
        return bitmap;
    }


    private void buttonParametrsForm_Click(object sender, EventArgs e)
    {
        InitialForm form = new InitialForm();
        form.AddEvent(CreateArray);
        form.Show();
    }


    //вставка
    private void buttonInsert_Click(object sender, EventArgs e)
    {
        _manager.realizer.PerformInseart();
        k = int.Parse(textBoxGetIndex.Text) - 1;
        for (int i = _manager.realizer.dataArray.Length - 1; i > int.Parse(textBoxGetIndex.Text); i--)
        {
            _manager.realizer.MakeStep(i);
            _manager.storage.AddStatus(_manager.realizer.GetStatus());
        }

        _manager.realizer.Insert(int.Parse(textBoxGetIndex.Text), int.Parse(textBoxGetValue.Text));
        _manager.realizer.step = 0;
        _manager.storage.AddStatus(_manager.realizer.GetStatus());

        pictureBoxVisualizer.Image = ShowArray(_manager.realizer.GetStatus());
    }

    private void buttonInseartForward_Click(object sender, EventArgs e)
    {
        Status status = _manager.storage.GetNext();
        //pictureBoxVisualizer.Image = ShowArray(status);
        if (k > int.Parse(textBoxGetIndex.Text))
            k--;
        pictureBoxVisualizer.Image = DrawInseart(status, k);
    }


    private void buttonInseartBack_Click(object sender, EventArgs e)
    {

        Status status = _manager.storage.GetPrevious();
        //pictureBoxVisualizer.Image = ShowArray(status);
        if (k < _manager.realizer.dataArray.Length - 1)
            k++;
        pictureBoxVisualizer.Image = DrawInseart(status, k);
    }

    //поиск
    private void buttonSearch_Click(object sender, EventArgs e)
    {
        j = -1;
        pictureBoxVisualizer.Image = DrawSearch(_manager.realizer.GetStatus(), j);
    }

    private void buttonSearchForward_Click(object sender, EventArgs e)
    {
        try
        {
            j++;
            pictureBoxVisualizer.Image = DrawSearch(_manager.realizer.GetStatus(), j);
            if (_manager.realizer.dataArray[j] == int.Parse(textBoxGetValueToSearch.Text))
            {
                MessageBox.Show("элемент найден");
            }
        }
        catch
        {
            MessageBox.Show("конец массива");
        }
    }

    private void buttonSearchBack_Click(object sender, EventArgs e)
    {
        j--;
        pictureBoxVisualizer.Image = DrawSearch(_manager.realizer.GetStatus(), j);
    }


    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_manager == null)
        {
            MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                _manager.storage.SaveToFile(saveFileDialog.FileName);
                MessageBox.Show("\"Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //{
        //    if (_manager.storage.SaveToFile(saveFileDialog.FileName))
        //    {
        //        MessageBox.Show("Сохранение прошло успешно",
        //        "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //    else
        //    {
        //        MessageBox.Show("Не сохранилось", "Результат",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
    
    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {               
                _manager.storage.LoadFromFile(openFileDialog.FileName);
                _manager.storage.Reset();
                InitializeLoad(_manager.storage.Reset());
                MessageBox.Show("загрузка прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //if (openFileDialog.ShowDialog() == DialogResult.OK)
        //{
        //    if (_manager.storage.LoadFromFile(openFileDialog.FileName))
        //    {
        //        MessageBox.Show("загрузка прошло успешно",
        //        "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information); // загрузка 

        //    }
        //    else
        //    {
        //        MessageBox.Show("Не загрузилось", "Результат",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }


    private void buttonFormInfo_Click(object sender, EventArgs e)
    {
        FormInfo form = new FormInfo();
        form.Show();
    }


    //*******************************************//
    private void textBoxGetIndex_TextChanged(object sender, EventArgs e)
    {

    }
}
