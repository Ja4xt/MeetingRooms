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

namespace MeetingRooms
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private Button Nappi;


        // Text transform for meeting room button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.MeetingRoom1Selector.Visibility == Visibility.Collapsed)
            {
                this.MeetingRoom1Selector.Visibility = Visibility.Visible;
                this.Meeting_Room_1.Content = "Piilota";
            }
            else
            {
                this.MeetingRoom1Selector.Visibility = Visibility.Collapsed;
                this.Meeting_Room_1.Content = "Kokoushuone 1";
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Logic for stack panel
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Get the button that was clicked
            Button clickedButton = sender as Button;
            Nappi = clickedButton;

            if (clickedButton != null)
            {
                // Calculate the position of the DockPanel relative to the button
                GeneralTransform transform = clickedButton.TransformToAncestor(this);
                Point position = transform.Transform(new Point(-300, -700));
            }
        }

        // Logic for stack panel buttons
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            // Open the ReservationWindow
            ReservationWindow reservationWindow = new ReservationWindow();
            reservationWindow.Owner = this;
            reservationWindow.ShowDialog();

            // Access reservation details from the ReservationWindow
            string reservationName = reservationWindow.ReservationName;
            string reservationComment = reservationWindow.ReservationComment;

            // Process reservation details as needed
            if (!string.IsNullOrEmpty(reservationName) && !string.IsNullOrEmpty(reservationComment))
            {
                // Update UI coloring
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFFF0000");

                // Update the border color of the reservation button
                clickedButton.BorderBrush = brush;
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
