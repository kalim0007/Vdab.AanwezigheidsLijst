using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Vdab.Aanwezigheidslijst.UWP.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Vdab.Aanwezigheidslijst.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateDocentView : Page
    {
        public readonly CreateDocentViewModel CreateDocentViewModel;
        public readonly ViewDocentViewModel view;


        public CreateDocentView()
        {
            this.InitializeComponent();
            CreateDocentViewModel = new CreateDocentViewModel();
            view = new ViewDocentViewModel();
            view.GetDocent();
        }

       
    }
}
