using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PuffinNotes.Models
{
    public class Note
    {
      [Key] public int boardID { get; set; }
      public int noteID { get; set; }
      public string content { get; set; }
      public int placementCoordinates { get; set; }
      public string author { get; set; }
    }

}