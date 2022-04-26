using Microsoft.AspNetCore.Mvc;
using static GreetApi.Connect;
namespace GreetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HelloWorldController
    {
        
        [HttpGet(Name = "GetHelloWorld")]
        public string Get()
        {
            string res = "";
            var reader = Connect.queryDatabase();
            while (reader.Read())
            {
                res+= $"{reader["BusID"]}  {reader["Registration"]}\n";
            }
            return res;
        }

       /*  [HttpGet]//(Name = "GetCompanyName")
        public string GetCompanyName()
        {
            return "BBD";
        } */
    }

}