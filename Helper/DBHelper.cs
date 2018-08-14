using Microsoft.Extensions.Configuration;

namespace Sun.Helper
{
    public class DBHelper
    {
        private readonly string _connStr;
        public DBHelper(IConfiguration config)
        {
            this._connStr = config.GetConnectionString("DB");
        }
        public string GetConnStr()
        {
            return this._connStr;
        }
    }
}