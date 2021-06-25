using System;
using System.Windows;

namespace Calkulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int cash = Convert.ToInt32(money);
            int day = Convert.ToInt32(days);
            int proc = Convert.ToInt32(procent);
             if (cash > 500000)
            {
                if ( day >365)
                {
                    MessageBox.Show("Параметры введины неверно");
                }
            }
            int numb = proc * 100;
            for (numb = 0; numb < 100; numb++) ;
            {
                numb = numb + numb;
            }

                

        }
    }
}
