namespace ViewModel_Fun.Models
{
    public class User
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}

        public User(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
    }

}

