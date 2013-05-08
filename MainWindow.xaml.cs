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

//add Install-Package PropertyTools.Wpf 
//add Install-Package OxyPlot.Wpf_NoPCL

namespace WpfOxyPlotRealtimeDemo
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel vm = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = vm;

            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            vm.Update();
            // todo: should not be necessary to refresh
            plot1.RefreshPlot(true);
        }
    }
}
