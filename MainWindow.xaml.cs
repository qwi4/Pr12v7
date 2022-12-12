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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Pr12v7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItEx1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. " +
               "Даны катеты прямоугольного треугольника a и b. " +
               "Найти его гипотенузу c и периметр P.",
               "Задание 1",
               MessageBoxButton.OK,
               MessageBoxImage.Asterisk);
        }

        private void mItEx2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. " +
               "Дано целое число, большее 999. Используя одну операцию деления нацело и " +
               "одну операцию взятия остатка от деления, найти цифру, " +
               "соответствующую разряду сотен в записи этого числа.",
               "Задание 2",
               MessageBoxButton.OK,
               MessageBoxImage.Asterisk);
        }

        private void mItDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Десятов",
               "Разработчик",
               MessageBoxButton.OK,
               MessageBoxImage.Asterisk);
        }

        private void mItExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCalculateEx1_Click(object sender, RoutedEventArgs e)
        {
            txtBoxCathetA.Focus();
            try
            {
                double a = Convert.ToInt32(txtBoxCathetA.Text);
                double b = Convert.ToInt32(txtBoxCathetB.Text);
                double resultHypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                txtBoxResultHypotenuse.Text = Math.Round(resultHypotenuse, 2).ToString();


                double resultPerimetr = a + b + resultHypotenuse;
                txtBoxPerimetrResult.Text = Math.Round(resultPerimetr, 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearEx1_Click(object sender, RoutedEventArgs e)
        {
            txtBoxCathetA.Clear();
            txtBoxCathetB.Clear();
            txtBoxResultHypotenuse.Clear();
            txtBoxPerimetrResult.Clear();

        }

        private void btnCalculateEx2_Click(object sender, RoutedEventArgs e) //ДОРАБОТАТЬ
        {
            txtBoxNumber.Focus();
            try
            {
                int number = Convert.ToInt32(txtBoxNumber.Text);
                if (number > 999)
                {
                    int result = (number % 1000) / 100;
                    txtBoxNumberResult.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Необходимо ввести число, которое больше 999!",
                        "Ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearEx2_Click(object sender, RoutedEventArgs e)
        {
            txtBoxNumber.Clear();
            txtBoxNumberResult.Clear();
        }

        private void txtBoxCathetA_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBoxResultHypotenuse.Clear();
            txtBoxPerimetrResult.Clear();
        }

        private void txtBoxCathetB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBoxResultHypotenuse.Clear();
            txtBoxPerimetrResult.Clear();
        }

        private void txtBoxNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBoxNumberResult.Clear();
        }

        DispatcherTimer timer;

        /// <summary>
        /// Добавление таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded (object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        /// <summary>
        /// Создание события таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            tbWatch.Text = dateTime.ToString("hh:mm:ss");
            tbDate.Text = dateTime.ToString("dd.MM.yyyy");
        }
    }
}
