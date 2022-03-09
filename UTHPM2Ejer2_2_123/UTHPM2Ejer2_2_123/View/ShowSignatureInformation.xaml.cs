using UTHPM2Ejer2_2_123.Controller;
using UTHPM2Ejer2_2_123.Model;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UTHPM2Ejer2_2_123.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowSignatureInformation : ContentPage
    {
        public ShowSignatureInformation(Signatures signatures)
        {
            InitializeComponent();
            name.Text = signatures.name;
            description.Text = signatures.description;
            imageSignature.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(signatures.imageCode)));
        }
    }
}