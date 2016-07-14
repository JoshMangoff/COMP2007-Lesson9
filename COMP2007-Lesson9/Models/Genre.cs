using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_Lesson9.Models
{
    public class Genre
    {
        /// <summary>
        /// This is an empty constructor
        /// </summary>
        public Genre()
        {

        }

        /// <summary>
        /// This constructor takes a parameter
        /// </summary>
        /// <param name="Name"></param>
        public Genre(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }
    }
}