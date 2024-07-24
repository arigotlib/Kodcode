using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml_first_project
{
    internal class Employees
    {
        public void GetAllEmployees(XmlNodeList? xmlNodeList = null)
        {
            if (xmlNodeList == null)
            {
                xmlNodeList = XmlDocument.SelectNodes("/Employees/Employee");
            }
            foreach (XmlNode node in xmlNodeList)
            {
                PrintNode(node);
                if (node.HasChildNodes)
                {
                    GetAllEmployees(node.ChildNodes);
                }
            }
        }

        private void PrintNode(XmlNode node)
        {
            Console.WriteLine($"Node Name: {node.Name}, Node Value: {node.InnerText}");
            if (node.Attributes != null)
            {
                foreach (XmlAttribute attr in node.Attributes)
                {
                    Console.WriteLine($"Attribute Name: {attr.Name}, Attribute Value: {attr.Value}");
                }
            }
        }
        //public void GetOneEmployeeById(string id)
        //{
        //    XmlNode employee = XmlDocument.Se
        //}

    }
}
