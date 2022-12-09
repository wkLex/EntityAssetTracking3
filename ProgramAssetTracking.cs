// See https://aka.ms/new-console-template for more information
using EntityAssetTracking3;
using System;

Console.WriteLine("Hello, World!");

MyDbContext Context = new MyDbContext();

//Days between puchase date and today to choose color
int daysWarning = 913; //Approx 30 months - yellow
int daysAlarm = 1004;  //Approx 33 months - red

bool Run = true;

while (Run)
{
    Console.WriteLine("Choose a number: ");
    Console.WriteLine();
    Console.WriteLine("1. List all assets ");
    Console.WriteLine("2. Add a new asset ");
    Console.WriteLine("3. Edit an asset ");
    Console.WriteLine("4. Delete an asset ");
    Console.WriteLine("5. Show assets orded by type and purchase date");
    Console.WriteLine("6. Exit application ");


    Console.WriteLine();
    Console.Write("Make your choice:  ");
    Console.WriteLine();
    string UserChoice = Console.ReadLine();
    Console.WriteLine();


    if (UserChoice == "1")
    {
        List<Asset> Assets = Context.Assets.ToList();

        Console.WriteLine("Here's all the assets - laptops and phones - in the database");
        Console.WriteLine("Shows: TYPE - BRAND - MODEL - PURCHASE DATE - OFFICE - PRICE EUR - CURRENCY - TODAY'S EXCHANGE RATE");
        Console.WriteLine();
        foreach (Asset Asset in Assets)
        {
           //TimeSpan diff = DateTime.Now - Asset.PurchaseDate;//Calculate time span between today and purchase date
           //DecideForegroundColor(daysWarning, daysAlarm, diff);
            Console.WriteLine($"{Asset.Type} {Asset.Brand} {Asset.Model} {Asset.PurchaseDate.ToString("yyyy-MM-dd")} {Asset.Office} {Asset.Price} {Asset.Currency} {Asset.ExchangeRate} ");
        }

        Console.WriteLine();

        Console.WriteLine();

    }

    else if (UserChoice == "2")
    {

        Asset Asset1 = new Asset();

        //Console.WriteLine("We are going to store asset data in the database.");
        Console.WriteLine("Please, enter the details of the asset.");
        Console.WriteLine();

        Console.Write("Type. Enter Laptop or Phone:  ");
        string Type = Console.ReadLine();

        Console.Write("Brand:  ");
        string Brand = Console.ReadLine();

        Console.Write("Model:  ");
        string Model = Console.ReadLine();

        Console.Write("Purchase date, enter as following yyyy-MM-dd:   ");
        string dataDate = Console.ReadLine(); //Convert string to DateTime
        DateTime PurchaseDate = Convert.ToDateTime(dataDate);

        Console.Write("Office:  ");
        string Office = Console.ReadLine();

        Console.Write("Price:  ");
        string data = Console.ReadLine(); //Convert string to double
        double Price = Convert.ToDouble(data);

        Console.Write("Currency:  ");
        string Currency = Console.ReadLine();

        
        Console.Write("Exchange Rate:  ");
        string dataExRate = Console.ReadLine();
        double ExchangeRate = Convert.ToDouble(dataExRate);


        Asset1.Type = Type;
        Asset1.Brand = Brand;
        Asset1.Model = Model;
        Asset1.PurchaseDate = PurchaseDate;
        Asset1.Office = Office;
        Asset1.Price = Price;
        Asset1.Currency = Currency;
        Asset1.ExchangeRate = ExchangeRate;
       

        Context.Assets.Add(Asset1);
        Context.SaveChanges();
        Console.WriteLine();
        Console.WriteLine("The information was saved.");
        Console.WriteLine();
        Console.WriteLine();
    }


    else if (UserChoice == "3")
    {
        Console.WriteLine("Choose an asset to edit");
        Console.WriteLine();
        List<Asset> Assets = Context.Assets.ToList();

        foreach (Asset Asset in Assets)

        {
            Console.WriteLine($"{Asset.Id} {Asset.Type} {Asset.Brand} {Asset.Model} {Asset.PurchaseDate} {Asset.Office} {Asset.Price} {Asset.Currency} {Asset.ExchangeRate}");
            Console.WriteLine();

        }

        Console.Write("Choose a number to edit: ");
        string EditAsset = Console.ReadLine();
        Asset AssetToEdit = Context.Assets.FirstOrDefault(x => x.Id == Convert.ToInt32(EditAsset));

        Console.WriteLine("Enter new data");

        Console.Write("Type, choose Laptop or Phone: ");
        string Type = Console.ReadLine();

        Console.Write("Brand:  ");
        string Brand = Console.ReadLine();

        Console.Write("Model:  ");
        string Model = Console.ReadLine();

        Console.Write("Purchase Date (yyyy-MM-dd):   ");
        string dataDate = Console.ReadLine(); ///Convert date from string to DateTime
        DateTime PurchaseDate = Convert.ToDateTime(dataDate);

        Console.Write("Office:  ");
        string Office = Console.ReadLine();

        Console.Write("Price:  ");
        //Convert Price to int and get right output console
        string data = Console.ReadLine();
        double Price = Convert.ToDouble(data);

        Console.Write("Currency:  ");
        string Currency = Console.ReadLine();

        Console.Write("Exchange Rate:  ");
        string dataExRate = Console.ReadLine();
        //double ExchangeRate = Convert.XXX(dataExRate);
       double ExchangeRate = Convert.ToDouble(dataExRate);
        //Console.WriteLine(ExchangeRate);


        AssetToEdit.Type = Type;
        AssetToEdit.Brand = Brand;
        AssetToEdit.Model = Model;
        AssetToEdit.PurchaseDate = PurchaseDate;
        AssetToEdit.Office = Office;
        AssetToEdit.Price = Price;
        AssetToEdit.Currency = Currency;
        AssetToEdit.ExchangeRate = ExchangeRate;

        Context.Assets.Update(AssetToEdit);
        Context.SaveChanges();
        Console.WriteLine("The new information was saved.");
        Console.WriteLine();
    }


    else if (UserChoice == "4")
    {
        Console.WriteLine("Choose an asset to delete.");
        List<Asset> Assets = Context.Assets.ToList();

        {
            foreach (Asset Asset in Assets)
            Console.WriteLine($"{Asset.Type} {Asset.Brand} {Asset.Model} {Asset.PurchaseDate.ToString("yyyy-MM-dd")} {Asset.Office} {Asset.Price} {Asset.Currency} {Asset.ExchangeRate} ");
            Console.WriteLine();
        }

        Console.Write("Choose an asset number to delete: ");
        string DeleteAsset = Console.ReadLine();
        Asset AssetToDelete = Context.Assets.FirstOrDefault(x => x.Id == Convert.ToInt32(DeleteAsset));

        Context.Assets.Remove(AssetToDelete);
        Context.SaveChanges();

        Console.WriteLine();
        Console.WriteLine("The asset was deleted.");
        Console.WriteLine();
    }

    else if (UserChoice == "5")
    {
        Console.WriteLine("Here's the assets sorted by type (laptop first, then phones) and then by purchase date");

        Console.WriteLine();
        //List<Asset> Assets = Context.Assets.ToList();

        var Assets = Context.Assets.ToList();


        List<Asset> SortedAssetsByTypeAndPurchaseDate(List<Asset> SortedAssets)
        {

            SortedAssets = Assets.OrderBy(Asset => Asset.GetType().Name).ThenBy(Asset => Asset.Type).ThenBy(Asset => Asset.PurchaseDate).ToList();

            return SortedAssets;
        }

        List<Asset> SortedAssets = SortedAssetsByTypeAndPurchaseDate(Assets);



        //CALCULATE TIME DIFF 

        Console.WriteLine("If red or yellow - check expiration date");
           Console.WriteLine();

        //Days between puchase date and today to choose color
        //int daysWarning = 913; //Approx 30 months - yellow
        //int daysAlarm = 1004;  //Approx 33 months - red

        // LOOPA IGENOM OCH SE OM DATUM ÄR VARNING ELLER ALARM + sortera på type and PurchaseDate
        foreach (var Asset in SortedAssets)
           {

            TimeSpan diff = DateTime.Now - Asset.PurchaseDate;//Calculate time span between today and purchase date
            DecideForegroundColor(daysWarning, daysAlarm, diff);

            Console.WriteLine(Asset.Type.PadRight(15) + Asset.Brand.PadRight(15) + Asset.Model.PadRight(15) + Asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + Asset.Office.PadRight(15) + Asset.Price.ToString().PadRight(10) + Asset.Currency.PadRight(10) + Asset.ExchangeRate);

           }

           Console.WriteLine();
        Console.WriteLine("Shows: TYPE -- BRAND -- MODEL -- PURCHASE DATE -- OFFICE -- PRICE EUR -- CURRENCY -- TODAY'S EXCHANGE RATE");
        Console.WriteLine();
    }
           

    else if (UserChoice == "6")
    {
        Run = false;
        Console.WriteLine("Bye for now. See you next time.");
    }
    else
    {
        Console.WriteLine("You have to choose a number between 1 and 5. Try again.");
    }
}




static void DecideForegroundColor(int daysWarning, int daysAlarm, TimeSpan diff)
{
    if (diff.Days > daysAlarm)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (diff.Days > daysWarning)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
}


