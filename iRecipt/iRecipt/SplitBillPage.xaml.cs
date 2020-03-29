using iRecipt.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iRecipt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplitBillPage : ContentPage
    {
        public SplitBillPage()
        {
            InitializeComponent();

            //Begin 'Loading..'

            //Begin processing and return a list of items

            imageProcess();
            //Stop loading

            //Display the 'Cards' or whatever I end up deciding on            
        }

        public async void imageProcess()
        {
            OcrProcessing process = new OcrProcessing();

            //Spits back the processed receipt's text
            String receiptText = (await process.requestOCRDataAsync(ImageProcessing.getImage()));
        }
    }
}