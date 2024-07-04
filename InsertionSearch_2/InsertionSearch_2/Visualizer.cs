using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InsertionSearch_2;

public class Visualizer
{

    public Visualizer()
    {
    }

    public void Visualize(Graphics g, Status status)
    {
        Pen pen = new(Color.Black, 3);        
        DrawItems(g, pen, status);
    }
    
    public void DrawItems(Graphics g, Pen pen, Status arrayStatus)
    {
        for (int i = 0; i < arrayStatus.dataArray.Length; i++)
        {
            g.DrawRectangle(pen, i * 50, 20, 20, 20);
            DrawNumbers(arrayStatus.dataArray[i], g, pen, i * 50, 20);
        }
        //g.FillRectangle(new SolidBrush(Color.DarkSeaGreen), arrayStatus.Index * 50, 20, 20, 20); //?
    }

    public void DrawNumbers(int number, Graphics g, Pen pen, int x, int y)
    {
        g.DrawString(number.ToString(), new Font("Calibri", 12), Brushes.Black, x, y);
    }

    public void DrawingSearch(Graphics g, Status status, int j)
    {
        Pen pen = new(Color.Black, 3);        
        DrawItems(g, pen, status);
        DrawingSearch(g, new Pen(Color.DarkSeaGreen, 3), status, j);
    }

    public void DrawingSearch(Graphics g, Pen pen, Status arrayStatus, int j)
    {        
        g.DrawEllipse(pen, j * 50, 20, 20, 20);
    }

    public void DrawingInseart(Graphics g, Status status, int k)
    {
        Pen pen = new(Color.Black, 3);
        DrawItems(g, pen, status);
        g.DrawRectangle(new Pen(Color.DarkSeaGreen, 3), k * 50, 20, 20, 20);
    }
}    
