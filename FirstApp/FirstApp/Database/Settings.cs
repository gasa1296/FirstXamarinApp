using SQLite;

namespace FirstApp.Database
{
    public class Settings
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
