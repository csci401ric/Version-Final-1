/********************************
 * Global.cs
 * Created by The Dev Doods
********************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStopNBuy
{
    class Global
    {
        // Variables
        public const string ConnectionString = "UID=sql9220208;Password=4jwh1CZfkh;Server=sql9.freesqldatabase.com;Database=sql9220208;Port=3306";
        public const string AccessToken = "szxGrIDyIlAAAAAAAAAADS_F2_Gw78x5ZjzyKGTWE3VotFBqlMRmccfBXLwKJblr";
        public const string AppName = "SuperStopNBuy";
        public const string AppKey = "7djx1iy2rhoaxe4";
        public const string AppDirectory = "/Items/";
        public const string AppExtension = ".png";

        public static string GetTemporaryDownloadPath()
        {
            // Return
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SuperStopNBuy\\");
        }

        public static void CreateTemporaryDownloadPath()
        {
            // Check if directory exists
            if (!Directory.Exists(GetTemporaryDownloadPath()))
            {
                // Create directory
                Directory.CreateDirectory(GetTemporaryDownloadPath());
            }
        }

        public static void DeleteTemporaryDownloadPath()
        {
            // Check if directory exists
            if (Directory.Exists(GetTemporaryDownloadPath()))
            {
                // Delete directory
                Directory.Delete(GetTemporaryDownloadPath(), true);
            }
        }
    }
}
