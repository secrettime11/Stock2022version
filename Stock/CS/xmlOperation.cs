using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Stock.CS
{
    public class xmlOperation
    {
        /* Element example
         * 
         XElement xElement = new XElement(
                new XElement("BookStore",
                    new XElement("Book",
                        new XElement("Name", "A", new XAttribute("BookName", "C#")),
                        new XElement("Author", "B", new XAttribute("Name", "Martin")),
                        new XElement("Adress", "C"),
                        new XElement("Date", DateTime.Now.ToString("yyyy-MM-dd"))
                        ),
                    new XElement("Book",
                        new XElement("Name", "D", new XAttribute("BookName", "WCF")),
                        new XElement("Author", "E", new XAttribute("Name", "Mary")),
                        new XElement("Adress", "F"),
                        new XElement("Date", DateTime.Now.ToString("yyyy-MM-dd"))
                        )
                        )
                );
         *
         */

        /// <summary>
        /// 產生XML檔
        /// </summary>
        /// <param name="xmlPath">路徑+檔名</param>
        /// <param name="xElement">XML內容格式</param>
        public void CreatXmlTree(string xmlPath, XElement xElement)
        {
            // 需要指定編碼格式，否則在讀取時會拋：根級別上的資料無效。 第 1 行 位置 1異常
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UTF8Encoding(false);
            settings.Indent = true;
            using (XmlWriter xw = XmlWriter.Create(xmlPath, settings))
            {
                // 寫入檔案
                xElement.Save(xw);
                xw.Flush();
                xw.Close();
            }
        }
        /// <summary>
        /// 新增根元素的第一層子節點
        /// </summary>
        /// <param name="xmlPath">路徑+檔名</param>
        /// <param name="elementName">節點名稱</param>
        /// <param name="elementContent">內容</param>
        public void Create(string xmlPath, string elementName, string elementContent)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            // 根結點
            var root = xmlDoc.DocumentElement;
            XmlNode newNode = xmlDoc.CreateNode("element", elementName, "");
            newNode.InnerText = elementContent;

            // 新增為根元素的第一層子結點
            root.AppendChild(newNode);
            xmlDoc.Save(xmlPath);
        }
        /// <summary>
        /// 設定節點屬性
        /// </summary>
        /// <param name="xmlPath">路徑+檔名</param>
        /// <param name="NodeLayer">找尋節點層 (eg."BookStore/NewBook")</param>
        /// <param name="name">設定屬性Name</param>
        /// <param name="value">設定Name value</param>
        public void CreateAttribute(string xmlPath, string NodeLayer, string name, string value)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement node = (XmlElement)xmlDoc.SelectSingleNode(NodeLayer);
            node.SetAttribute(name, value);
            xmlDoc.Save(xmlPath);
        }
        /// <summary>
        /// 刪除節點
        /// </summary>
        /// <param name="xmlPath">路徑+檔名</param>
        /// <param name="NodeLayer">找尋節點層 (eg."BookStore/NewBook")</param>
        public void Delete(string xmlPath, string NodeLayer)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            // 根結點
            var root = xmlDoc.DocumentElement;

            var element = xmlDoc.SelectSingleNode(NodeLayer);
            root.RemoveChild(element);
            xmlDoc.Save(xmlPath);
        }
        /// <summary>
        /// 刪除節點屬性
        /// </summary>
        /// <param name="xmlPath">路徑+檔名</param>
        /// <param name="NodeLayer">找尋節點層 (eg."BookStore/NewBook")</param>
        /// <param name="attributeName">節點屬性名稱</param>
        public void DeleteAttribute(string xmlPath, string NodeLayer,string attributeName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement node = (XmlElement)xmlDoc.SelectSingleNode(NodeLayer);
            // 移除指定屬性
            node.RemoveAttribute(attributeName);
            // 移除當前節點所有屬性，不包括預設屬性
            //node.RemoveAllAttributes();
            xmlDoc.Save(xmlPath);
        }
        /// <summary>
        /// 修改屬性值
        /// </summary>
        /// <param name="xmlPath">路徑+檔名</param>
        /// <param name="NodeLayer">找尋節點層 (eg."BookStore/NewBook")</param>
        /// <param name="name">節點屬性名稱</param>
        /// <param name="value">節點屬性值</param>
        public void ModifyAttribute(string xmlPath, string NodeLayer, string name, string value)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement element = (XmlElement)xmlDoc.SelectSingleNode("BookStore/NewBook");
            element.SetAttribute("Name", "Zhang");
            xmlDoc.Save(xmlPath);
        }

        public void Select(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            //取根結點
            var root = xmlDoc.DocumentElement;//取到根結點
                                              //取指定的單個結點
            XmlNode oldChild = xmlDoc.SelectSingleNode("BookStore/NewBook");

            //取指定的結點的集合
            XmlNodeList nodes = xmlDoc.SelectNodes("BookStore/NewBook");

            //取到所有的xml結點
            XmlNodeList nodelist = xmlDoc.GetElementsByTagName("*");
        }

        public void SelectAttribute(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement element = (XmlElement)xmlDoc.SelectSingleNode("BookStore/NewBook");
            string name = element.GetAttribute("Name");
            Console.WriteLine(name);
        }
    }
}
