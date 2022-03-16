namespace Back_end_API.Setting
{
    public class SettingMongoDb
    {
        public string? Host{get; set;}
        public int Port{get; set;}
        public string ConnectionString{
            get
            {
                return $"mongodb://{Host}:{Port}";
            }
        }
    }
}