namespace System.IO
{
    using System.IO.Compression;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    public static class DataFile
    {
        public static void Save<T>(T data, string path, bool compress = false)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            FileStream f = new FileStream(path, FileMode.Create, FileAccess.Write);

            XmlTextWriter x = null;
            GZipStream z = null;
            if (compress)
            {
                z = new GZipStream(f, CompressionMode.Compress);
                x = new XmlTextWriter(z, UnicodeEncoding.UTF8);
            }
            else
            {
                x = new XmlTextWriter(f, UnicodeEncoding.UTF8);
            }

            s.Serialize(x, data);
            x.Close();
            if (compress) z.Close();
            f.Close();
        }

        public static T Load<T>(string path, bool expand = false)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);

            T obj;
            if (expand)
            {
                GZipStream z = new GZipStream(f, CompressionMode.Decompress);
                obj = (T)s.Deserialize(z);
                z.Close();
            }
            else
            {
                obj = (T)s.Deserialize(f);
            }

            f.Close();
            return obj;
        }
    }
}
