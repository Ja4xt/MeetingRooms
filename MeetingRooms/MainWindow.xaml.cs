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
    /// <summary>
    /// No logic for window xdDddddDDdddd yeah i need to sleep but i also need to complete this so like idk but local edit is broken so like idk uploading once its done and stuff yerrrrr
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Button Nappi;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.MeetingRoom1Selector.Visibility == Visibility.Collapsed)
            {
                this.MeetingRoom1Selector.Visibility = Visibility.Visible;
                this.Meeting_Room_1.Content = "Kokoushuone 1";
            }
            else
            {
                this.MeetingRoom1Selector.Visibility = Visibility.Collapsed;
                this.Meeting_Room_1.Content = "Piilota";
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Logic for meeting room buttons
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

                // Set the DockPanel's position
                ReservationDockPanel.Margin = new Thickness(position.X + clickedButton.ActualWidth, position.Y, 000, 000);

                // Show the DockPanel
                ReservationDockPanel.Visibility = Visibility.Visible;
            }
        }

        // Logic for stack panel buttons
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            if (this.ReservationDockPanel.Visibility == Visibility.Collapsed)
            {
                this.ReservationDockPanel.Visibility = Visibility.Visible;
            }
            else
            {
                this.ReservationDockPanel.Visibility = Visibility.Collapsed;
            }

            if (clickedButton != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFFF0000");
                Nappi.BorderBrush = brush;
            };

            }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
