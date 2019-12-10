using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgramacionWeb_ExamenFinal.Models;
using System.Data.SqlClient;

namespace ProgramacionWeb_ExamenFinal.Controllers
{
    public class UserController : Controller
    {

        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        [HttpGet]
        public ActionResult Signup(int id = 0)
        {
            user user = new user();
            return View(user);
        }

        [HttpPost]
        public ActionResult Signup(user user)
        {
            using(UserEntities userEntiti = new UserEntities()){
                try{
                    if(userEntiti.users.Any(x => x.email == user.email))
                    {
                        ViewBag.ErrorMessage = "Ya existe un usuario con ese Email";
                        return View("SignUp", new user());
                    }
                    else
                    {
                        userEntiti.users.Add(user);
                        userEntiti.SaveChanges();
                        ModelState.Clear();
                        ViewBag.SuccessMessage = "Se ha creado el usuario: " + user.email;
                        return View("Login");
                    }
                }catch(Exception exception)
                {
                    ViewBag.ErrorMessage = exception.StackTrace;
                    return View("SignUp",new user());
                }
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(user user)
        {
            connectionString();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from users where email = '" + user.email + "' and password = '" + user.password + "'";
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                return RedirectToAction("Index", "Contacts");
            }
            else {
                connection.Close();
                ViewBag.ErrorMessage = "Usuario no encontrado";
                return View("Login");
            } 
        }

        void connectionString()
        {
            connection.ConnectionString = "data source=LAPTOP-2SVINSSL; database=web_final; integrated security = SSPI;";
        }

        [HttpGet]
        public ActionResult ContactsIndex()
        {
            return RedirectToAction("Index", "Contacts");
        }

        [HttpGet]
        public ActionResult VisitsIndex()
        {
            return RedirectToAction("Index", "Visits");
        }

    }
}