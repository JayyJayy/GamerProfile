namespace OverwatchApi.Models
{
    public class UserModel
    {
        public string Platform { get; set; }
        public string Region { get; set; }

        public string Name
        {
            get;
            set { Name = Name.Replace('#', '-'); }
        }
    }
}