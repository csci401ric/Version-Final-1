/********************************
 * DropboxTools.cs
 * Created by The Dev Doods
********************************/

using Dropbox.Api;
using Dropbox.Api.Files;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperStopNBuy
{
    class DropboxTools
    {
        // Variables

        private DropboxClient dropboxClient;
        private string authState;
        private string authURL;
        private const string RedirectURI = "https://localhost/authorize";



        public DropboxTools()
        {
            try
            {
                // Variables
                DropboxClientConfig dropboxClientConfig;
                HttpClient httpClient;
                Uri authURI;

                // Get authentication
                this.authState = Guid.NewGuid().ToString("N");
                authURI = DropboxOAuth2Helper.GetAuthorizeUri(OAuthResponseType.Token, Global.AppKey, RedirectURI, state: this.authState);
                this.authURL = authURI.AbsoluteUri.ToString();

                // Create dropbox client config
                dropboxClientConfig = new DropboxClientConfig(Global.AppName);

                // Create http client
                httpClient = new HttpClient
                {
                    Timeout = TimeSpan.FromMinutes(10)
                };

                // Create dropbox client
                dropboxClientConfig.HttpClient = httpClient;
                this.dropboxClient = new DropboxClient(Global.AccessToken, dropboxClientConfig);
            }
            catch
            {
                // Error
            }
        }



        public async Task Upload(string sourceFileName, string targetFileName)
        {
            try
            {
                // Upload file
                using (var uploadStream = new System.IO.MemoryStream(File.ReadAllBytes(sourceFileName)))
                {
                    // Variables
                    FileMetadata uploadFile;

                    // Create file
                    uploadFile = await this.dropboxClient.Files.UploadAsync(targetFileName, WriteMode.Overwrite.Instance, body: uploadStream);
                }
            }
            catch
            {
                // Error
            }
        }



        public async Task Download(string sourceFileName, string targetFileName)
        {
            try
            {
                // Check if file exists
                if (File.Exists(targetFileName))
                {
                    // Return
                    return;
                }

                // Download file
                using (var downloadFile = await this.dropboxClient.Files.DownloadAsync(sourceFileName))
                {
                    // Create temporary download path
                    Global.CreateTemporaryDownloadPath();

                    // Create file
                    using (var downloadStream = File.Create(targetFileName))
                    {
                        (await downloadFile.GetContentAsStreamAsync()).CopyTo(downloadStream);
                    }
                }
            }
            catch
            {
                // Error
            }
        }



        public async Task DownloadToPictureBox(string sourceFileName, string targetFileName, PictureBox pb)
        {
            try
            {
                // Variables
                Image downloadPicture;

                // Download picture
                await this.Download(sourceFileName,targetFileName);

                // Set picture box to downloaded picture
                downloadPicture = Image.FromFile(targetFileName);
                pb.Image = downloadPicture;
            }
            catch
            {
                // Null picture
                pb.Image = null;
            }
        }



        public async Task Delete(string path)
        {
            try
            {
                // Variables
                DeleteResult deletePath;

                // Delete file or folder at path
                deletePath = await this.dropboxClient.Files.DeleteV2Async(path);
            }
            catch
            {
                // Error
            }
        }
    }
}
