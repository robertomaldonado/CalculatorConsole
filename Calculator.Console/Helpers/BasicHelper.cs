using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Calculator.Console.Helpers
{
    public class BasicHelper
    {
        public string Addition(int num_1, int num_2)
        {
            var response = new WebRequestHandler().Get("http://localhost/Api/Basic/Addition/" + num_1 + "/" + num_2).Result;
            return response;
        }
        public string Subtraction(int num_1, int num_2)
        {
            var response = new WebRequestHandler().Get("http://localhost/Api/Basic/Subtraction/" + num_1 + "/" + num_2).Result;
            return response;
        }
        public string Multiplication(int num_1, int num_2)
        {
            var response = new WebRequestHandler().Get("http://localhost/Api/Basic/Multiplication/" + num_1 + "/" + num_2).Result;
            return response;
        }
        public string Division(int num_1, int num_2)
        {
            var response = new WebRequestHandler().Get("http://localhost/Api/Basic/Division/" + num_1 + "/" + num_2).Result;
            return response;
        }


        /*
        public Course AddCourse(string courseName, string courseDesc)
        {
            var response = new WebRequestHandler().Post("http://localhost/University.WebAPI/Api/Course/AddOrUpdate",
                new Course { Name = courseName, Description = courseDesc }).Result;
            return JsonConvert.DeserializeObject<Course>(response);
        }

        public List<Course> GetCourses()
        {
            return JsonConvert.DeserializeObject<List<Course>>(new WebRequestHandler().Get("http://localhost/University.WebAPI/Api/Course/Get").Result);
        }*/
    }
}