using System.Drawing;

namespace LW2;

public class SingletonForm
{
    private static SingletonForm formInfo;
    
    public Color BackgroundColor { get; private set; }
    public Font FontType { get; private set; }
    public Size FormSize { get; private set; }

    protected SingletonForm(Color color, Font font, Size size)
    {
        BackgroundColor = color;
        FontType = font;
        FormSize = size;
    }

    public static SingletonForm getSingle(Color color, Font font, Size size)
    {
        if (formInfo == null)
        {
            formInfo = new SingletonForm(color, font, size);
        }
        return formInfo;
    }

    public override string ToString()
    {
        return $"Background color:\t\t{BackgroundColor.Name}\n" +
               $"Font type:\t\t{FontType.Name}\n" +
               $"Form Size:\t\t{FormSize.Width}x{FormSize.Height}";
    }
}