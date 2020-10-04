using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;


namespace Uppgift2.Views
{
    /// <summary>
    /// Interaction logic for MessageViewControl.xaml
    /// </summary>
    public partial class MessageViewModel : UserControl
    {
        //Hämtar från API
        private readonly string _url = "https://jsonplaceholder.typicode.com/comments";
        private HttpClient _client;
        private HttpResponseMessage _response;

        public MessageViewModel()
        {
            InitializeComponent();
            _client = new HttpClient();

        }

        //När knappen klicks så tar det data från APIn och sätter till varje id som är kopplade till xaml för att kunna visa upp värden
        private async void messageButton_Click(object sender, RoutedEventArgs e)
        {
            _response = await _client.GetAsync(_url);
            //omvandlar om till en objekt från json format
            var output = JsonConvert.DeserializeObject<List<dynamic>>(await _response.Content.ReadAsStringAsync());
            
            //alla id från xaml läggs till med både dynmamiskt och hård kodat värden
            time.Text = "tor 9:55";
            subject.Text = $"{output[0].name}";
            from.Text = $"Loopia Websupport <{output[0].email}>";
            to.Text = "Jan";
            body.Text = $"{output[0].body}";
        }

        private async void messageButton2_Click(object sender, RoutedEventArgs e)
        {
            _response = await _client.GetAsync(_url);          
            var output = JsonConvert.DeserializeObject<List<dynamic>>(await _response.Content.ReadAsStringAsync());

            time.Text = "fre 19:21";
            subject.Text = $"{output[1].name}";
            from.Text = $"Loopia service <{output[1].email}>";
            to.Text = "Jan";
            body.Text = $"{output[1].body}";
        }
    }
}
