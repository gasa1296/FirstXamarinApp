namespace FirstApp.Utils
{
    public class Constants
    {
        public const string AppName = "";
        public const string AppVersion = "";
        public const string BaseUrl = "http://172.16.0.9:8000/api";
        public static string ApiToken = "";

        //routes
        public const string GetToken = BaseUrl + "/sanctum/token";
        public const string GetUser = BaseUrl + "/user";
        public const string RegisterUser = BaseUrl + "/register";
    }
}
