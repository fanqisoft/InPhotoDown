using Newtonsoft.Json;
using photoDownLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace photoDownLibrary.FrameWork
{
    public static class baseTool
    {
        //public delegate void ChangeLabelEventHandle(string text);
        public static  Action<string> ChangeLabel;
        //public static  ChangeLabelEventHandle ChangeLabel;
        /// <summary>
        /// 返回相册的照片下载地址
        /// </summary>
        /// <param name="pid">相册ID</param>
        /// <returns></returns>
        public static IList<String> getPersonPhotoList(String pid)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
            String url = $@"https://www.in66.com/webview/photo/detail?pid={pid}";
            HttpResponseMessage response = httpClient.GetAsync(new Uri(url)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            personPhoto entity = JsonConvert.DeserializeObject<personPhoto>(result);
            var datas = entity.data.photo_info.photos;
            List<string> photoAddList = new List<string>();
            if (datas != null && datas.Count != 0)
            {
                datas.ForEach(a =>
                {
                    photoAddList.Add(a.url_origin);
                });
            }
            return photoAddList;
        }

        /// <summary>
        /// 根据用户in号码获取用户ID
        /// </summary>
        /// <param name="inNumber">in号码</param>
        /// <returns>用户ID</returns>
        public static string getUidByInNumber(string inNumber = "fanqi_")
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
            String url = $@"http://www.in66.com/{inNumber}";
            HttpResponseMessage response = httpClient.GetAsync(new Uri(url)).Result;
            string uri = response.RequestMessage.RequestUri.Query.ToString();
            string uid = HttpUtility.ParseQueryString(uri).Get("uid");
            return uid;
        }

        public static IList<String> getAlbumList(string uid)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
            String url = $@"https://www.in66.com/webview/user/record?uid={uid}";
            HttpResponseMessage response = httpClient.GetAsync(new Uri(url)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            albumPhoto album = JsonConvert.DeserializeObject<albumPhoto>(result);
            List<String> albumIdList = new List<string>();
            if (album.data.items != null && album.data.items.Count != 0)
            {
                album.data.items.ForEach(a =>
                {
                    albumIdList.Add(a.id);
                });
            }
            return albumIdList;
        }
        public static void getPhotoByUrl(string path, List<string> url)
        {
            if (url == null && url.Count !=0)
            {
                return;
            }
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
            System.IO.FileStream fs;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            url.ForEach(a =>
            {
                string fileName = a.Substring(a.LastIndexOf('/') + 1);
                byte[] urlContents = httpClient.GetByteArrayAsync(a).Result;
                fs = new System.IO.FileStream($"{path}\\{fileName}", System.IO.FileMode.CreateNew);
                fs.Write(urlContents, 0, urlContents.Length);
                int index = url.IndexOf(a) + 1;
                string tishi = string.Empty;
                if(index == url.Count)
                {
                    tishi = "下载已完成";
                }
                else
                {
                    tishi = $@"{index} / {url.Count}";
                }
                ChangeLabel(tishi);
            });
        }
    }
}
