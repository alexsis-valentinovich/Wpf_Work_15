using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Work_15
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            docMy.ClearValue(FlowDocumentPageViewer.DocumentProperty);
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (FileStream fileS = File.Open("1.xaml", FileMode.Create))
            {
                XamlWriter.Save(docMy.Document, fileS);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (FileStream fileS = File.Open("1.xaml", FileMode.Open))
            {
                docMy.Document= XamlReader.Load(fileS) as FlowDocument;
            }
        }
    }
}
