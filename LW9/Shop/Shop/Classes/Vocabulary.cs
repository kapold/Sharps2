using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shop.Classes
{
    public class Vocabulary : DependencyObject
    {
        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty PriceProperty;

        static Vocabulary()
        {
            TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Vocabulary));
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            PriceProperty = DependencyProperty.Register("Price", typeof(int), typeof(Vocabulary), metadata,
                            new ValidateValueCallback(ValidateValue));

        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public int Price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
        // Валидация
        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0) // если текущее значение от нуля и выше
                return true;
            return false;
        }
        // Коррекция
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 1000)  // если больше 1000, возвращаем 1000
                return 1000;
            return currentValue; // иначе возвращаем текущее значение
        }
    }
}
