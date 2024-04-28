using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MeteoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region les variables
        public string city = "";

        #endregion
        #region methode main
        public MainWindow()
        {
            InitializeComponent();
            SetHeaderImg();
            SetDay();
           
        }
        #endregion

        #region les methodes
        public void SetDay()
        {
            dateTxt.Content = CapitalizeStr(DateTime.Now.ToString("dddd,dd MMMM yyyy"));
            day1.Content= CapitalizeStr(DateTime.Now.AddDays(1).ToString("dddd,dd MMMM yyyy"),2);
            day2.Content = CapitalizeStr(DateTime.Now.AddDays(2).ToString("dddd,dd MMMM yyyy"), 2);
            day3.Content = CapitalizeStr(DateTime.Now.AddDays(3).ToString("dddd,dd MMMM yyyy"), 2);
        }

        public string CapitalizeStr(string str,int index=0)
        {
            string strFormat = str;
            if(index==0)
            {
            strFormat = char.ToUpper(str[0]) + str.Substring(1);
            }
            else
            {
                strFormat = char.ToUpper(str[0]) + str.Substring(1,index);
            }
            return strFormat;
        }
        public void SetHeaderImg()
        {
            string meteo = "pluie";
            if (meteo == "pluie")
            {
            headerImg.Source = new BitmapImage(new Uri(@"/orageuxPluvieux.jpg", UriKind.Relative));

            }
            else
            {
                //on ne modifie pas l'image
            }
            
        }

        #endregion

        #region gestion des events
        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            city = cityTxt.Text;
            cityTitle.Content = city;
       
        }

        private void btninfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Nor-Eddin LAMRABET", "Développé par ", MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void StackPanel_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        #endregion

    }
}