using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Sql;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using AptitudeTest.Models;

namespace AptitudeTest.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {

        string Baseurl = "http://localhost:51448/";
        string FixApiResponseString(string EmpResponse)
        {
            //EmpResponse = EmpResponse.Replace("\\", string.Empty);
            //EmpResponse = EmpResponse.Trim('"');
            return EmpResponse;
        }
        public async Task<ActionResult> Index()
        {
            List<Users> users = new List<Users>();
            //Teacher t1 = new Teacher();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Users");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {

                    //Storing the response details recieved from web api   

                    users = Res.Content.ReadAsAsync<List<Users>>().Result;

                }
                //returning the employee list to view  

                return View(users);
            }
            //return View();
        }

        public ActionResult Admin()
        {

            return View();
        }

        public ActionResult AddQuestion()
        {

            return View();

        }
        // [HttpPost]
        public ActionResult Adduser()
        {
            //{
            //    using (var client = new HttpClient())
            //    {
            //        client.BaseAddress = new Uri(Baseurl);
            //        client.DefaultRequestHeaders.Clear();


            //        //Define request data format  
            //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            //        //HTTP POST
            //        var postTask = client.PostAsJsonAsync("api/Users", user);
            //        postTask.Wait();

            //        var result = postTask.Result;
            //        if (result.IsSuccessStatusCode)
            //        {
            //            return RedirectToAction("Index");
            //        }
            //    }

            //    ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            //    return View(user);
                return View();
        }
           
    
    public ActionResult Roles()
        {

            return View();
        }

        public ActionResult deleteuser()
        {

            return View();
        }

        public ActionResult login()
        {

            return View();
        }


        public ActionResult Updateuser()
        {

            return View();
        }
        public ActionResult settings()
        {

            return View();
        }
        public ActionResult signup()
        {

            return View();
        }

        public ActionResult test()
        {
         

            return View();
        }

        public ActionResult Teacher()
        {
            
            return View();
        }
        public ActionResult TeacPass()
        {

            return View();
        }
        public ActionResult changeEmail()
        {

            return View();
        }
        public ActionResult changeName()
        {

            return View();
        }
        public ActionResult changePass()
        {

            return View();
        }

    }
}