using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLib
{
    static public class TransformationToXML
    {
        static public void Transform(IQueryable<ClassLib.Offers> offers, string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement element;

            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null));
            element = xmlDocument.CreateElement("DatabaseTable");
            xmlDocument.AppendChild(element);
            foreach(Offers o in offers)
            {
                XmlElement offer;
                offer = xmlDocument.CreateElement("Offer");
                XmlAttribute name = xmlDocument.CreateAttribute("Name");
                string str = o.o_name.ToString();
                int i = str.Length-1;
                while (str[i] == ' ')
                {
                    i--;
                }
                name.Value = str.Remove(i+1, str.Length - i - 1);
                XmlAttribute bank = xmlDocument.CreateAttribute("Bank");
                str = o.Banks.b_name.ToString();
                i = str.Length - 1;
                while (str[i] == ' ')
                {
                    i--;
                }
                bank.Value = str.Remove(i+1, str.Length - i - 1);
                XmlAttribute offertype = xmlDocument.CreateAttribute("Type");
                str = o.OfferType.ot_name.ToString();
                i = str.Length - 1;
                while (str[i] == ' ')
                {
                    i--;
                }
                offertype.Value = str.Remove(i+1, str.Length - i - 1);
                XmlAttribute percentage = xmlDocument.CreateAttribute("Percetage");
                percentage.Value = Convert.ToString(o.o_percentage);
                XmlAttribute maxsum = xmlDocument.CreateAttribute("MaxSum");
                maxsum.Value = Convert.ToString(o.Conditions.c_sum_max);
                XmlAttribute minsum = xmlDocument.CreateAttribute("MinSum");
                minsum.Value = Convert.ToString(o.Conditions.c_sum_min);

                offer.Attributes.Append(name);
                offer.Attributes.Append(bank);
                offer.Attributes.Append(offertype);
                offer.Attributes.Append(percentage);
                offer.Attributes.Append(maxsum);
                offer.Attributes.Append(minsum);

                element.AppendChild(offer);
            }

            xmlDocument.Save(path);
            return;
        }
    }
}
