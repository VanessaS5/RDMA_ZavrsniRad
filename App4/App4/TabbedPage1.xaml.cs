using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //public partial class TabbedPage1 : TabbedPage
    public partial class TabbedPage1
    {
        public TabbedPage1()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}