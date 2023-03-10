using System;
using System.Net.Http;
using Newtonsoft.Json;

public class CPHInline
{

    // El teu webhook del canal va aquí
    const string discordWebhook = "El Webhook del teu discord";

    public bool Execute()
    {

        var user = args["userName"];

        CPH.LogInfo($"{user} està fent un clip....");

        // assegura't que l'stream està en línia
        if (CPH.ObsIsStreaming())
        {

            var clip = CPH.CreateClip();

            // publica el clip al xat de Twitch
            CPH.SendMessage($"{user} ha fet un clipassu! {clip.Url}");

            // publica el clip al canal de Discord
            CPH.LogInfo($"pujant el clip a discord....");

            string discordJson = JsonConvert.SerializeObject(new
            {
                content = $"{user} ha fet un clip\n{clip.Url}"
            });

            MultipartFormDataContent dataContent = new MultipartFormDataContent();
            dataContent.Add(new StringContent(discordJson), "payload_json");

            HttpClient httpClient = new HttpClient();
            httpClient.PostAsync(discordWebhook, dataContent).Wait();
            httpClient.Dispose();

        }
        else
        {
            CPH.SendMessage($"@{user}, No es poden fer clips mentre l'stream està offline");
        }

        return true;
    }
}