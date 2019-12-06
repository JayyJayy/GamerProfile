namespace OverwatchApi.Models
{
    public class UserModel
    {
        public string PlatformSelect { get; set; }
        public string RegionSelect { get; set; }
        private string _name;
        public string UserName
        {
            get => _name;
            set => _name = value.Replace("#", "-");
        }
    }
}