// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Xml;

namespace Xml_First_Project
{
    public class XML_First_Project
    {
        public static void Main()
        {
            // 1. קריאת קובץ ה-XML
            string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\XMLFile1.xml");
            Console.WriteLine("Project Directory: " + pathString);

            if (File.Exists(pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathString);

                // 2. חיפוש עובד עם ID = 2
                XmlNode? xmlNode = xmlDoc.SelectSingleNode("/Employees/Employee[@id = '2']");
                if (xmlNode != null && xmlNode.Attributes != null)
                {
                    Console.WriteLine("Employee with ID=2:");
                    foreach (XmlAttribute attribute in xmlNode.Attributes)
                    {
                        Console.WriteLine(attribute.Name + ": " + attribute.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Employee with ID=2 not found.");
                }

                // 3. חיפוש כל העובדים והצגת פרטיהם
                XmlNodeList? xmlNodes = xmlDoc.SelectNodes("/Employees/Employee");
                if (xmlNodes != null)
                {
                    Console.WriteLine("\nAll Employees:");
                    foreach (XmlNode node in xmlNodes)
                    {
                        if (node.Attributes != null)
                        {
                            foreach (XmlAttribute attribute in node.Attributes)
                            {
                                Console.WriteLine(attribute.Name + ": " + attribute.Value);
                            }
                        }
                        Console.WriteLine();
                    }
                }

                // 4. הוספת עובד חדש
                XmlElement newEmployee = xmlDoc.CreateElement("Employee");
                newEmployee.SetAttribute("id", "3");
                newEmployee.SetAttribute("FirstName", "John");
                newEmployee.SetAttribute("LastName", "Doe");
                newEmployee.SetAttribute("Title", "Software Developer");
                newEmployee.SetAttribute("HireDate", "2024-01-01");

                if (xmlDoc.DocumentElement != null)
                {
                    xmlDoc.DocumentElement.AppendChild(newEmployee);
                }

                // שמירת השינויים ב-XML
                xmlDoc.Save(pathString);
                Console.WriteLine("\nNew employee added.");
            }
            else
            {
                Console.WriteLine("XML file not found.");
            }
        }
    }
}
