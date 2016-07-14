using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_Lesson9.Models
{
    public class Album
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Album()
        {

        }

        /// <summary>
        /// This is the constructor that adds a title
        /// </summary>
        /// <param name="Title"></param>
        public Album(string Title)
        {
            this.Title = Title;
        }

        public string Title { get; set; }
        public Genre Genre { get; set; }
    }
}