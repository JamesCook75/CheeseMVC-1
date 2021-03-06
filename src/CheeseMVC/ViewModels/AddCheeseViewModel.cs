﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }
        public CheeseType Type { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        public Cheese CreateCheese(string name, string description, CheeseType type, int rating)
        {
            Cheese newCheese = new Cheese
            {
                Name = name,
                Description = description,
                Type = type,
                Rating = rating
            };

            return newCheese;

        }

        public AddCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>();
            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Hard).ToString(),
                Text = CheeseType.Hard.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Soft).ToString(),
                Text = CheeseType.Soft.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Fake).ToString(),
                Text = CheeseType.Fake.ToString()
            });
        }
    }
}
