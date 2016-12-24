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

namespace Addition_teacher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new VM();
            DataContext = vm;
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            vm.docalc();
        }

        private void btnReveal_Click(object sender, RoutedEventArgs e)
        {
            vm.Reveal();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            vm.Save();
            MessageBox.Show("File saved");
        }
    }
}
