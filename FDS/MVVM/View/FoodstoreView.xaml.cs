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

namespace FDS.MVVM.View
{
    /// <summary>
    /// Interaction logic for FoodstoreView.xaml
    /// </summary>
    public partial class FoodstoreView : UserControl
    {
        public FoodstoreView()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            storename01.Visibility = Visibility.Collapsed;
            upstorename01.Visibility = Visibility.Visible;
            storelocation01.Visibility = Visibility.Collapsed;
            upstorelocation01.Visibility = Visibility.Visible;
            storecap01.Visibility = Visibility.Collapsed;
            upstorecap01.Visibility = Visibility.Visible;
            submitbtn.Visibility = Visibility.Collapsed;
            updatebtn.Visibility = Visibility.Visible;
                            
        }
    }
}
