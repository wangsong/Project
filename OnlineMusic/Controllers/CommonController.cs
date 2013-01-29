using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using OnlineMusic.Models;

namespace OnlineMusic.Controllers
{
    public class CommonController : Controller
    {
        OnlineMusicContext db = new OnlineMusicContext();
        [ChildActionOnly]
        public ActionResult Menu()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Container()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Rank() //排行榜
        {
            var ranklist = db.Song.Include(g => g.Songer).OrderByDescending(g => g.PlayCount);
            return View(ranklist);
        }

        public ActionResult Player()
        {
            var url = db.Song.ToList();
            return View(url);
        }

        public String PlayerList()
        {
            var url = (from s in db.Song
                      from a in db.Album
                      where s.AlbumID==a.AlbumID
                      select new { 
                          		    title=s.SongName,
		                            artist=s.Songer.Name,
		                            album=a.AlbumName,
		                            cover=a.AlbumUrl,
		                            mp3=s.FileUrl,
                                    playcount=s.PlayCount
                          }).OrderByDescending(s=>s.playcount);
            //var list = (db.Song.Include(g => g.Album).OrderByDescending(g => g.PlayCount);
       
            string str = Newtonsoft.Json.JsonConvert.SerializeObject(url );
            return str;
        }
    }
}
