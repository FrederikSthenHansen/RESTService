using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;
using Newtonsoft.Json;

namespace CalculatorConsumeREst
{
    class DataAdder
    {
        private const string CalculatorUri = "http://localhost:52433/api/Calculator/";

        public static async Task<string> AsyncAdd(Data data)
        {
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine($"Data {data}");
                var jsonString = JsonConvert.SerializeObject(data);
                Console.WriteLine($"JsonString {jsonString}");
                StringContent content=new StringContent(jsonString,Encoding.UTF8,"application/json");
                Console.WriteLine($"content: {content.ToString()}");
                Console.WriteLine($"CalculatorUri: {CalculatorUri}");
                HttpResponseMessage response = await client.PostAsync(CalculatorUri + "Add", content);
                
                string ResponseString= await response.Content.ReadAsStringAsync();
                return ResponseString;
            }
        }
    }
}
