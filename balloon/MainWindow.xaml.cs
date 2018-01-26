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

namespace balloon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private balloon0 balloon1;


        public MainWindow()
        {
            InitializeComponent();

            balloon1 = new balloon0();
            balloon1.DisplayOn(MijnCanvas);
        }

        private void MijnKnop1_Click(object sender, RoutedEventArgs e)
        {
            balloon1.MoveRight(10);
        }

        private void MijnKnop2_Click(object sender, RoutedEventArgs e)
        {
         
            balloon1.ChangeSize(10);
        }
    }

    
}
