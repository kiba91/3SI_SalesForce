namespace MVC._3SI.SalesForce.Infrastructure.Salesforce
{
    public class ApiService
    {
        public static string GetLoginUrl() {
            return "https://login.salesforce.com/services/oauth2/authorize?response_type=code&client_id=3MVG9ZL0ppGP5UrBezl6Yc_4I6VESYFm7iBy8jdnXDKkE4UXVbDF0A_hqalb2rCoqF7vndJOm9S6W.ADTqPkF&redirect_uri=https%3A%2F%2F3si-salesforce.com%2Fauthentication";
        }
    }

}