using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixeez.Objects
{
    public class RefWork
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("image_urls")]
        public ImageUrls ImageUrls { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class RefBookmark
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tags")]
        public IList<string> Tags { get; set; }
    }

    public class MyFeed
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("post_time")]
        public string PostTime { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("ref_work")]
        public RefWork RefWork { get; set; }

        [JsonProperty("ref_bookmark")]
        public RefBookmark RefBookmark { get; set; }
    }

}
