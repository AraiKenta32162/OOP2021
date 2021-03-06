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

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rand = new Random();
        private int ans;
        private const int Rows = 5;
        private const int Columns = 5;

        public MainWindow()
        {
            InitializeComponent();
        }

        //ボタン配置
        private void SetNumberButton()
        {
            List<Button> buttons = new List<Button>();
            //行
            for (int i = 0; i < Rows; i++)
            {
                gridPanel.RowDefinitions.Add(new RowDefinition());


            }
            //列
            for (int j = 0; j < Columns; j++)
            {
                gridPanel.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    var button = new Button();
                    button.Content = (j + 1) + i * Rows;
                    button.Click += Button_Click;
                    button.Height = Main.Height / Rows;
                    button.Width = Main.Width / Columns;
                    button.FontSize = 30;
                    Grid.SetRow(button, i);//行
                    Grid.SetColumn(button, j);//列
                    buttons.Add(button);
                }
            }
            buttons.ForEach(button => gridPanel.Children.Add(button));
            Main.Height += ansText.Height + 50;
        }
        //ボタンがクリックされた時のイベントハンドラー
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (ans < int.Parse(((Button)sender).Content.ToString()))
            {
                ((Button)sender).Background = Brushes.Gray;
                ansText.Text = "小さい数です";
            }
            else if (ans > int.Parse(((Button)sender).Content.ToString()))
            {
                ((Button)sender).Background = Brushes.Gray;
                ansText.Text = "大きい数です";
            }
            else
            {
                ((Button)sender).Background = Brushes.LawnGreen;
                ansText.Text = "正解です";
            }
        }
        //答えを生成
        private void SetAnswerNumber()
        {
            ans = rand.Next(Rows * Columns) + 1;
        }
        private void Win_Load(object sender, RoutedEventArgs e)
        {
            SetAnswerNumber();
            SetNumberButton();
        }
    }
}