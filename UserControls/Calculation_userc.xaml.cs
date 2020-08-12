using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WPFbasics.UserControls
{
    /// <summary>
    /// Interaction logic for Calculation_userc.xaml
    /// </summary>
    public partial class Calculation_userc : UserControl
    {
        public Calculation_userc()
        {
            InitializeComponent();
            
        }
        DoubleAnimation db = new DoubleAnimation();
        void Asd()
        {
            
            db.From = 0;
            db.To = 110;
            db.Duration = TimeSpan.FromSeconds(0.5);
            borderTransform.BeginAnimation(TranslateTransform.YProperty, db);
        }
        private void Calculation_Button_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(current_x_get.Text) || String.IsNullOrEmpty(current_y_get.Text) || String.IsNullOrEmpty(current_z_get.Text) || String.IsNullOrEmpty(destination_x_get.Text) || String.IsNullOrEmpty(destination_y_get.Text) || String.IsNullOrEmpty(destination_z_get.Text)))
            {
                var anana = new Message_box();
                anana.ShowDialog();
            }
            else
            {
                int cur_x = Convert.ToInt32(current_x_get.Text);
                int des_x = Convert.ToInt32(destination_x_get.Text);
                int cur_y = Convert.ToInt32(current_y_get.Text);
                int des_y = Convert.ToInt32(destination_y_get.Text);
                int cur_z = Convert.ToInt32(current_z_get.Text);
                int des_z = Convert.ToInt32(destination_z_get.Text);
                double f_brc = Math.Pow(cur_x - des_x, 2);
                double s_brc = Math.Pow(cur_y - des_y, 2);
                double t_brc = Math.Pow(cur_z - des_z, 2);
                double distance = Math.Ceiling(Math.Abs(Math.Sqrt(f_brc + s_brc + t_brc)));
                float time = Convert.ToSingle(distance) / 5.5f;
                int hour = Convert.ToInt32(time) / 3600;
                int min = (Convert.ToInt32(time) - (3600 * hour)) / 60;
                int sec = (Convert.ToInt32(time) - (3600 * hour) - (min * 60));
                string Ns, Ew, Ud = "";
                Distance_result.Text = "" + distance + " Blocks";
                if (cur_z > des_z)
                {
                    Ns = "North";
                }
                else if (cur_z < des_z)
                {
                    Ns = "South";
                }
                else
                {
                    Ns = "";
                }
                if (cur_x > des_x)
                {
                    Ew = "West";
                }
                else if (cur_x < des_x)
                {
                    Ew = "East";
                }
                else
                {
                    Ew = "";
                }
                if (cur_y > des_y)
                {
                    Ud = "Down";
                }
                else if (cur_y < des_y)
                {
                    Ud = "Up";
                }
                Where_result.Text = (Ns + " " + Ew + " " + Ud);
                Estimated_time_result.Text = hour + " : " + min + " : " + sec;
                if (Parent.isok)
                {

                }
            }
        }

        private void Left_TextBoxs_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9-]").IsMatch(e.Text);
        }

        private void Left_TextBoxs_get_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.CaptureMouse();
            textBox.SelectAll();
            textBox.Focus();
        }

        private void current_x_get_GotMouseCapture(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void current_x_get_IsMouseCaptureWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

    }
}
