using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMusic.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public string AlbumUrl { get; set; }
        public DateTime IssueDate { get; set; } //发布时间
    }
}