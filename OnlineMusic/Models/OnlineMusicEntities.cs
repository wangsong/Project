using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace OnlineMusic.Models
{
    public class OnlineMusicContext : DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<Album> Album { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Songer> Songer { get; set; }
        public DbSet<SongType> SongType { get; set; }
    }

    public class OnlineMusicDBInitailizer : DropCreateDatabaseIfModelChanges<OnlineMusicContext>
    {
        protected override void Seed(OnlineMusicContext context)
        {
            var Songer = new List<Songer>()
                {
                    new Songer{Name="张杰", Sex="男",Nationality="中国", Birthplace="四川成都",Birthdate=DateTime.Parse ("1982-12-20")},
                    new Songer{Name="陈奕迅",Sex="男",Nationality="中国", Birthplace="广东东莞",Birthdate=DateTime.Parse ("1972-07-27")},
                    new Songer{Name="周杰伦", Sex="男",Nationality="中国", Birthplace="台湾",Birthdate=DateTime.Parse ("1979-01-18")},
                    new Songer{Name="王力宏", Sex="男",Nationality="美国", Birthplace="纽约罗切斯特",Birthdate=DateTime.Parse ("1976-05-11")},
                    new Songer{Name="张学友", Sex="男",Nationality="中国", Birthplace="香港",Birthdate=DateTime.Parse ("1961-07-11")},
                    new Songer{Name="张惠妹", Sex="女",Nationality="中国", Birthplace="台湾",Birthdate=DateTime.Parse ("1972-08-09")},
                    new Songer{Name="孙燕姿", Sex="女",Nationality="新加坡", Birthplace="新加坡",Birthdate=DateTime.Parse ("1978-07-23")},
                    new Songer{Name="张韶涵", Sex="女",Nationality="中国", Birthplace="台湾",Birthdate=DateTime.Parse ("1982-01-19")},
                    new Songer{Name="刘若英", Sex="女",Nationality="中国", Birthplace="台湾",Birthdate=DateTime.Parse ("1970-06-01")},
                    new Songer{Name="王菲", Sex="女",Nationality="中国", Birthplace="北京",Birthdate=DateTime.Parse ("1969-08-08")},
                };
            Songer.ForEach(s => context.Songer.Add(s));
            context.SaveChanges();

            var Album = new List<Album>() 
            {
                new Album{ AlbumName ="明天过后",   AlbumUrl=@"images\张杰.jpg",IssueDate=DateTime.Parse ("2008-08-27")},
                new Album{ AlbumName ="陈奕迅48首选",  AlbumUrl=@"images\陈奕迅.jpg",IssueDate=DateTime.Parse ("2008-12-23")},
                new Album{ AlbumName ="十二新作", AlbumUrl=@"images\周杰伦.jpg", IssueDate=DateTime.Parse ("2012-12-28")},
                new Album{ AlbumName ="火力全开 新歌+精选",  AlbumUrl=@"images\王力宏.jpg",IssueDate=DateTime.Parse ("2011-09-30")},
                new Album{ AlbumName ="学友光年世界巡回演唱会",  AlbumUrl=@"images\张学友.jpg",IssueDate=DateTime.Parse ("2009-01-27")},
                new Album{ AlbumName ="你在看我吗", AlbumUrl=@"images\张惠妹.jpg", IssueDate=DateTime.Parse ("2011-04-27")},
                new Album{ AlbumName ="逆光", AlbumUrl=@"images\孙燕姿.jpg", IssueDate=DateTime.Parse ("2011-03-08")},
                new Album{ AlbumName ="有形的翅膀", AlbumUrl=@"images\张韶涵.jpg", IssueDate=DateTime.Parse ("2012-10-12")},
                new Album{ AlbumName ="很爱很爱你",  AlbumUrl=@"images\刘若英.jpg",IssueDate=DateTime.Parse ("2008-02-22")},
                new Album{ AlbumName ="情菲得意-The 1st Complete Collection",  AlbumUrl=@"images\王菲.jpg",IssueDate=DateTime.Parse ("2005-04-17")},
            };
            Album.ForEach(s => context.Album.Add(s));
            context.SaveChanges();

            var SongType = new List<SongType>()
            {
                new SongType{ TypeName="流行"},
                new SongType{ TypeName="经典"},
                new SongType{ TypeName="R&B"},
                new SongType{ TypeName="校园"},
                new SongType{ TypeName="对唱"},
                new SongType{ TypeName="影视"},
                new SongType{ TypeName="粤语"},
                new SongType{ TypeName="舞曲"},
            };
            SongType.ForEach(s => context.SongType.Add(s));
            context.SaveChanges();

            var Song = new List<Song>()
            {
                new Song{SongName="我们都一样",FileUrl=@"\Musics\我们都一样.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =3,Download=1,UploadDate=DateTime.Now,SongerID=1,AlbumID=1,SongTypeID=1},
                new Song{SongName="明天过后",FileUrl=@"\Musics\明天过后.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =0,Download=1,UploadDate=DateTime.Now,SongerID=1,AlbumID=1,SongTypeID=1},
                new Song{SongName="远走高飞",FileUrl=@"\Musics\远走高飞.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =0,Download=1,UploadDate=DateTime.Now,SongerID=1,AlbumID=1,SongTypeID=1},
                new Song{SongName="天下",FileUrl=@"\Musics\天下.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =0,Download=1,UploadDate=DateTime.Now,SongerID=1,AlbumID=1,SongTypeID=1},
                new Song{SongName="往事随风",FileUrl=@"\Musics\往事随风.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =3,Download=1,UploadDate=DateTime.Now,SongerID=1,AlbumID=1,SongTypeID=1},

                new Song{SongName="每一个明天",FileUrl=@"\Musics\每一个明天.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =1,Download=1,UploadDate=DateTime.Now,SongerID=2,AlbumID=2,SongTypeID=1},
                new Song{SongName="K歌之王",FileUrl=@"\Musics\K歌之王.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =2,Download=1,UploadDate=DateTime.Now,SongerID=2,AlbumID=2,SongTypeID=1},
                new Song{SongName="与我常在",FileUrl=@"\Musics\与我常在.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =3,Download=1,UploadDate=DateTime.Now,SongerID=2,AlbumID=2,SongTypeID=1},
                new Song{SongName="岁月如歌",FileUrl=@"\Musics\岁月如歌.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =4,Download=1,UploadDate=DateTime.Now,SongerID=2,AlbumID=2,SongTypeID=1},
                new Song{SongName="十面埋伏",FileUrl=@"\Musics\十面埋伏.mp3",FileSize="3.2MB" ,FileFormat ="mp3",PlayCount =8,Download=1,UploadDate=DateTime.Now,SongerID=2,AlbumID=2,SongTypeID=1},
            };
            Song.ForEach(s => context.Song.Add(s));
            context.SaveChanges();

            var Admin = new List<Admin>()
            {
                new Admin{ UserName="admin",Password="admin"},
                new Admin {UserName ="user",Password="user"}
            };
            Admin.ForEach(s => context.Admin.Add(s));
            context.SaveChanges();
        }
    }
}