using KatalonWebApplication.Library;
using KatalonWebApplication.WebPageObjects;
using TechTalk.SpecFlow;

namespace KatalonWebApplication.Steps
{
    [Binding]
    public class UX_AddingItemsInCartStepDefinitions
    {
        private int ExpectedTotalItemsInCart;

        private string Item_1, Item_2, Item_3, Item_4;

        private string PriceOfItem1, PriceOfItem2, PriceOfItem3, PriceOfItem4;

        double Price_Item1, Price_Item2, Price_Item3, Price_Item4;

        public List<KeyValuePair<string, double>> Item_Price;

        public List<KeyValuePair<string, double>> kvp;
        double minimumPrice;

        public UX_AddingItemsInCartStepDefinitions()
        {


        }

        [Given(@"I add four items to my cart")]
        public void GivenIAddFourItemsToMyCart()
        {
            Console.WriteLine("===========Test Scenario started for: 01_Adding items to the Shopping Cart=========================");
            // Adding 4 items to the Cart
            GenericHelpers.Click(LandingPage.Item_FlyingNinja, "Item Flying Ninja t-Shirt is not added to the cart");
            GenericHelpers.Click(LandingPage.Item_HappyNinja1, "Item Happy Ninja_1 t-Shirt is not added to the cart");
            GenericHelpers.Click(LandingPage.Item_HappyNinja2, "Item Happy Ninja_2 t-Shirt is not added to the cart");
            GenericHelpers.Click(LandingPage.Item_NinjaSilhotte, "Item Ninja Silhotte t-Shirt is not added to the cart");
            ExpectedTotalItemsInCart = 4;
        }

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
            Console.WriteLine("===========Test Step for view cart Link =========================");
            // Adding 4 items to the Cart
            GenericHelpers.Click(ViewCartPage.ViewCartLink, "View Cart button is displayed and user is able to click on the link successfully");
            Item_1 = GenericHelpers.GetText(ViewCartPage.ViewCartItem1);
            Item_2 = GenericHelpers.GetText(ViewCartPage.ViewCartItem2);
            Item_3 = GenericHelpers.GetText(ViewCartPage.ViewCartItem3);
            Item_4 = GenericHelpers.GetText(ViewCartPage.ViewCartItem4);

            Assert.True((Item_1 == "Flying Ninja" && Item_2 == "Happy Ninja" && Item_3 == "Happy Ninja" && Item_4 == "Ninja Silhouette"),
                "Items shopped doesnot matches with the items listed in the shopping cart");
        }




        [Then(@"I find total four items listed in my cart")]
        public void ThenIFindTotalFourItemsListedInMyCart()
        {
            int ActualOrderCount = GenericHelpers.GetRowCountFromTable(ViewCartPage.OrderCount);
            ActualOrderCount--;
            Assert.AreEqual(ExpectedTotalItemsInCart, ActualOrderCount);
            Console.WriteLine("items ordered were: " + ExpectedTotalItemsInCart + " and avaiable in the shopping cart are: " + ActualOrderCount);
        }

        [When(@"I search for the lowest price item")]
        public void WhenISearchForTheLowestPriceItem()
        {
            PriceOfItem1 = GenericHelpers.GetText(ViewCartPage.PriceOfItem1);
            PriceOfItem2 = GenericHelpers.GetText(ViewCartPage.PriceOfItem2);
            PriceOfItem3 = GenericHelpers.GetText(ViewCartPage.PriceOfItem3);
            PriceOfItem4 = GenericHelpers.GetText(ViewCartPage.PriceOfItem4);

            Price_Item1 = double.Parse(PriceOfItem1.Remove(0, 1));
            Price_Item2 = double.Parse(PriceOfItem2.Remove(0, 1));
            Price_Item3 = double.Parse(PriceOfItem3.Remove(0, 1));
            Price_Item4 = double.Parse(PriceOfItem4.Remove(0, 1));

            Dictionary<string, double> Item_Price1 = new Dictionary<string, double>();

            Item_Price1.Add(Item_1, Price_Item1);
            Item_Price1.Add(Item_2, Price_Item2);
            Item_Price1.Add(Item_3, Price_Item3);
            Item_Price1.Add(Item_4, Price_Item4);

            //foreach (KeyValuePair<string, double> kvp in Item_Price)
            //{
            //    Console.WriteLine(kvp.Key, kvp.Value);

            //}

            var key = Item_Price1.MinBy(x => x.Value).Key;
            var value = Item_Price1[key];

            //foreach (KeyValuePair<string, double> kvp in Item_Price)
            //{
            //    Console.WriteLine(kvp.Key, kvp.Value);
            //}


            // returning the lowest key value pair

            double[] PriceComparison = new[] { Price_Item1, Price_Item2, Price_Item3, Price_Item4 };
            double minimumPrice = PriceComparison.Min();

            Console.WriteLine("The lowest price for any of the item is " + minimumPrice);
            Console.WriteLine("The lowest price for any of the item: " + key + " and the value is: " + value);
        }



        [When(@"I am able to remove the lowest price item from my cart")]
        public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
        {

            //GenericHelpers.Click(ViewCartPage.DeleteCartItem1, "Item with product name and Price is the lowest and therefore removed from the cart"+ Item_Price.)


        }

        [Then(@"I am able to verify three items in the cart")]
        public void ThenIAmAbleToVerifyThreeItemsInTheCart()
        {
            Thread.Sleep(1000);
        }
    }
}
