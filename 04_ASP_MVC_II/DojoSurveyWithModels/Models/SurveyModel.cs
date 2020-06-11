namespace DojoSurveyWithModels.Models
{
    public class User
    {
        public string Name {get;set;}
        public string Dojo {get;set;}
        public string FavLanguage {get;set;}
        public string Comment {get;set;}
        public User(string name, string dojo, string favlang, string comment  ) 
        {
            this.Name = name;
            this.Dojo = dojo;
            this.FavLanguage = favlang;
            this.Comment = comment;
        }
        
    }

}
