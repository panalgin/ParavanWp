using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParavanWp.Model
{
    public class WpPost
    {
        public ulong post_author { get; set; }
        public DateTime post_date { get; set; }
        public DateTime post_date_gmt { get; set; }
        public string post_content { get; set; }
        public string post_title { get; set; }
        public string post_status { get; set; }
        public string comment_status { get; set; }
        public string ping_status { get; set; }
        public string post_name { get; set; }
        public DateTime post_modified { get; set; }
        public DateTime post_modified_gmt { get; set; }
        public string guid { get; set; }
        public string post_type { get; set; }

        public WpPost(string content, string title)
        {
            post_author = 1;
            post_date = DateTime.Now;
            post_date_gmt = post_date.ToUniversalTime();
            post_content = content;
            post_title = title;
            post_status = "publish";
            comment_status = "open";
            ping_status = "open";
            post_name = post_title; //seo url friendly
            post_modified = post_date;
            post_modified_gmt = post_date_gmt;
            guid = ""; //http://wordpress.dev/?p=1
            post_type = "post";
        }
    }
}
