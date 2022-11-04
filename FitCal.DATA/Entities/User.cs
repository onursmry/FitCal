using System;
using System.Collections.Generic;
using System.Net.Mail;
using FitCal.DATA.Enums;

namespace FitCal.DATA.Entities
{
    public class User:BaseEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte Height { get; set; }
        public double Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        public UserTypes UserType { get; set; }
        public UserStates IsActive { get; set; }
        //user can add a photo to project resource file
        public string PhotoPath { get; set; }
        public byte UserPhoto { get; set; }

        //a user has one password
        public Password Password { get; set; }

        //a user has many meals
        public ICollection<Meal> Meals { get; set; }
    }
}