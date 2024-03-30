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

namespace WpfKeysMousesEventsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x, y;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            //txtView.Text += e.Key.ToString() + "\n";
        }

        private void txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //int value;
            //if (!Int32.TryParse(e.Text, out value))
            //    e.Handled = true;
        }

        private void txt_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            (e.Source as TextBox).Text = e.Delta.ToString();
        }

        private void txtSource_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(txtSource, txtSource.Text, DragDropEffects.Copy);
        }

        private void btnDest_Drop(object sender, DragEventArgs e)
        {
            btnDest.Content = e.Data.GetData(DataFormats.Text);
        }

        private void btn_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Left && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
                x -= 10;
            if (e.Key == Key.Right)
                x += 10;
            if (e.Key == Key.Up)
                y -= 10;
            if (e.Key == Key.Down)
                y += 10;

            //Canvas.SetLeft(btn, x);
            //Canvas.SetTop(btn, y);
        }
    }
}