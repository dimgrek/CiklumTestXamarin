namespace CiklumTestXamarin.Models
{
    public class User
    {
        public string gender { get; set; }
        public Name name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
        public int registered { get; set; }
        public int dob { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public string HETU { get; set; }
        //public Picture picture { get; set; }
    }
}
