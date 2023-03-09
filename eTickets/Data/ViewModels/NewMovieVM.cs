using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [Display(Name ="Movie name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Movie Description required")]
        [Display(Name = "Movie Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price in $")]
        [Display(Name = "Price is required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Movie poster URL is required")]
        [Display(Name = "Movie poster URL")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Start date is required ")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required ")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Movie category is required ")]
        [Display(Name = "Movie category")]
        public MovieCategory MovieCategory { get; set; }

        //Relations
        [Required(ErrorMessage = "Select actor(s) ")]
        [Display(Name = "Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }
        [Required(ErrorMessage = "Select a cinema")]
        [Display(Name = "Movie cinema is required")]
        public int CinemaId { get; set; }
        [Required(ErrorMessage = "Select a producer")]
        [Display(Name = "Movie producer is required")]
        public int ProducerId { get; set; }
       


    }
}
