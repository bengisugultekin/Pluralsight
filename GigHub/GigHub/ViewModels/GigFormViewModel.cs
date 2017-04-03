using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }  //dropdown listten seçtiğinin valuesunu alıyor o nedenle int/byte (string değil yani) eklediği sırayla eşleştiği için id si olmuş oluyor

        public IEnumerable<Genre> Genres { get; set; }
        public DateTime GetDateTime()
        {            
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));            
        }
    }
}