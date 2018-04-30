using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPoo
{
    class Unicorn
    {
        private string name;
        private DateTime birthdate;
        private string rgbColor;
        private string description;
        private List<SpecialAbility> specialAbilityList; //TODO: instanciate

        private string Name
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
                }
            }
        }
        public DateTime Birthdate{ get; set; }

        public string RGBColor
        {
            get
            {
                return rgbColor;
            }
            set
            {
                if (value.Length == 5)
                {
                    this.rgbColor = value;
                }
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
                    this.rgbColor = value;
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
