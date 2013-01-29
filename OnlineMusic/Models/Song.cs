using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMusic.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string SongName { get; set; }
        public string FileUrl { get; set; }
        public string FileSize { get; set; }
        public string FileFormat { get; set; }
        public int PlayCount { get; set; }
        public int Download { get; set; }
        public DateTime UploadDate { get; set; }

        public int SongerID { get; set; } 
        public int AlbumID { get; set; }
        public int SongTypeID { get; set; }

        public virtual Songer Songer { get; set; }
        public virtual Album Album { get; set; }
        public virtual SongType SongType { get; set; }
    }
}