using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OPZZ.MSCS.Updater.Core
{
    public class UpdateListReader
    {
        public static UpdateListInfo Read(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException($"文件{fileName}不存在");
            }

            UpdateListInfo info = new UpdateListInfo();
            var xml = File.ReadAllText(fileName, Encoding.GetEncoding("GB2312"));
            XmlDocument document = new XmlDocument();
            document.LoadXml(xml);
            XmlElement rootElem = document.DocumentElement;

            //Description
            info.Description = ReadDescription(rootElem);

            //Updater
            info.Updater = ReadUpdater(rootElem);

            //Application
            info.Application = ReadApplication(rootElem);

            //Files
            info.Files = ReadFiles(rootElem);

            return info;
        }

        private static string ReadDescription(XmlElement element)
        {
            return GetNodeValue(element, "/AutoUpdater/Description");
        }

        private static UpdateListInfo.UpdaterInfo ReadUpdater(XmlElement element)
        {
            var updater = new UpdateListInfo.UpdaterInfo();
            updater.Url = GetNodeValue(element, "/AutoUpdater/Updater/Url");
            updater.LastUpdateTime = GetNodeValue(element, "/AutoUpdater/Updater/LastUpdateTime");
            return updater;
        }

        private static UpdateListInfo.ApplicationInfo ReadApplication(XmlElement element)
        {
            var application = new UpdateListInfo.ApplicationInfo();
            application.EntryPoint = GetNodeValue(element, "/AutoUpdater/Application/EntryPoint");
            application.Location = GetNodeValue(element, "/AutoUpdater/Application/Location");
            application.Version = new MSCSVersion(GetNodeValue(element, "/AutoUpdater/Application/Version"));
            var node = element.SelectSingleNode("/AutoUpdater/Application");
            application.applicationId = GetNodeAttr(node, "applicationId", "");
            return application;
        }

        private static List<UpdateListInfo.FileInfo> ReadFiles(XmlElement element)
        {
            var files = new List<UpdateListInfo.FileInfo>();
            var nodeList = element.SelectNodes("/AutoUpdater/Files/File");
            if (nodeList != null)
            {
                foreach (XmlNode node in nodeList)
                {
                    var file = new UpdateListInfo.FileInfo();
                    file.Ver = new MSCSVersion(GetNodeAttr(node, "Ver", ""));
                    file.Name = GetNodeAttr(node, "Name", "");

                    files.Add(file);
                }
            }
            return files;
        }

        private static string GetNodeValue(XmlElement element, string xpath)
        {
            var node = element.SelectSingleNode(xpath);
            return GetNodeValue(node);
        }

        private static string GetNodeValue(XmlNode node)
        {
            if (node != null)
            {
                return node.InnerText;
            }

            return string.Empty;
        }

        private static string GetNodeAttr(XmlNode node, string name, string defaultVal)
        {
            if (node.Attributes[name] == null)
            {
                return defaultVal;
            }
            else
            {
                return node.Attributes[name].Value.ToString();
            }
        }
    }
}
