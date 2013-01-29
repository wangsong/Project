using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMusic.Models
{
    /// <summary>
    /// 歌曲类型
    /// </summary>
    public class SongType
    {
        public int SongTypeID { get; set; }

        public string TypeName { get; set; }
    }
}