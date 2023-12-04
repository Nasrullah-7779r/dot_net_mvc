using DotNetAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DotNetAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View("Dashboard");
        }
        public IActionResult AddMember()
		{
			return View("AddMember");
		}

        public IActionResult ViewMember()
		{
            SqlConnection conn = DB.getConnnection();
            List<Member> membersInfo = new List<Member>();

            string readQuery = "SELECT EmployeeCode, FirstName, LastName, Experties, Department  FROM Member";

            SqlDataReader? reader = DB.executeCommand(readQuery, conn);

           
            while(reader.Read() == true)
            {
                Member member = new Member();

                member.Ecode = reader["EmployeeCode"].ToString();
                member.Fname = reader["FirstName"].ToString();
                member.Lname = reader["LastName"].ToString();
                member.Exper = reader["Experties"].ToString();
                member.Dept = reader["Department"].ToString();

                membersInfo.Add(member);
            }


            ViewData["membersInfo"] = membersInfo;

            return View("ViewMember");
		}
        public IActionResult insertMemberData(Member memberInfo )
        {
            SqlConnection conn = DB.getConnnection();

            string insertQuery = String.Format("INSERT INTO Member (FirstName, LastName, Experties, Department, City, EmployeeCode, Email, ContactNumber," +
                                            " Gender, EmployeeType) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
            memberInfo.Fname, memberInfo.Lname, memberInfo.Exper, memberInfo.Dept, memberInfo.City, memberInfo.Ecode, memberInfo.Email, memberInfo.Cno, memberInfo.Gender, memberInfo.Employee_Type);

            SqlDataReader reader = DB.executeCommand(insertQuery, conn);


            return View("Dashboard");
        }

        public IActionResult deleteMemberData(string EmployeeCode)
        {
            SqlConnection conn = DB.getConnnection();

            string deleteQuery = String.Format("DELETE FROM Member WHERE EmployeeCode = '{0}'", EmployeeCode);

            DB.executeCommand(deleteQuery, conn);


            return RedirectToAction("ViewMember");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}