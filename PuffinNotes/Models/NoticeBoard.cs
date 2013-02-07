using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PuffinNotes.Models
{
    public class NoticeBoard
    {
        [Key] public int boardId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string owner { get; set; }
        public List<Note> notes { get; set; }    
    }

    public class NoticeBoardDBContext : DbContext
    {
        public DbSet<NoticeBoard> NoticeBoards { get; set; }

        public DbSet<Note> Notes { get; set; }
    }
}