using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OperationsMath
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Segunda : ContentPage
    {
        public Segunda(int result)
        {
            InitializeComponent();

            Result.Text = Convert.ToString(result);
        }
    }
}