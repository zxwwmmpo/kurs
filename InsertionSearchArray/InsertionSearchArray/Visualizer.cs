
namespace InsertionSearchArray;

/// <summary>
/// класс-визуализатор
/// </summary>
public class Visualizer
{
    Condition? _condition { get; set; }

    /// <summary>
    /// ширина окна
    /// </summary>
    private int? _pictureWidth;

    /// <summary>
    /// высота окна
    /// </summary>
    private int? _pictureHeight;

    public Visualizer(Condition? condition)
    {
        _condition = condition;

    }

    public virtual void DrawingProcess(Graphics g, int value)
    {
        if (_condition == null)
        {
            return;
        }

        Pen pen1 = new Pen(Color.Black);
        Pen pen2 = new Pen(Color.DarkSeaGreen, 1);

        Font drawFont = new Font("Calibri", 12);

        SolidBrush solidBrush1 = new SolidBrush(Color.Black);
        SolidBrush solidBrush2 = new SolidBrush(Color.Red);

        StringFormat stringFormat = new StringFormat();

        for (int i = 0; i < _condition.dataArray.Length; i++)
        {
            string str = _condition.dataArray[i].ToString();
            //переделать
            if (_condition.dataArray[i] == value)
            {
                g.DrawString(str, drawFont, solidBrush2, i * 50, 20, stringFormat);
            }
            else
            {
                g.DrawString(str, drawFont, solidBrush1, i * 50, 20, stringFormat);
            }

            g.DrawRectangle(pen1, i * 50, 20, 20, 20);
        }
        g.DrawEllipse(pen2, _condition.Index * 50, 20, 20, 20);

    }
}
