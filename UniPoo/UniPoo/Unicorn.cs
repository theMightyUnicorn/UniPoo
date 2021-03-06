﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPoo
{
    public class Unicorn 
    {
        private string name;
        private DateTime birthdate;
        private string rgbColor;
        private string description;
        private List<SpecialAbility> specialAbilityList; //TODO: instantiate
        private int id;
        // TODO: Profile picture

        public Unicorn(string name, DateTime birthdate, string rgbColor, string description, params SpecialAbility[] specialAbilities)
        {
            this.name = name;
            this.birthdate = birthdate;
            this.rgbColor = rgbColor;
            this.description = description;
            this.specialAbilityList = new List<SpecialAbility>(specialAbilities);
        }

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Length <= 20)
                {
                    this.name = value;
                } else
                {
                    throw new Exception("The name is too long, it should be <= 20");
                }
            }
        }
        public DateTime Birthdate{
            get {
                return this.birthdate;
            }
            set
            {
                this.birthdate = value == null ? new DateTime(1900, 1, 1) : value;
            }
        }

        public string RGBColor
        {
            get
            {
                return rgbColor;
            }
            set
            {
                this.rgbColor = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length <= 500)
                {
                    this.description = value;
                } else
                {
                    throw new Exception("The description is too long");
                }
            }
        }

        public List<SpecialAbility> SpecialAbilityList
        {
            get
            {
                return specialAbilityList;
            }
            set
            {
                this.specialAbilityList = value;
                //bool noDuplicate = true;
                //for(int i = this.specialAbilityList)
                //if (noDuplicate)
                //{
                //    this.rgbColor = value;
                //}
            }
        }

    }

    
}
