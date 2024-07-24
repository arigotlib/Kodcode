using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace CoffeeMachine
{
    internal class DrinksManager
    {
        private XmlDocument _document;
        public DrinksManager(XmlDocument doc) 
        {
         _document = doc;
        }

        public static Func<List<string>,string> join = (x) => x.Aggregate("", (res,n) => res + n);

        public static Func<List<string>, bool> ifAvi = (x) => x.Any((l) => l == "avi");

   



        public List<List<string>> GetDrinksData()
        {
            List<List<string>> AllDrinks = new List<List<string>>();
            XmlNodeList drinkNodes = _document.SelectNodes("/drinks/drink");
            if (drinkNodes != null)
            {
                foreach (XmlNode node in drinkNodes)
                {
                    List<string> drinkDetails = new List<string>();
                    if (node.ChildNodes != null)
                    {
                        foreach (XmlNode node2 in node.ChildNodes)
                        {
                            drinkDetails.Add(node2.InnerText);
                        }
                        AllDrinks.Add(drinkDetails);
                    }
                        
                    
                }
            }

            return AllDrinks;
        }
        private XmlNode GetRoot()
        {
            return _document.GetElementsByTagName("drinks")[0];
        }
        //Add drink to xml
        public void AddDrink(List<string> drinks)
        {
            XmlElement element = _document.CreateElement("drink");
            List<string> tagsName = new List<string>() { "name", "sugar", "coffee","cocoa", "milk", "price" };
            for (int i = 0; i < tagsName.Count; i++)
            {
                XmlElement child = _document.CreateElement(tagsName[i]);
                child.InnerText = drinks[i];
                element.AppendChild(child);
            }
            GetRoot().AppendChild(element);
        }
        //save drink in xml
        public void Save()
        {
            MainProject.Save(_document);
        }
        public void UpdateDrink(List<string> drinks) 
        {
            XmlNodeList drinksList = _document.GetElementsByTagName("name");
            if (drinksList == null) return;
            foreach (XmlNode drink in drinksList)
            {
                if (drink.InnerText == drinks[0])
                {
                    int i = 0;
                    foreach(XmlNode childe in drink.ParentNode)
                    {
                        childe.InnerText = drinks[i++];
                    }
                }
            }
            MainProject.UpdateDrink(_document);
            return;
        }
        
        public List<string> GetElementsByName(string name)
        { 
            List<string> list=new List<string>();
            XmlNodeList drinksList = _document.GetElementsByTagName("name");
            if (drinksList == null) return null; 
            foreach (XmlNode drink in drinksList)
            {
                if (drink.InnerText == name)
                {
                    list = GetAllData(drink.ParentNode);
                }
            }
            return list;
        }
        private List<string> GetAllData(XmlNode drink)
        {
            List<string> list = new List<string>();
            foreach (XmlNode childe in drink.ChildNodes) 
            { list.Add(childe.InnerText); }
            return list;
        }
        

    }
    
}
