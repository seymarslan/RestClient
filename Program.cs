using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace RestclientBasic
{
    class Program
    {
        static void Main(string[] args)
        {

           
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/todos");

            RestRequest request = new RestRequest(Method.GET);
            var content = client.Execute(request);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(content.Content).ToList();
            foreach (var user in users)
            {
                Console.WriteLine("-----------------------------------------------");
                //Console.WriteLine("UserId:" + user.userId);
                //Console.WriteLine("Id:" + user.id);
                
                Console.WriteLine("Title:" + user.title);
                //Console.WriteLine("Completed:" + user.completed);
                users.Any(x => x.completed == true);
                
            }
            
           

            Console.ReadLine();
           
        }
        

    }


}
