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
using System.Windows.Shapes;

namespace MeetingRooms
{
    /// Interaction logic for ReservationWindow.xaml
    public partial class ReservationWindow : Window
    {
        public string ReservationName { get; private set; }
        public string ReservationComment { get; private set; }

        public ReservationWindow()
        {
            InitializeComponent();
        }

        private void ReserveButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the values from TextBoxes
            ReservationName = NameTextBox.Text;
            ReservationComment = CommentTextBox.Text;

            // Close the window
            Close();
        }
    }
}