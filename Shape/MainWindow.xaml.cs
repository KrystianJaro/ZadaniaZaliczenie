using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.ComponentModel;

namespace ProgramZaliczenie
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Shape shape;
        private Point click;
        

        


        public MainWindow()
        {
            InitializeComponent();

        }

        private void DrawingArea_MouseDown(object sender, MouseButtonEventArgs e)
        {
            click = e.GetPosition(DrawingArea);
           
        }

       

        private void Triangle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Quadrangle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPentagon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCircle_Click(object sender, RoutedEventArgs e)
        {
            

         

        }
        private void CreateCircle(object sender, DoWorkEventArgs e)
        {
            shape = new Circle();

           
           
        }
        private void DrawCircle(Circle circle)
        {
            

            
        }
        
        }
    }
            
            
            
            
            
            


