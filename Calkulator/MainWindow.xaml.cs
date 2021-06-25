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
        private void rezultat_TextChanged_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            rezultat.Text = rezvsego.ToSplit();
            rezultat.Text = rezsum.ToSplit();
            rezultat.Text = effstavka.ToSplit();

        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            int cash = Convert.ToInt32(money);
            int day = Convert.ToInt32(days);
            int proc = Convert.ToInt32(procent);
            string proce = proc.ToString();
            string[] numbers = proce.Split(' ', ' ', ' ') ;

            if (cash <= 500000)
            {
                if (day >= 365)
                {
                    MessageBox.Show("Параметры введины неверно");
                }

            }

            proc = proc * 100;

            for (int i = 0; i < 365; i++);
            {
                proc = proc + proc;
            }
            int rezvsego = cash * day * proc;
            int rezsum = rezvsego - cash;
            int effstavka = rezsum / cash / day;
             

        }

        
    }
}
