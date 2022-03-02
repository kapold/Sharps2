using System.Windows.Forms;

namespace LW2;

interface IFigure
{
    IFigure Clone();
    void GetInfo();
}

class Rectangle: IFigure
{
    int width;
    int height;
    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
 
    public IFigure Clone()
    {
        return new Rectangle(width, height);
    }
    public void GetInfo()
    {
        MessageBox.Show($"Прямоугольник длиной {height} и шириной {width}");
    }
}