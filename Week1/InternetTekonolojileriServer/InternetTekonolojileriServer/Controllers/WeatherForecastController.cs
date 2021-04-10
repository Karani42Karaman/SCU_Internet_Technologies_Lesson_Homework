using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetTekonolojileriServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        public WeatherForecastController()
        {
        }



        [HttpPost("Employe")]
        public IActionResult Employe([FromForm]EmployeModel employeModel)
        {
            Console.WriteLine(JsonConvert.SerializeObject(employeModel));
            return new ObjectResult(employeModel);
        }



        [HttpPost("ScuSurvey")]
        public IActionResult ScuSurvey([FromForm] ScuSurveyModel surveyModel)
        {
            Console.WriteLine(JsonConvert.SerializeObject(surveyModel));
            return new ObjectResult(surveyModel);
        }








    }




    public class EmployeModel
    {
        public string name { get; set; }
        public string company_name { get; set; }
        public string departman_name { get; set; }
        public string phone { get; set; }
        public string mail     { get; set; }
        public string row_one { get; set; }
        public string row_two { get; set; }
        public string row_three { get; set; }
        public string row_four { get; set; }
        public string row_five { get; set; }
        public string row_six { get; set; }
        public string row_seven { get; set; }
        public string mesaj { get; set; }
    }


    public class ScuSurveyModel
    {
        public string user_name { get; set; }
        public string user_tc { get; set; }
        public string selected_datetime { get; set; }
        public string user_table_number { get; set; }
        public string row_two { get; set; }
        public string vtmin { get; set; }
        public string row_three { get; set; }
        public string vtmyesno { get; set; }
        public string row_three1 { get; set; }
        public string row_four { get; set; }
        public string ymin { get; set; }
        public string row_five { get; set; }
        public string ymyesno { get; set; }
        public string row_six { get; set; }
        public string row_seven { get; set; }
        public string ssiin { get; set; }
        public string row_eigth { get; set; }
        public string ssiyesno { get; set; }
        public string row_nine { get; set; }
        public string row_ten { get; set; }
        public string gpin { get; set; }
        public string row_eleven { get; set; }
        public string gryesno { get; set; }
        public string row_twelve { get; set; }
        public string row_thirteen { get; set; }
        public string algin { get; set; }
        public string row_fourteen { get; set; }
        public string alyesno { get; set; }
        public string row_fifteen { get; set; }
        public string row_sixteen { get; set; }
        public string itin { get; set; }
        public string row_seventeen { get; set; }
        public string ityesno { get; set; }
        public string row_eighteen { get; set; }
    }



}
