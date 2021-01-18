namespace App.Models.Options {
    public class YnabOptions {
        public const string Section = "YNAB";

        // This library targets the v1 API from https://api.youneedabudget.com/v1
        public string EndPoint { get; set; }

        // Get this from YNAB's site
        public string AccessToken { get; set; }

        // This is the first hash in the URL of a budget
        public string BudgetId { get; set; }
    }
}
