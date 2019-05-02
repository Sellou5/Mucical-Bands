using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace SoundCloudeStreaming.Helper
{
    /// <summary>
    /// HTTP Requests Helper Class Developed By Ahmed Mabrouck.
    /// </summary>
    public static class Http
    {
        /// <summary>
        /// Issues an http post request to the passed URL
        /// and returns request response.
        /// </summary>
        /// <param name="URL">Http post request URL.</param>
        /// <returns> 
        /// Http request response as string.
        /// </returns> 
        public async static Task<string> PostHttpRequestAsync(Uri URL)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.PostAsync(URL, null);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Issues an http post request to the passed URL, passes string parameters
        /// and returns request response.
        /// </summary>
        /// <param name="URL">Http post request URL.</param>
        /// <param name="data">Dictionary of string data with string key.</param>
        /// <returns> 
        /// Http request response as string.
        /// </returns> 
        public async static Task<string> PostHttpRequestAsync(Uri URL, Dictionary<string, string> data)
        {
            try
            {
                HttpClient client = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();
                foreach (KeyValuePair<string, string> item in data)
                    form.Add(new StringContent(item.Value), item.Key);
                HttpResponseMessage response = await client.PostAsync(URL, form);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Issues an http post request to the passed URL, passes files parameters
        /// and returns request response.
        /// </summary>
        /// <param name="URL">Http post request URL.</param>
        /// <param name="files">Dictionary of files data with string key.</param>
        /// <returns> 
        /// Http request response as string.
        /// </returns> 
        public async static Task<string> PostHttpRequestAsync(Uri URL, Dictionary<string, StorageFile> files)
        {
            try
            {
                HttpClient client = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();
                foreach (KeyValuePair<string, StorageFile> item in files)
                {
                    IRandomAccessStream stream = await item.Value.OpenAsync(FileAccessMode.Read);
                    DataReader reader = new DataReader(stream.GetInputStreamAt(0));
                    byte[] file = new byte[stream.Size];
                    await stream.ReadAsync(file.AsBuffer(), (uint)stream.Size, Windows.Storage.Streams.InputStreamOptions.None);
                    form.Add(new StreamContent(new MemoryStream(file)), item.Key.Split('.')[0], item.Key);
                }
                HttpResponseMessage response = await client.PostAsync(URL, form);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Issues an http post request to the passed URL, passes string and files parameters
        /// and returns request response.
        /// </summary>
        /// <param name="URL">Http post request URL.</param>
        /// <param name="data">Dictionary of string data with string key.</param>
        /// <param name="files">Dictionary of files data with string key.</param>
        /// <returns> 
        /// Http request response as string.
        /// </returns> 
        public async static Task<string> PostHttpRequestAsync(Uri URL, Dictionary<string, string> data, Dictionary<string, StorageFile> files)
        {
            try
            {
                HttpClient client = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();
                foreach (KeyValuePair<string, string> item in data)
                    form.Add(new StringContent(item.Value), item.Key);
                foreach (KeyValuePair<string, StorageFile> item in files)
                {
                    IRandomAccessStream stream = await item.Value.OpenAsync(FileAccessMode.Read);
                    DataReader reader = new DataReader(stream.GetInputStreamAt(0));
                    byte[] file = new byte[stream.Size];
                    await stream.ReadAsync(file.AsBuffer(), (uint)stream.Size, Windows.Storage.Streams.InputStreamOptions.None);
                    form.Add(new StreamContent(new MemoryStream(file)), item.Key.Split('.')[0], item.Key);
                }
                HttpResponseMessage response = await client.PostAsync(URL, form);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Issues an http get request to the passed URL
        /// and returns request response.
        /// </summary>
        /// <param name="URL">Http get request URL.</param>
        /// <returns> 
        /// Http request response as string.
        /// </returns> 
        public async static Task<string> GetHttpRequestAsync(Uri URL)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(URL);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
