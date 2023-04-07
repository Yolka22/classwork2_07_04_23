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
using static System.Net.Mime.MediaTypeNames;

namespace classwork2_07_04_23
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

        bool caps_lock_on = false;

        static string Caps_Check(string input, bool caps_lock_on)
        {

            if (caps_lock_on)
            {
                return input.ToUpper();
            }
            else return input;

        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_1.Content;
        }
        private void Button_apostrof_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_apostrof.Content;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_2.Content;
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_3.Content;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_4.Content;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_5.Content;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_6.Content;
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_7.Content;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_8.Content;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_9.Content;
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_0.Content;
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_minus.Content;
        }

        private void Button_equals_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_equals.Content;
        }

        private void Button_backspace_Click(object sender, RoutedEventArgs e)
        {

            if (main_textbox.Text!="") {

                main_textbox.Text = main_textbox.Text.Remove(main_textbox.Text.Length - 1, 1);

            }
            
        }









        private void Button_tab_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += "    ";
        }

        private void Button_q_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_q.Content as string, caps_lock_on);
        }

        private void Button_w_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_w.Content as string, caps_lock_on);
        }

        private void Button_e_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_e.Content as string, caps_lock_on);
        }

        private void Button_r_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_r.Content as string, caps_lock_on);
        }

        private void Button_t_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_t.Content as string, caps_lock_on);
        }

        private void Button_y_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_y.Content as string, caps_lock_on);
        }

        private void Button_u_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_u.Content as string, caps_lock_on);
        }

        private void Button_i_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_i.Content as string, caps_lock_on);
        }

        private void Button_o_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_o.Content as string, caps_lock_on);
        }

        private void Button_p_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_p.Content as string, caps_lock_on);
        }

        private void Button_square_left_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_square_left.Content as string, caps_lock_on);
        }

        private void Button_square_right_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_square_right.Content as string, caps_lock_on);
        }

        private void Button_slash_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_slash.Content;
        }







        private void Button_Caps_Lock_Click(object sender, RoutedEventArgs e)
        {
           

            if (caps_lock_on)
            {
                Button_Caps_Lock.Background = new SolidColorBrush(Colors.LightGray);
                caps_lock_on = false;

            }
            else
            {
                Button_Caps_Lock.Background = new SolidColorBrush(Colors.IndianRed);
                caps_lock_on = true;
            }


        }


        private void Button_a_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_a.Content as string, caps_lock_on);
        }

        private void Button_s_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_s.Content as string, caps_lock_on);
        }

        private void Button_d_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_d.Content as string, caps_lock_on);
        }

        private void Button_f_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_f.Content as string, caps_lock_on);
        }

        private void Button_g_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_g.Content as string, caps_lock_on);
        }

        private void Button_h_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_h.Content as string, caps_lock_on);
        }

        private void Button_j_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_j.Content as string, caps_lock_on);
        }

        private void Button_k_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_k.Content as string, caps_lock_on);
        }

        private void Button_l_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_l.Content as string, caps_lock_on);
        }

        private void Button_dot_coma_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_dot_coma.Content as string, caps_lock_on);
        }
        private void Button_enter_click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += "\n";
        }





        private void Button_z_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_z.Content as string, caps_lock_on);
        }

        private void Button_x_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_x.Content as string, caps_lock_on);
        }

        private void Button_c_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_c.Content as string, caps_lock_on);
        }

        private void Button_v_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_v.Content as string, caps_lock_on);
        }

        private void Button_b_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_b.Content as string, caps_lock_on);
        }

        private void Button_n_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_n.Content as string, caps_lock_on);
        }

        private void Button_m_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += Caps_Check(this.Button_m.Content as string, caps_lock_on);
        }

        private void Button_coma_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_coma.Content;
        }

        private void Button_dot_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_dot.Content;
        }

        private void Button_back_slash_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += this.Button_back_slash.Content;
        }

        private void Button_space_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += " ";
        }
    }
}
