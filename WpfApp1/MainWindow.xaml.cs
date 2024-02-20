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
using WpfApp1.wind;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string r_n, r_p;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void log_b_Click(object sender, RoutedEventArgs e)
        {
            if ((u_tb.Text == "") && (p_tb.Text == ""))
            {
                MessageBox.Show("Заполните поля!");
            }
            else if ((r_n == u_tb.Text) && (r_p == p_tb.Text)) { 

            Window2 taskWindow = new Window2();
            taskWindow.Show();
                this.Hide();
        }
            else if ((r_n == u_tb.Text) && (r_p == p_tb.Text))
            {

                Window1 taskWindow = new Window1();
                taskWindow.Show();
                this.Hide();
            }
        }

            private void Reg_b_Click(object sender, RoutedEventArgs e)
            {
                if ((u_tb.Text == "") && (p_tb.Text == ""))
                {
                    MessageBox.Show("Заполните поля!");
                }
                else
                {
                    MessageBox.Show("Вы успешно зарегестрированны");
                    r_n = u_tb.Text;
                    r_p = p_tb.Text;
                }

            }

        
    } }
