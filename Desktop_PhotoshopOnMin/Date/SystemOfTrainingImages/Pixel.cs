using System;
using System.Windows;

namespace Desktop_PhotoshopOnMin.Date.SystemOfTrainingImages
{
    public struct Pixel
    {
        public int R
        {
            get => R;

            set
            {
                //  Проверка на коректность ввода.
                //  Если метод возратил truu, то тогда присваеваем value,
                //  если false, тогда присваеваем предыдущие значение, 
                //  но перед этим проверим пустая ли переменная.
                //  Если да, то тогда будет в конечном итоге присвоено 0, если нет,
                //  То как и хотели присвоем предыдущие значение.
                R = ValueCheck(value) == true ? value : R = R.ToString() == null ? 0 : R;
            }
        }

        public int G
        {
            get => G;

            set
            {
                // Описание аналагично с свойством "R"
                G = ValueCheck(value) == true ? value : G = G.ToString() == null ? 0 : G;
            }
        }

        public int B
        {
            get => B;

            set
            {
                // Описание аналагично с свойством "R"
                B = ValueCheck(value) == true ? value : B = B.ToString() == null ? 0 : B;
            }
        }

        private bool ValueCheck(double q)
        {
            if (q < 0 || q >= 0.255)
            {
                NotificationValueIncorrect();

                return false;
            }
            else
            {
                return true;
            }
        }
        private void NotificationValueIncorrect()
        {
            MessageBox.Show("Error", "Value incorrect", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
