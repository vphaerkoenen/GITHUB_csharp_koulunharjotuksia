using System;
using System.ComponentModel;
using Windows.Data.Json;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Net;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwpharjoitukset3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class harjoitus3_1a : Page, INotifyPropertyChanged
    {

        public harjoitus3_1a()
        {
            PassWord = "";
            UselessFact = null;
            this.InitializeComponent();

        }


        public string PassWord { get; set; }
        public string UselessFact { get; set; }
        public string propertyName = "";//funktiot antavat tähän oman arvonsa jota käytetään OnPropertyChanged-funktiossa



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
        }


        //C# - Salasanan tuottaminen (data binding tehtävä 1)
        //Apumetodi, jolla voi tuottaa salasanoja:
        // lähde:
        // https://monkelite.com/how-to-generate-a-random-password-using-csharp-and-dotnet-core/

        public string Create_PassWord(int length)
        {
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();
            // Select one random character at a time from the string  
            // and create an array of chars  
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            PassWord = new string(chars);
            propertyName = "PassWord";
            OnPropertyChanged(propertyName);
            return PassWord;
        }



        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Create_PassWord(10);
        }


        private async void UselessFactButton_Click(object sender, RoutedEventArgs e)//tämä funktio haki aiemmin
        {/////////////////////////////////////////////////////////////////////////// turhan faktan rajapinnasta
         /////////////////////////////////////////////////////////////////////////// mutta sen toiminnan loputtua   
            try///////////////////////////////////////////////////////////////////// haetaan Chuck Norris-aiheinen
                {/////////////////////////////////////////////////////////////////// juttu
                 
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api.chucknorris.io/jokes/random");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                System.IO.Stream dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                JsonObject obj = JsonObject.Parse(responseFromServer);
                string objValue = obj.GetNamedValue("value").ToString();

                ContentDialog contentDialog = new ContentDialog()
                {
                    Content = objValue.ToString(),
                    CloseButtonText = "OK"
                };
                _ = contentDialog.ShowAsync();
                
             }
            catch
                {
                    ContentDialog message = new ContentDialog()
                    {
                        Title = "Alert!",
                        Content = "Sisältöä ei löydy",
                        CloseButtonText = "OK"
                    };
                    _ = message.ShowAsync();
                
            }
        }
    }
}
