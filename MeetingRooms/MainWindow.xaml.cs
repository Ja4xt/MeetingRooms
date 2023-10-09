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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

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
    }
}
