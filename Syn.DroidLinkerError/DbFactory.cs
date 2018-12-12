
using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Microsoft.Extensions.Logging;
using Android.Content;
using Android.Support.V4.App;

using Android.App;

namespace Syn.DroidLinkerError
{
    static class DbFactory
    {
        const string DatabaseFilePattern = "Cander.db";

        public static byte[] ReadDb(Context appContext, string username)
        {
            string userDirectoryPath = BasePath;
            string destination = Path.Combine(userDirectoryPath, DatabaseFilePattern);
            using (var ms = new MemoryStream())
            using (BinaryReader reader = new BinaryReader(new FileStream(destination, FileMode.Open)))
            {
                byte[] buffer = new byte[2048];
                int len = 0;
                while ((len = reader.Read(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, len);
                return ms.ToArray();
            }
        }

        public static CanderDbContext GetUnitOfWork(Android.Content.Context appContext)
        {
            var dbFileName = DatabaseFilePattern;

            string destination = Path.Combine(BasePath, dbFileName);
            if (!File.Exists(destination))
            {
                if (!Directory.Exists(BasePath))
                    Directory.CreateDirectory(BasePath);

                using (BinaryReader br = new BinaryReader(appContext.Assets.Open(dbFileName)))
                {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(destination, FileMode.Create)))
                    {
                        byte[] buffer = new byte[2048];
                        int len = 0;
                        while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            bw.Write(buffer, 0, len);
                        }
                    }
                }
            }
            return new CanderDbContext(destination);
        }

        static string _basePath = string.Empty;
        static string BasePath
        {
            get
            {
                if (string.IsNullOrEmpty(_basePath))
                    _basePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                return _basePath;
            }
        }
    }
}