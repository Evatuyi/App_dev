using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShoppingMap.Models {
    public class DefaultStores {

        //Stupid? Yeah whatever
        public static List<Store> GetStores() {
            ItemCategory shoes = new ItemCategory("Shoes");
            ItemCategory sweaters = new ItemCategory("Sweaters");
            ItemCategory shirts = new ItemCategory("Shirts");
            ItemCategory pants = new ItemCategory("Pants");
            ItemCategory swimmers = new ItemCategory("Swimmers");
			ItemCategory Technologies = new ItemCategory("Technology");
			ItemCategory Sports = new ItemCategory("Sports");
			ItemCategory HairNbody = new ItemCategory("Hair and Body");
			ItemCategory Furnitures = new ItemCategory("Furnitures");




			shoes.addItem(new Item("Black shoe"));
            shoes.addItem(new Item("White shoe"));
            shoes.addItem(new Item("Gray shoe"));
            shoes.addItem(new Item("Running shoe"));
            Item nikeShoe = new Item("Nike shoe");
            nikeShoe.images[0] = "nikeshoe.png";
            shoes.addItem(nikeShoe);

            sweaters.addItem(new Item("Black sweater"));
            sweaters.addItem(new Item("White sweater"));
            sweaters.addItem(new Item("Gray sweater"));
            sweaters.addItem(new Item("Nike sweater"));
            sweaters.addItem(new Item("Running sweater"));


			//Furnitures
			Item Sofa = new Item("Sofa");
            Sofa.images[0] = "sofa.png";
			Furnitures.addItem(Sofa);

			Item Desk = new Item("Study Desk");
			Desk.images[0] = "desk.png";
			Furnitures.addItem(Desk);

			Item Lamp = new Item("Table Lamp");
            Lamp.images[0] = "lamp.png";
            Furnitures.addItem(Lamp);

			Item Chair = new Item("Black Office Chair");
            Chair.images[0] = "chair.png";
            Furnitures.addItem(Chair);

			Item Bed = new Item("Black Queens Size Bed");
			Bed.images[0] = "bed.png";
			Furnitures.addItem(Bed);


			 //technologies 
			Item Apple_Macbook = new Item("Apple Mac book pro 2015 13");
            Apple_Macbook.images[0] = "macpro.png";
            Technologies.addItem(Apple_Macbook);

			Item Microsoft_Laptop = new Item("Microsoft Surface Laptop ");
            Microsoft_Laptop.images[0] = "microsoftsurface.png";
            Technologies.addItem(Microsoft_Laptop);

            Item Iphone8 = new Item("Iphone 8's ");
            Iphone8.images[0] = "iphone8.png";
            Technologies.addItem(Iphone8);

			Item Samsung_Galaxy8 = new Item("Samsung Galaxy 8");
            Samsung_Galaxy8.images[0] = "galaxy8.png";
            Technologies.addItem(Samsung_Galaxy8);

			Item Samsung_Galaxy_Note = new Item("Samsung Galaxy Note 8");
            Samsung_Galaxy_Note.images[0] = "galaxynote8.png";
            Technologies.addItem(Samsung_Galaxy_Note);

			Item LG= new Item("LG curved Smart TV");
			LG.images[0] = "lg.png";
			Technologies.addItem(LG);

			//hair and body
            HairNbody.addItem(new Item("Men shavers"));
            HairNbody.addItem(new Item("Toothbrushs"));
            HairNbody.addItem(new Item("toothpast"));


			//sport equipments
			Item SoccerBall = new Item("SoccerBall");
            SoccerBall.images[0] = "epl.png";
            Sports.addItem(SoccerBall);

			Item basketBall = new Item("Basketball");
            basketBall.images[0] = "basket.png";
            Sports.addItem(basketBall);

			Item cricketbat = new Item("CricketBat");
            cricketbat.images[0] = "batts.png";
            Sports.addItem(cricketbat);

			Item boxinggloves = new Item("Boxing Gloves");
            boxinggloves.images[0] = "Boxing.png";
            Sports.addItem(boxinggloves);

        
          



			pants.addItem(new Item("Black pants"));
            pants.addItem(new Item("White pants"));
            pants.addItem(new Item("Gray pants"));
            pants.addItem(new Item("Nike pants"));
            pants.addItem(new Item("Running pants"));

            shirts.addItem(new Item("Black shirt"));
            shirts.addItem(new Item("White shirt"));
            shirts.addItem(new Item("Gray shirt"));
            shirts.addItem(new Item("Nike shirt"));
            shirts.addItem(new Item("Running shirt"));

            swimmers.addItem(new Item("Black swimmer"));
            swimmers.addItem(new Item("White swimmer"));
            swimmers.addItem(new Item("Gray swimmer"));
            swimmers.addItem(new Item("Nike swimmer"));
            swimmers.addItem(new Item("Running swimmer"));

            Store HarveyNorman = new Store("Harvey Norman");
            HarveyNorman.addCategory(Technologies);
            HarveyNorman.addCategory(Sports);
            HarveyNorman.addCategory(HairNbody);
            HarveyNorman.addCategory(Furnitures);
            HarveyNorman.img = "harveynor.png";

            Store BigW = new Store("Big W");
            BigW.addCategory(shoes);
            BigW.addCategory(swimmers);
            BigW.img = "bigw.png";

            Store DavidJones = new Store("David Jones");
            DavidJones.addCategory(shoes);
            DavidJones.addCategory(sweaters);
            DavidJones.addCategory(pants);
            DavidJones.img = "davidj.png";

            Store Woolworths = new Store("Woolworths");
            Woolworths.addCategory(sweaters);
            Woolworths.img = "woolies.png";

            Store LensPro = new Store("LensPro");
            LensPro.addCategory(shoes);
            LensPro.addCategory(shirts);
            LensPro.img = "lenspro.png";

            Store ToysRUs = new Store("Toys R Us");
            ToysRUs.addCategory(shirts);
            ToysRUs.addCategory(pants);
            ToysRUs.addCategory(shoes);
            ToysRUs.addCategory(swimmers);
            ToysRUs.addCategory(sweaters);
            ToysRUs.img = "toys.png";

            Store Megaplex = new Store("Megaplex");
            Megaplex.addCategory(shirts);
            Megaplex.img = "megaplex.png";

            List<Store> returnStores = new List<Store>();
            returnStores.Add(HarveyNorman);
            returnStores.Add(BigW);
            returnStores.Add(DavidJones);
            returnStores.Add(Woolworths);
            returnStores.Add(LensPro);
            returnStores.Add(ToysRUs);
            returnStores.Add(Megaplex);

            return returnStores;
        }
    }
}
