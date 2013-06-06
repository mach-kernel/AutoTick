using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AutoTick
{
    class SettingsSerializer
    {
        public static void saveUsers(List<ListViewItem> userCol)
        {
            XmlWriter usrGen = XmlWriter.Create(AppDomain.CurrentDomain.BaseDirectory + "users.xml");

            usrGen.WriteStartDocument();

            usrGen.WriteStartElement("ATData");
            usrGen.WriteAttributeString("Version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            usrGen.WriteAttributeString("Type", "User Data");
            usrGen.WriteAttributeString("Date", DateTime.Now.ToString());

            usrGen.WriteStartElement("Members");
            
            foreach(ListViewItem item in userCol)
            {
                usrGen.WriteStartElement("Member");
                usrGen.WriteAttributeString("Name", item.Text.ToString());
                usrGen.WriteAttributeString("Token", item.SubItems[1].Text.ToString());
                usrGen.WriteEndElement();
            }

            usrGen.WriteEndElement();
            usrGen.WriteEndElement();
            usrGen.WriteEndDocument();

            usrGen.Flush();
            usrGen.Close();
        }

        public static List<ListViewItem> loadUsers()
        {
            XmlDocument usrXml = new XmlDocument();
            usrXml.Load(AppDomain.CurrentDomain.BaseDirectory + "users.xml");

            List<ListViewItem> userCol = new List<ListViewItem>();

            foreach (XmlElement xmE in usrXml.GetElementsByTagName("Member"))
            {
                ListViewItem member = new ListViewItem();
                ListViewItem.ListViewSubItem token = new ListViewItem.ListViewSubItem();
                member.Text = xmE.Attributes[0].Value.ToString();
                token.Text = xmE.Attributes[1].Value.ToString();
                member.SubItems.Add(token);

                userCol.Add(member);
            }

            return userCol;
        }

    }
}
