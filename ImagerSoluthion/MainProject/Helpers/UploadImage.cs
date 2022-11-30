using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MainForm.Helpers
{
    public static class UploadImage
    {
        public static async Task<List<string>> UploadImgbbAsync(List<string> ImagePaths)
        {
			const string ApiKey = "b83304fa4d2edf38b71f6eed04c2c6e4";
			List<string> LinksToUploadedImages = new List<string>();
			string ResponseJsonContent = string.Empty;

			using (HttpClient client = new HttpClient())
            {
				try
				{
					foreach (string imagePath in ImagePaths)
					{
						/* SORGU GONDERDIK VE JSON RESPONSE-U ELDE ETDIK: */
						string requestUrl = $"https://api.imgbb.com/1/upload?key={ApiKey}";
						MultipartFormDataContent content = new MultipartFormDataContent();
						string base64OfImage = Convert.ToBase64String(File.ReadAllBytes(imagePath));
						content.Add(new StringContent(base64OfImage), "image");
						HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUrl) { Content = content };
						HttpResponseMessage response = await client.SendAsync(request);
						ResponseJsonContent = await response.Content.ReadAsStringAsync();

						/* JSON RESPONSE-DAN LAZIMI HISSELERI EXTRACT EDEK: */
						JObject jsonObject = JObject.Parse(ResponseJsonContent);
						LinksToUploadedImages.Add(jsonObject.SelectToken("data.url").ToString());
					}

					///* ikinci parametre true vererek deyirikki 'log.txt' evvelceden variydisa yeniden yazma elave et uzerine false deseydik evvelkini yazilari silecekdi indi yazdiqlarimizi yazacaydi ora */
					//using (StreamWriter writeResponse = new StreamWriter($"{Environment.CurrentDirectory}\\responseJSON.txt", true))
					//{
					//	writeResponse.WriteLine(responseJsonContent);
					//	writeResponse.Flush();
					//}
				}
                catch { }
			}

			return LinksToUploadedImages;
		}
    }
}