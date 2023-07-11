namespace KatalonWebApplication.WebPageObjects
{
    public class ViewCartPage
    {
        public static string ViewCartLink = "//*[@id='primary-menu']/ul/li[1]/a";
        public static string ViewCartItem1 = "//*[@id='post-8']/div/div/form/table/tbody/tr[1]/td[3]/a";
        public static string ViewCartItem2 = "//*[@id='post-8']/div/div/form/table/tbody/tr[2]/td[3]/a";
        public static string ViewCartItem3 = "//*[@id='post-8']/div/div/form/table/tbody/tr[3]/td[3]/a";
        public static string ViewCartItem4 = "//*[@id='post-8']/div/div/form/table/tbody/tr[4]/td[3]/a";

        public static string OrderCount = "//*[@id='post-8']/div/div/form/table/tbody/tr";

        public static string PriceOfItem1 = "//*[@id='post-8']/div/div/form/table/tbody/tr[1]/td[4]/span";
        public static string PriceOfItem2 = "//*[@id='post-8']/div/div/form/table/tbody/tr[2]/td[4]/span";
        public static string PriceOfItem3 = "//*[@id='post-8']/div/div/form/table/tbody/tr[3]/td[4]/span";
        public static string PriceOfItem4 = "//*[@id='post-8']/div/div/form/table/tbody/tr[4]/td[4]/span";

        public static string DeleteCartItem1 = "//*[@id='post-8']/div/div/form/table/tbody/tr[1]/td[1]/a";
        public static string DeleteCartItem2 = "//*[@id='post-8']/div/div/form/table/tbody/tr[2]/td[1]/a";
        public static string DeleteCartItem3 = "//*[@id='post-8']/div/div/form/table/tbody/tr[3]/td[1]/a";
        public static string DeleteCartItem4 = "//*[@id='post-8']/div/div/form/table/tbody/tr[4]/td[1]/a";


    }
}
