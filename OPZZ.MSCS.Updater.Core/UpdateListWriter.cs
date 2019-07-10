using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OPZZ.MSCS.Updater.Core
{
    public class UpdateListWriter
    {
        public static void Write(string fileName, UpdateListInfo info)
        {
            if (info == null)
            {
                throw new ArgumentNullException();
            }

            MemoryStream stream = new MemoryStream();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.GetEncoding("GB2312");
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(stream, settings);

            //Doc Start
            writer.WriteStartDocument();

            //Root Element Start
            writer.WriteStartElement("AutoUpdater");

            //1.Description
            WriteDescription(writer, info);

            //2.Updater
            WriteUpdater(writer, info);

            //3.Application
            WriteApplication(writer, info);

            //4.Files
            WriteFiles(writer, info);

            //Root Element End
            writer.WriteEndElement();

            //Doc End
            writer.WriteEndDocument();
            writer.Close();

            string xml = Encoding.GetEncoding("GB2312").GetString(stream.ToArray());
            stream.Close();

            File.WriteAllText(fileName, xml, Encoding.GetEncoding("GB2312"));
        }

        private static void WriteDescription(XmlWriter writer, UpdateListInfo info)
        {
            WriteElementValue(writer, nameof(info.Description), info.Description);
        }

        private static void WriteUpdater(XmlWriter writer, UpdateListInfo info)
        {
            writer.WriteStartElement(nameof(info.Updater));

            WriteElementValue(writer, nameof(info.Updater.Url), info.Updater.Url);
            WriteElementValue(writer, nameof(info.Updater.LastUpdateTime), DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

            writer.WriteEndElement();
        }

        private static void WriteApplication(XmlWriter writer, UpdateListInfo info)
        {
            writer.WriteStartElement(nameof(info.Application));
            writer.WriteAttributeString(nameof(info.Application.applicationId), info.Application.applicationId);

            WriteElementValue(writer, nameof(info.Application.EntryPoint), info.Application.EntryPoint);
            WriteElementValue(writer, nameof(info.Application.Location), info.Application.Location);
            WriteElementValue(writer, nameof(info.Application.Version), info.Application.Version.ToString());

            writer.WriteEndElement();
        }

        private static void WriteFiles(XmlWriter writer, UpdateListInfo info)
        {
            writer.WriteStartElement(nameof(info.Files));
            
            foreach(var file in info.Files)
            {
                writer.WriteStartElement("File");
                writer.WriteAttributeString(nameof(file.Ver), file.Ver.ToString());
                writer.WriteAttributeString(nameof(file.Name), file.Name);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        private static void WriteElementValue(XmlWriter writer, string name, string value)
        {
            writer.WriteStartElement(name);
            writer.WriteString(value == null ? "" : value);
            writer.WriteEndElement();
        }
    }
}
