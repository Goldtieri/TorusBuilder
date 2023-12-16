using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Xml;


namespace MyLibrary
{
    public class XML
    { 
    }
        /*public static void read_from_xml_doc(XmlDocument xml_doc, RadioButton rdbtn1, RadioButton rdbtn2, ref Color border_clr, ref Color rect, ref Color tri,
            CheckBox chbox, ref int n, ref int w, ref double angle)
        {
            XmlNodeList nodes = xml_doc.DocumentElement.ChildNodes;
            if (nodes[0].InnerText == "1")
            {
                rdbtn1.Checked = true;
            }
            else
            {
                rdbtn2.Checked = true;
            }
            border_clr = ColorTranslator.FromHtml(nodes[1].InnerText);
            rect = ColorTranslator.FromHtml(nodes[2].InnerText);
            tri = ColorTranslator.FromHtml(nodes[3].InnerText);
            if (nodes[4].InnerText == "1")
            {
                chbox.Checked = true;
            }
            else
            {
                chbox.Checked = false;
            }
            n = Convert.ToInt32(nodes[5].InnerText);
            w = Convert.ToInt32(nodes[6].InnerText);
            angle = Convert.ToInt32(nodes[7].InnerText) * Math.PI / 180;

        }

        public static void save_inf_to_xml_doc(XmlDocument xml_doc, RadioButton rdbtn1, Color border_clr, Color rect, Color tri,
        CheckBox chbox, int n, int w, double angle, string path)
        {
            XmlNodeList nodes = xml_doc.DocumentElement.ChildNodes;
            if (rdbtn1.Checked)
            {
                nodes[0].InnerText = "1";
            }
            else
            {
                nodes[0].InnerText = "2";
            }
            nodes[1].InnerText = ColorTranslator.ToHtml(border_clr);
            nodes[2].InnerText = ColorTranslator.ToHtml(rect);
            nodes[3].InnerText = ColorTranslator.ToHtml(tri);
            if (chbox.Checked)
            {
                nodes[4].InnerText = "1";
            }
            else
            {
                nodes[4].InnerText = "0";
            }
            nodes[5].InnerText = n.ToString();
            nodes[6].InnerText = w.ToString();
            nodes[7].InnerText = ((int)(angle / Math.PI * 180)).ToString();
            xml_doc.Save(path);

        }
    }        */
}