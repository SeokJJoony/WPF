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

namespace CanvasPractice
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 속성
        private Point CurrentPoint = new Point();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseDown(object sender,MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                CurrentPoint = e.GetPosition((Canvas)sender);            
        }

        private void Canvas_MouseMove(object sender,MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line line = new Line();

                line.Stroke = SystemColors.WindowFrameBrush;
                
                line.X1 = CurrentPoint.X;
                line.Y1 = CurrentPoint.Y;
                line.X2 = e.GetPosition((Canvas)sender).X;
                line.Y2 = e.GetPosition((Canvas)sender).Y;

                CurrentPoint = e.GetPosition((Canvas)sender);

                canvas1.Children.Add(line);
            }
        }
    }
}
