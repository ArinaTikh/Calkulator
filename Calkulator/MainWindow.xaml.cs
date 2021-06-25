using System;
using System.Windows;

namespace Calkulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void money_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void days_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void procent_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
        private void rezult_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
        private void rezult_TextChanged_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            int cash = Convert.ToInt32(money);
            int day = Convert.ToInt32(days);
            int proc = Convert.ToInt32(procent);
            if (cash < 500000)
            {
                if (day > 365)
                {
                    MessageBox.Show("Параметры введины неверно");
                }

            }

            int rezvsego = cash * day * proc;
            int rezsum = rezvsego - cash;

        }

    }
}
