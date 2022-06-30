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
    public partial class UserPage : ContentPage
    {
        List<ModelUsers> modelList = new List<ModelUsers>();
        public UserPage()
        {
            InitializeComponent();

            GetJsonAsync();
        }

        public async Task GetJsonAsync()
        {
            var uri = new Uri("https://www.idt.mdh.se/personal/plt01/languide/?get=users");
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                string json = content.ToString();
                var jsonObject = JObject.Parse(json);
                var status = jsonObject["error"];
                var message = jsonObject["msg"];
                var data = jsonObject["data"];
                var jsonArray = JArray.Parse(data.ToString());

                foreach(var token in jsonArray)
                {
                    ModelUsers model = new ModelUsers();
                    string id_user = token["id_user"].ToString();
                    string value1 = token["0"].ToString();
                    string email = token["email"].ToString();
                    string value2 = token["1"].ToString();
                    string create_time = token["create_time"].ToString();
                    string value3 = token["2"].ToString();
                    model.id_user = id_user;
                    model.value1 = value1;
                    model.email = email;
                    model.value2 = value2;
                    model.create_time = create_time;
                    model.value3 = value3;
                    modelList.Add(model);


                }
                Debug.WriteLine(message);
            }
            testListView.ItemsSource = modelList;

        }

        public async Task GetJsonAsync1()
        {
            var uri = new Uri("https://www.idt.mdh.se/personal/plt01/languide/?get=users");
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
                    ModelUsers model = new ModelUsers();
                    string id_user = token["id_user"].ToString();
                    string value1 = token["0"].ToString();
                    string email = token["email"].ToString();
                    string value2 = token["1"].ToString();
                    string create_time = token["create_time"].ToString();
                    string value3 = token["2"].ToString();
                    model.id_user = id_user;
                    model.value1 = value1;
                    model.email = email;
                    model.value2 = value2;
                    model.create_time = create_time;
                    model.value3 = value3;
                    modelList.Add(model);


                }
                Debug.WriteLine(message);
            }

            var sorting = modelList.OrderBy(model => model.id_user).ToList();
            testListView.ItemsSource = sorting;


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
                    ModelUsers model = new ModelUsers();

                    string id_user = token["id_user"].ToString();
                    string value1 = token["0"].ToString();
                    string email = token["email"].ToString();
                    string value2 = token["1"].ToString();
                    string create_time = token["create_time"].ToString();
                    string value3 = token["2"].ToString();
                    model.id_user = id_user;
                    model.value1 = value1;
                    model.email = email;
                    model.value2 = value2;
                    model.create_time = create_time;
                    model.value3 = value3;
                    modelList.Add(model);

                }
                Debug.WriteLine(message);
            }

            var sorting = modelList.OrderByDescending(model => model.id_user).ToList();
            testListView.ItemsSource = sorting;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            GetJsonAsync1();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            GetJsonAsync2();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var search = modelList.Where(user=>user.id_user.StartsWith(e.NewTextValue)).ToList();
            testListView.ItemsSource = search;
        }

        private void SearchBar_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var search = modelList.Where(user => user.email.StartsWith(e.NewTextValue)).ToList();
            testListView.ItemsSource = search;
        }
    }

        
    
}