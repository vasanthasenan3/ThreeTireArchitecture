using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Shop.BL;
using Shop.DL;
using Shop.Model;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop
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
            Student student = new Student();
            student.Name = txtname.Text;
            student.Age = int.Parse(txtage.Text);
            student.MobileNo = txtmob.Text;
            Userdata userdata = new Userdata();
            userdata.RegisterUser(student);

        }
    }
}