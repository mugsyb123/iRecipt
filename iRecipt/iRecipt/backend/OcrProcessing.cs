using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Linq;

namespace iRecipt.backend
{
    class OcrProcessing
    {

        public async System.Threading.Tasks.Task<String> requestOCRDataAsync(byte[] imageData)
        {
            HttpClient httpClient = new HttpClient();
            
            //Create the form for data storage
            MultipartFormDataContent form = new MultipartFormDataContent();
            
            //Add the key for api usage
            form.Add(new StringContent("53853b5dcd88957"), "apikey"); //Added api key in form data

            //Add image to the form
            form.Add(new ByteArrayContent(imageData, 0, imageData.Length), "image", "image.jpg");

            //Ask for return as table
            form.Add(new StringContent("true"), "isTable");

            //Asks for the response
            HttpResponseMessage response = await httpClient.PostAsync("https://api.ocr.space/Parse/Image", form);

            //Gets content from the response
            string strContent = await response.Content.ReadAsStringAsync();

            Rootobject ocrResult = JsonConvert.DeserializeObject<Rootobject>(strContent);
            String ocrText = "";

            if (ocrResult.OCRExitCode == 1)
            {
                for (int i = 0; i < ocrResult.ParsedResults.Count(); i++)
                {
                    ocrText += ocrResult.ParsedResults[i].ParsedText;
                }
            }
            else
            {
                //MessageBox.Show("ERROR: " + strContent);
            }

            return ocrText;
        }
    }
}
