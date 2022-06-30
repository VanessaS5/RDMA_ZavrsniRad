using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.ComponentModel;
namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        List<ModelResults> modelList = new List<ModelResults>();
        public ResultPage()
        {
            InitializeComponent();
            GetJsonAsync();
        }

        public async Task GetJsonAsync()
        {
            var uri = new Uri("https://www.idt.mdh.se/personal/plt01/languide/?get=results");
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                string json = content.ToString();
                var jsonObject = JObject.Parse(json);
                var status = jsonObject["error"];
                var message = jsonObject["msg"];
                var data = jsonObject["data"];
                var jsonArray = JArray.Parse(data.ToString());

                foreach (var token in jsonArray)
                {
                    ModelResults model = new ModelResults();
                    string id_user = token["id_user"].ToString();
                    string value1 = token["0"].ToString();
                    string email = token["email"].ToString();
                    string value2 = token["1"].ToString();
                    string create_time = token["create_time"].ToString();
                    string value3 = token["2"].ToString();
                    string id_exercise = token["id_exercise"].ToString();
                    string value4 = token["3"].ToString();
                    string result_percent = token["result_percent"].ToString();
                    string value5 = token["4"].ToString();
                    string result_score = token["result_score"].ToString();
                    string value6 = token["5"].ToString();
                    string result_max = token["result_max"].ToString();
                    string value7 = token["6"].ToString();
                    string skill = token["skill"].ToString();
                    string value8 = token["7"].ToString();
                    string language = token["language"].ToString();
                    string value9 = token["8"].ToString();
                    string result_date = token["result_date"].ToString();
                    string value10 = token["9"].ToString();
                    model.id_user = id_user;
                    model.value1 = value1;
                    model.email = email;
                    model.value2 = value2;
                    model.create_time = create_time;
                    model.value3 = value3;
                    model.id_exercise = id_exercise;
                    model.value4 = value4;
                    model.result_percent = result_percent;
                    model.value5 = value5;
                    model.result_score = result_score;
                    model.value6 = value6;
                    model.result_max = result_max;
                    model.value7 = value7;
                    model.skill = skill;
                    model.value8 = value8;
                    model.language = language;
                    model.value9 = value9;
                    model.result_date = result_date;
                    model.value10 = value10;
                    modelList.Add(model);


                }
                Debug.WriteLine(message);
            }
            testListView.ItemsSource = modelList;

        }

        public async Task GetJsonAsync1()
        {
            var uri = new Uri("https://www.idt.mdh.se/personal/plt01/languide/?get=results");
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                string json = content.ToString();
                var jsonObject = JObject.Parse(json);
                var status = jsonObject["error"];
                var message = jsonObject["msg"];
                var data = jsonObject["data"];
                var jsonArray = JArray.Parse(data.ToString());

                foreach (var token in jsonArray)
                {
                    ModelResults model = new ModelResults();
                    string id_user = token["id_user"].ToString();
                    string value1 = token["0"].ToString();
                    string email = token["email"].ToString();
                    string value2 = token["1"].ToString();
                    string create_time = token["create_time"].ToString();
                    string value3 = token["2"].ToString();
                    string id_exercise = token["id_exercise"].ToString();
                    string value4 = token["3"].ToString();
                    string result_percent = token["result_percent"].ToString();
                    string value5 = token["4"].ToString();
                    string result_score = token["result_score"].ToString();
                    string value6 = token["5"].ToString();
                    string result_max = token["result_max"].ToString();
                    string value7 = token["6"].ToString();
                    string skill = token["skill"].ToString();
                    string value8 = token["7"].ToString();
                    string language = token["language"].ToString();
                    string value9 = token["8"].ToString();
                    string result_date = token["result_date"].ToString();
                    string value10 = token["9"].ToString();
                    model.id_user = id_user;
                    model.value1 = value1;
                    model.email = email;
                    model.value2 = value2;
                    model.create_time = create_time;
                    model.value3 = value3;
                    model.id_exercise = id_exercise;
                    model.value4 = value4;
                    model.result_percent = result_percent;
                    model.value5 = value5;
                    model.result_score = result_score;
                    model.value6 = value6;
                    model.result_max = result_max;
                    model.value7 = value7;
                    model.skill = skill;
                    model.value8 = value8;
                    model.language = language;
                    model.value9 = value9;
                    model.result_date = result_date;
                    model.value10 = value10;
                    modelList.Add(model);


                }
                Debug.WriteLine(message);
            }

            IEnumerable<ModelResults> query = modelList.OrderBy(modelList => modelList.id_user).ToList();
            testListView.ItemsSource = query;

        }

        public async Task GetJsonAsync2()
        {
            var uri = new Uri("https://www.idt.mdh.se/personal/plt01/languide/?get=results");
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                string json = content.ToString();
                var jsonObject = JObject.Parse(json);
                var status = jsonObject["error"];
                var message = jsonObject["msg"];
                var data = jsonObject["data"];
                var jsonArray = JArray.Parse(data.ToString());

                foreach (var token in jsonArray)
                {
                    ModelResults model = new ModelResults();
                    string id_user = token["id_user"].ToString();
                    string value1 = token["0"].ToString();
                    string email = token["email"].ToString();
                    string value2 = token["1"].ToString();
                    string create_time = token["create_time"].ToString();
                    string value3 = token["2"].ToString();
                    string id_exercise = token["id_exercise"].ToString();
                    string value4 = token["3"].ToString();
                    string result_percent = token["result_percent"].ToString();
                    string value5 = token["4"].ToString();
                    string result_score = token["result_score"].ToString();
                    string value6 = token["5"].ToString();
                    string result_max = token["result_max"].ToString();
                    string value7 = token["6"].ToString();
                    string skill = token["skill"].ToString();
                    string value8 = token["7"].ToString();
                    string language = token["language"].ToString();
                    string value9 = token["8"].ToString();
                    string result_date = token["result_date"].ToString();
                    string value10 = token["9"].ToString();
                    model.id_user = id_user;
                    model.value1 = value1;
                    model.email = email;
                    model.value2 = value2;
                    model.create_time = create_time;
                    model.value3 = value3;
                    model.id_exercise = id_exercise;
                    model.value4 = value4;
                    model.result_percent = result_percent;
                    model.value5 = value5;
                    model.result_score = result_score;
                    model.value6 = value6;
                    model.result_max = result_max;
                    model.value7 = value7;
                    model.skill = skill;
                    model.value8 = value8;
                    model.language = language;
                    model.value9 = value9;
                    model.result_date = result_date;
                    model.value10 = value10;
                    modelList.Add(model);


                }
                Debug.WriteLine(message);
            }

            IEnumerable<ModelResults> query = modelList.OrderByDescending(modelList => modelList.id_user).ToList();
            testListView.ItemsSource = query;

        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            GetJsonAsync1();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            GetJsonAsync2();
        }

        private void testListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedResult = testListView.SelectedItem as ModelResults;
            if (SelectedResult != null)
            {
                Navigation.PushAsync(new ResultDetailPage(SelectedResult));
            }
        }


        public void btnShow_Clicked(object sender, EventArgs e)
        {
            if(picekerLanguage.SelectedIndex==-1)
            {
                DisplayAlert("Language:", "Please select language", "OK");
                return;
            }
        
            string language = picekerLanguage.SelectedItem as string;
            var search = modelList.Where(result => result.language == language).ToList();
            testListView.ItemsSource = search;
        }
      
    }
}