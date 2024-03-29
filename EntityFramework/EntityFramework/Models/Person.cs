﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models
{
    public class Person
    {
        // Id, ID, PersonId, PersonID <-- primary keys
        // And if the data type is `int` or `guid`
        // then EF will make the primary key an identity column.
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Weight { get; set; }
        public bool IsStarWarsFan { get; set; }

        [NotMapped]
        public bool IsAdmin { get; set; }

        // This property doesn't have a setter
        // so EF will ignore it when generating the database.
        public string Info
        {
            get
            {
                return $"{Name} ({BirthDate})";
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, BirthDate: {BirthDate.ToShortDateString()} Weight: {Weight}, IsStarWarsFan: {IsStarWarsFan}";
        }
    }
}
