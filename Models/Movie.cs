using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
      // The Movie class contains an Id field, which is required by the database for the primary key.
      //
      // The DataType attribute on ReleaseDate specifies the type of the data (Date). With this attribute:
      //
      // The user is not required to enter time information in the date field.
      // Only the date is displayed, not time information.
      public class Movie
      {
          public int Id { get; set; }
          public string Title { get; set; }

          [DataType(DataType.Date)]
          public DateTime ReleaseDate { get; set; }
          public string Genre { get; set; }
          public decimal Price { get; set; }
      }
}
