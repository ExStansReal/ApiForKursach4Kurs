using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DBController : ControllerBase
    {
        protected string ConnectionString { get; set; } = @"Data Source=DESKTOP-PSEJFIA\SQLEXPRESS;Integrated Security=True";
        //
        //
        //EMPLOYEE
        //
        //
        [HttpGet]
        [Route("GetEmployee")]
        public IEnumerable<Employee> GetEmployee()
        {
            string command = "USE HelperDataBase " +
                 "select* from Employee";
            List<Employee> employes = new List<Employee>();
            using (System.Data.SqlClient.SqlConnection conn
                = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = reader.GetInt32(0);
                    employee.Surname = reader.GetString(1);
                    employee.Name = reader.GetString(2);
                    try
                    {
                        employee.Patronymic = reader.GetString(3);
                    }
                    catch
                    {
                        employee.Patronymic = "";
                    }
                    employee.Series = reader.GetString(4);
                    employee.Number = reader.GetString(5);
                    employee.Date_of_birth = reader.GetDateTime(6);
                    employee.Education = reader.GetString(7);
                    try
                    {
                        employee.email = reader.GetString(8);
                    }
                    catch
                    {
                        employee.email = "";
                    }
                    try
                    {
                        employee.dolztost = reader.GetString(9);
                    }
                    catch
                    {
                        employee.dolztost = "";
                    }
                    employes.Add(employee);
                }
                reader.Close();
                conn.Close();
                return employes;
            }
        }
        [HttpGet]
        [Route("GetEmployee/{id}")]
        public IEnumerable<Employee> GetEmployee(int id)
        {
            string command = "USE HelperDataBase " +
                $"select* from Employee WHERE ID_Employee = {id}";
            List<Employee> employes = new List<Employee>();
            using (System.Data.SqlClient.SqlConnection conn
               = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = reader.GetInt32(0);
                    employee.Surname = reader.GetString(1);
                    employee.Name = reader.GetString(2);
                    try
                    {
                        employee.Patronymic = reader.GetString(3);
                    }
                    catch
                    {
                        employee.Patronymic = "";
                    }
                    employee.Series = reader.GetString(4);
                    employee.Number = reader.GetString(5);
                    employee.Date_of_birth = reader.GetDateTime(6);
                    employee.Education = reader.GetString(7);
                    try
                    {
                        employee.email = reader.GetString(8);
                    }
                    catch
                    {
                        employee.email = "";
                    }
                    try
                    {
                        employee.dolztost = reader.GetString(9);
                    }
                    catch
                    {
                        employee.dolztost = "";
                    }
                        employes.Add(employee);
                }
                reader.Close();
                conn.Close();
                return employes;
            }
        }
        //
        //
        //CELL
        //
        //

        [HttpGet]
        [Route("GetCell")]
        public IEnumerable<Cell> GetCell()
        {
            string command = "USE HelperDataBase " +
                "select* from Cell";
            List<Cell> list = new List<Cell>();
            using (SqlConnection conn
               = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Cell thing = new Cell();
                    thing.Id = reader.GetInt32(0);
                    thing.Number = reader.GetInt32(1);
                    try
                    {
                        thing.Device_ID = reader.GetInt32(2);
                    }
                    catch
                    {
                        thing.Device_ID = null;
                    }
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetCell/{id}")]
        public IEnumerable<Cell> GetCell(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from Cell WHERE ID_Cell = {id}";
            List<Cell> list = new List<Cell>();
            using (SqlConnection conn
               = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Cell thing = new Cell();
                    thing.Id = reader.GetInt32(0);
                    thing.Number = reader.GetInt32(1);
                    try
                    {
                        thing.Device_ID = reader.GetInt32(2);
                    }
                    catch
                    {
                        thing.Device_ID = null;
                    }
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        //
        //
        //ContactInfrotmation
        //
        //

        [HttpGet]
        [Route("GetContactInformation")]
        public IEnumerable<ContactInformation> GetContactInformation()
        {
            string command = "USE HelperDataBase " +
                "select* from Contact_Information";
            List<ContactInformation> list = new List<ContactInformation>();
            using (SqlConnection conn
                 = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    ContactInformation thing = new ContactInformation();
                    thing.Id = reader.GetInt32(0);
                    thing.Link_to_VK = reader.GetString(1);
                    thing.Link_to_Telegram = reader.GetString(2);
                    thing.Phone = reader.GetString(3);
                    thing.Email = reader.GetString(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetContactInformation/{id}")]
        public IEnumerable<ContactInformation> GetContactInformation(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from Contact_Information WHERE ID_Contact_Information = {id}";
            List<ContactInformation> list = new List<ContactInformation>();
            using (SqlConnection conn
                = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    ContactInformation thing = new ContactInformation();
                    thing.Id = reader.GetInt32(0);
                    thing.Link_to_VK = reader.GetString(1);
                    thing.Link_to_Telegram = reader.GetString(2);
                    thing.Phone = reader.GetString(3);
                    thing.Email = reader.GetString(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        //
        //
        //Device
        //
        //

        [HttpGet]
        [Route("GetDevice")]
        public IEnumerable<Device> GetDevice()
        {
            string command = "USE HelperDataBase " +
                "select* from Device";
            List<Device> list = new List<Device>();
            using (SqlConnection conn
                 = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Device thing = new Device();
                    thing.Id = reader.GetInt32(3);
                    thing.Name = reader.GetString(0);
                    thing.Appointment = reader.GetString(1);
                    thing.Number = reader.GetInt32(2);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetDevice/{id}")]
        public IEnumerable<Device> GetDevice(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from Device WHERE ID_Device = {id}";
            List<Device> list = new List<Device>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Device thing = new Device();
                    thing.Id = reader.GetInt32(3);
                    thing.Name = reader.GetString(0);
                    thing.Appointment = reader.GetString(1);
                    thing.Number = reader.GetInt32(2);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        //
        //
        //Feedback
        //
        //

        [HttpGet]
        [Route("GetFeedback")]
        public IEnumerable<Feedback> GetFeedback()
        {
            string command = "USE HelperDataBase " +
                "select * from Feedback";
            List<Feedback> list = new List<Feedback>();
            using (SqlConnection conn
                = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Feedback thing = new Feedback();
                    thing.Id = reader.GetInt32(0);
                    thing.Taken_order_Id = reader.GetInt32(1);
                    thing.Feedback_from_klient = reader.GetString(2);
                    thing.Feedback_from_employee = reader.GetString(3);
                    thing.Deleted = reader.GetInt32(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetFeedback/{id}")]
        public IEnumerable<Feedback> GetFeedback(int id)
        {
            string command = "USE HelperDataBase " +
               $"select * from Feedback WHERE ID_Feedback = {id}";
            List<Feedback> list = new List<Feedback>();
            using (SqlConnection conn
               = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Feedback thing = new Feedback();
                    thing.Id = reader.GetInt32(0);
                    thing.Taken_order_Id = reader.GetInt32(1);
                    thing.Feedback_from_klient = reader.GetString(2);
                    thing.Feedback_from_employee = reader.GetString(3);
                    thing.Deleted = reader.GetInt32(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }

        //
        //
        //Klient
        //
        //

        [HttpGet]
        [Route("GetKlient")]
        public IEnumerable<Klient> GetKlient()
        {
            string command = "USE HelperDataBase " +
                "select * from Klient";
            List<Klient> list = new List<Klient>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Klient thing = new Klient();
                    thing.Id = reader.GetInt32(0);
                    thing.Contact_information_Id = reader.GetInt32(1);
                    thing.Login = reader.GetString(2);
                    thing.Password = reader.GetString(3);
                    thing.Permition = reader.GetInt32(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetKlient/{id}")]
        public IEnumerable<Klient> GetKlient(int id)
        {
            string command = "USE HelperDataBase " +
               $"select * from Klient WHERE ID_Klient = {id}";
            List<Klient> list = new List<Klient>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Klient thing = new Klient();
                    thing.Id = reader.GetInt32(0);
                    thing.Contact_information_Id = reader.GetInt32(1);
                    thing.Login = reader.GetString(2);
                    thing.Password = reader.GetString(3);
                    thing.Permition = reader.GetInt32(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }


        //
        //
        //Order
        //
        //

        [HttpGet]
        [Route("GetOrder")]
        public IEnumerable<Order> GetOrder()
        {
            string command = "USE HelperDataBase " +
                "select * from [dbo].[Order]";
            List<Order> list = new List<Order>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Order thing = new Order();
                    thing.Id = reader.GetInt32(0);
                    thing.Type_Order_Id = reader.GetInt32(1);
                    thing.Klient_Id = reader.GetInt32(2);
                    thing.Description = reader.GetString(3);
                    thing.Payment = reader.GetInt32(4);
                    if (thing.Description.Length > 20)
                    {
                        thing.Name = thing.Description.Substring(0, 20);
                        thing.Name += "..";
                    }
                    else
                        thing.Name = thing.Description;
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetOrder/{id}")]
        public IEnumerable<Order> GetOrder(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from [dbo].[Order] WHERE ID_Order = {id}";
            List<Order> list = new List<Order>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Order thing = new Order();
                    thing.Id = reader.GetInt32(0);
                    thing.Type_Order_Id = reader.GetInt32(1);
                    thing.Klient_Id = reader.GetInt32(2);
                    thing.Description = reader.GetString(3);
                    thing.Payment = reader.GetInt32(4);
                    if (thing.Description.Length > 20)
                    {
                        thing.Name = thing.Description.Substring(0, 20);
                        thing.Name += "..";
                    }
                    else
                        thing.Name = thing.Description;
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }

        //
        //
        //Personal_card
        //
        //

        [HttpGet]
        [Route("GetPersonal_card")]
        public IEnumerable<Personal_card> GetPersonal_card()
        {
            string command = "USE HelperDataBase " +
                "select * from [dbo].[Personal_card]";
            List<Personal_card> list = new List<Personal_card>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Personal_card thing = new Personal_card();
                    thing.Id = reader.GetInt32(0);
                    thing.Login = reader.GetString(1);
                    thing.Password = reader.GetString(2);
                    thing.Acsess = reader.GetInt32(3);
                    thing.Post_ID = reader.GetInt32(4);
                    thing.Employee_ID = reader.GetInt32(5);
                    try
                    {
                        thing.Contact_information_Id = reader.GetInt32(6);
                    }
                    catch
                    {

                    }
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetPersonal_card/{id}")]
        public IEnumerable<Personal_card> GetPersonal_card(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from [dbo].[Personal_card] WHERE ID_Personal_card = {id}";
            List<Personal_card> list = new List<Personal_card>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Personal_card thing = new Personal_card();
                    thing.Id = reader.GetInt32(0);
                    thing.Id = reader.GetInt32(0);
                    thing.Login = reader.GetString(1);
                    thing.Password = reader.GetString(2);
                    thing.Acsess = reader.GetInt32(3);
                    thing.Post_ID = reader.GetInt32(4);
                    thing.Employee_ID = reader.GetInt32(5);
                    try
                    {
                        thing.Contact_information_Id = reader.GetInt32(6);
                    }
                    catch
                    {

                    }
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }

        //
        //
        //Post
        //
        //

        [HttpGet]
        [Route("GetPost")]
        public IEnumerable<Post> GetPost()
        {
            string command = "USE HelperDataBase " +
                "select * from [dbo].[Post]";
            List<Post> list = new List<Post>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Post thing = new Post();
                    thing.Id = reader.GetInt32(0);
                    thing.Name = reader.GetString(1);
                    thing.Salary = reader.GetString(2);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetPost/{id}")]
        public IEnumerable<Post> GetPost(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from [dbo].[Post] WHERE ID_Post = {id}";
            List<Post> list = new List<Post>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Post thing = new Post();
                    thing.Id = reader.GetInt32(0);
                    thing.Name = reader.GetString(1);
                    thing.Salary = reader.GetString(2);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }

    

        //
        //
        //Sklad
        //
        //

        [HttpGet]
        [Route("GetSklad")]
        public IEnumerable<Storage> GetStorage()
        {
            string command = "USE HelperDataBase " +
                "select * from [dbo].[Storage]";
            List<Storage> list = new List<Storage>();
            using (SqlConnection conn
                = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Storage thing = new Storage();
                    thing.Id = reader.GetInt32(0);
                    try
                    {
                        thing.Cell_Id = reader.GetInt32(1);
                    }
                    catch
                    {
                        thing.Cell_Id = null;
                    }
                    thing.Home = reader.GetString(2);
                    thing.Body = reader.GetString(3);
                    thing.Street = reader.GetString(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetSklad/{id}")]
        public IEnumerable<Storage> GetStorage(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from [dbo].[Storage] WHERE ID_Storage = {id}";
            List<Storage> list = new List<Storage>();
            using (SqlConnection conn
                = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Storage thing = new Storage();
                    thing.Id = reader.GetInt32(0);
                    try
                    {
                        thing.Cell_Id = reader.GetInt32(1);
                    }
                    catch
                    {
                        thing.Cell_Id = null;
                    }
                    thing.Home = reader.GetString(2);
                    thing.Body = reader.GetString(3);
                    thing.Street = reader.GetString(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }

        //
        //
        //Statistic
        //
        //

        [HttpGet]
        [Route("GetStatistic")]
        public IEnumerable<Statistic> GetStatistic()
        {
            string command = "USE HelperDataBase " +
                "select * from [dbo].[Statistic]";
            List<Statistic> list = new List<Statistic>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Statistic thing = new Statistic();
                    thing.Id = reader.GetInt32(0);
                    thing.Taken_order_Id = reader.GetInt32(1);
                    thing.Date = reader.GetDateTime(2);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetStatistic/{id}")]
        public IEnumerable<Statistic> GetStatistic(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from [dbo].[Statistic] WHERE ID_Statistic = {id}";
            List<Statistic> list = new List<Statistic>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Statistic thing = new Statistic();
                    thing.Id = reader.GetInt32(0);
                    thing.Taken_order_Id = reader.GetInt32(1);
                    thing.Date = reader.GetDateTime(2);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }

        //
        //
        //Taken_Device
        //
        //

        [HttpGet]
        [Route("GetTaken_Device")]
        public IEnumerable<Taken_Device> GetTaken_Device()
        {
            string command = "USE HelperDataBase " +
                "select * from [dbo].[Taken_Device]";
            List<Taken_Device> list = new List<Taken_Device>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Taken_Device thing = new Taken_Device();
                    thing.Id = reader.GetInt32(0);
                    thing.Cell_Id = reader.GetInt32(1);
                    thing.Personal_Card_Id = reader.GetInt32(2);
                    thing.Date = reader.GetDateTime(3);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetTaken_Device/{id}")]
        public IEnumerable<Taken_Device> GetTaken_Device(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from [dbo].[Taken_Device] WHERE ID_Taken_Device = {id}";
            List<Taken_Device> list = new List<Taken_Device>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Taken_Device thing = new Taken_Device();
                    thing.Id = reader.GetInt32(0);
                    thing.Cell_Id = reader.GetInt32(1);
                    thing.Personal_Card_Id = reader.GetInt32(2);
                    thing.Date = reader.GetDateTime(3);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }

        //
        //
        //Taken_Order
        //
        //

        [HttpGet]
        [Route("GetTaken_Order")]
        public IEnumerable<Taken_Order> GetTaken_Order()
        {
            string command = "USE HelperDataBase " +
                "select * from [dbo].[Taken_Order]";
            List<Taken_Order> list = new List<Taken_Order>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Taken_Order thing = new Taken_Order();
                    thing.Id = reader.GetInt32(0);
                    thing.Order_Id = reader.GetInt32(1);
                    thing.Personal_Card_Id = reader.GetInt32(2);
                    thing.Date = reader.GetDateTime(3);
                    thing.Status = reader.GetString(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetTaken_Order/{id}")]
        public IEnumerable<Taken_Order> GetTaken_Order(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from [dbo].[Taken_Order] WHERE ID_Taken_Order = {id}";
            List<Taken_Order> list = new List<Taken_Order>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Taken_Order thing = new Taken_Order();
                    thing.Id = reader.GetInt32(0);
                    thing.Order_Id = reader.GetInt32(1);
                    thing.Personal_Card_Id = reader.GetInt32(2);
                    thing.Date = reader.GetDateTime(3);
                    thing.Status = reader.GetString(4);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }

        //
        //
        //Type_Order
        //
        //

        [HttpGet]
        [Route("GetType_Order")]
        public IEnumerable<Type_Order> GetType_Order()
        {
            string command = "USE HelperDataBase " +
                "select * from [dbo].[Type_Order]";
            List<Type_Order> list = new List<Type_Order>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Type_Order thing = new Type_Order();
                    thing.Id = reader.GetInt32(0);
                    thing.Name = reader.GetString(1);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
        [HttpGet]
        [Route("GetType_Order/{id}")]
        public IEnumerable<Type_Order> GetType_Order(int id)
        {
            string command = "USE HelperDataBase " +
               $"select* from [dbo].[Type_Order] WHERE ID_Type_Order = {id}";
            List<Type_Order> list = new List<Type_Order>();
            using (SqlConnection conn
                = new SqlConnection(new SQLConnection().ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    Type_Order thing = new Type_Order();
                    thing.Id = reader.GetInt32(0);
                    thing.Name = reader.GetString(1);
                    list.Add(thing);
                }
                reader.Close();
                conn.Close();
                return list;
            }
        }
    }
}


    public class SQLConnection
    {
        public string ConnectionString { get; set; } = @"Data Source=DESKTOP-PSEJFIA\SQLEXPRESS;Integrated Security=True";
    }



