using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Winston Koczkodaj 
 * Date: 7/11/17
 */
namespace W8C1
{
    public abstract class Human
    {
        /// <summary>
        /// Abstract Human Class
        /// </summary>

        // Private Instance Variables
        private string _name;

        // Public Properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        // Constructors
        public Human(string name)
        {
            this.Name = name;
        }

        // Private Methods

        // Public Methods
        public abstract void DisplaySkills();
    }

}