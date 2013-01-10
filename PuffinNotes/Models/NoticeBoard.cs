using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace PuffinNotes.Models
{
    public class NoticeBoard
    {
        public string name { get; set; }
        public string description { get; set; }
        public string owner { get; set; }
        public int iD { get; set; }

    }

    public class NoticeBoardDBContext : DbContext
    {
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
    }
}