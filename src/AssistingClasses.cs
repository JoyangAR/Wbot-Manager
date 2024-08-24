using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssistingClasses
{
    public class AppConfig
    {
        public bool headless { get; set; }
        public bool isGroupReply { get; set; }
        public string webhook { get; set; }
        public bool downloadMedia { get; set; }
        public bool replyUnreadMsg { get; set; }
        public string CustomInjectionFolder { get; set; }
        public bool quoteMessageInReply { get; set; }
        public ServerConfig server { get; set; }
    }

    public class ServerConfig
    {
        public int port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    public class SmartReply
    {
        public List<string> suggestions { get; set; }
        public bool clicktosend { get; set; }
    }

    public class BotConfiguration
    {
        public AppConfig appconfig { get; set; }
        public List<BotSection> bot { get; set; }
        public List<string> blocked { get; set; }
        public List<string> allowed { get; set; }
        public string noMatch { get; set; }
        public SmartReply smartreply { get; set; }
    }

    public class BotSection
    {
        public string sectionname { get; set; }
        public string sectiongroup { get; set; }
        public List<string> contains { get; set; }
        public List<string> exact { get; set; }
        public string response { get; set; }

        [JsonConverter(typeof(FileConverter))]
        public List<string> file { get; set; }

        public int afterseconds { get; set; }
        public string webhook { get; set; }
        public bool responseAsCaption { get; set; }
    }

    public class FileConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<string>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);

            if (token.Type == JTokenType.String)
            {
                return new List<string> { token.Value<string>() };
            }
            else if (token.Type == JTokenType.Array)
            {
                return token.ToObject<List<string>>();
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            List<string> files = value as List<string>;

            if (files != null && files.Count > 0)
            {
                // If the list contains more than one element or the first element is not empty, serialize the list normally.
                if (files.Count > 1 || !string.IsNullOrEmpty(files[0]))
                {
                    serializer.Serialize(writer, files);
                }
                else
                {
                    // If the list has only one element that is empty, serialize only that element without brackets.
                    serializer.Serialize(writer, files[0]);
                }
            }
            else
            {
                // If the list is null or empty, serialize an empty list.
                serializer.Serialize(writer, new List<string>());
            }
        }
    }
}
