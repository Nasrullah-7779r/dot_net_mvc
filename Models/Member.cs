namespace DotNetAssignment.Models
{
    public class Member
    {
    private
        string fname;
        string lname;
        string exper;
        string dept;
        string city;
        string ecode;
        string email;
        string cno;
        string gender;
        string employee_type;
     
  
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Exper { get; set; }
        public string Dept { get; set; }
        public string City { get; set; }
        public string Ecode { get; set; }
        public string Email { get; set; }
        public string Cno { get; set; }
        public string Gender { get; set; }
        public string Employee_Type { get; set; }

      public Member(string first_name,
                      string last_name,
                      string exprerience,
                      string dept,
                      string city,
                      string e_code,
                      string email,
                      string c_no,
                      string gender,
                      string emp_type) {

            Fname=first_name;
            Lname = last_name;
            Exper=exprerience;
            Dept = dept;
            City = city;
            Ecode = e_code;
            Email = email;
            Cno = c_no;
            Gender = gender;
            Employee_Type = emp_type;
        }

      public Member()
        {

        }

    }
}
