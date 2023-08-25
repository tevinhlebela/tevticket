using System;   
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TevTicket.Data;



namespace TevTicket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set;}
        
        
        public string Name{ get;set;}

        public string Description{ get; set;}

        public double Price{ get; set;}

        public string ImageUrl{ get; set;}

        public DateTime StartDate {get; set;}

        public DateTime EndDate {get; set;}

        public MovieCategory MovieCategory{ get; set;}



    }
}
