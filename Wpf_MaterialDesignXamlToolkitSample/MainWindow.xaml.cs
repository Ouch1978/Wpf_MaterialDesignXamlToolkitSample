using MahApps.Metro.Controls;
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

namespace Wpf_MaterialDesignXamlToolkitSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            var messageQueue = snackBar1.MessageQueue;
            var message = txtMessage.Text;
            Task.Factory.StartNew(() => messageQueue.Enqueue(message));
        }
    }
}
