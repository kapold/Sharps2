using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для RoutedEventsWnd.xaml
    /// </summary>
    public partial class RoutedEventsWnd : Window
    {
        public RoutedEventsWnd()
        {
            InitializeComponent();
        }

        private void FirstRoutedBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RoutedTextBox1.Text = RoutedTextBox1.Text + "Sender: " + sender.ToString() + "\n";
            //RoutedTextBox1.Text = RoutedTextBox1.Text + "Source: " + e.Source.ToString() + "\n\n";
        }

        private void SecondRoutedBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RoutedTextBox2.Text = RoutedTextBox2.Text + "Sender: " + sender.ToString() + "\n";
            //RoutedTextBox2.Text = RoutedTextBox2.Text + "Source: " + e.Source.ToString() + "\n\n";
        }
    }

    public abstract class ButtonBase : ContentControl
    {
        // определение событие
        public static readonly RoutedEvent ClickEvent;

        static ButtonBase()
        {
            // регистрация маршрутизированного события
            ButtonBase.ClickEvent = EventManager.RegisterRoutedEvent("Click",
                RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ButtonBase));
            //................................
        }
        // обертка над событием
        public event RoutedEventHandler Click
        {
            add
            {
                // добавление обработчика
                base.AddHandler(ButtonBase.ClickEvent, value);
            }
            remove
            {
                // удаление обработчика
                base.RemoveHandler(ButtonBase.ClickEvent, value);
            }
        }
        // остальное содержимое класса
    }
}
