using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISolver
{
    class Attributes_params
    {
        public string AttID;
        public string AttName;
        public string AttValue;
        public string AttValueHQ;

    }
    class Attributes_base
    {
        /*public string GearDamage;
        public string GearDamage_HQ;
        public string GearMagic_Damage;
        public string GearMagic_Damage_HQ;
        public string GearDefense;
        public string GearDefense_HQ;
        public string GearMagic_Defense;
        public string GearMagic_Defense_HQ;*/
    }
    class Gear
    {
        public string GearID;
        public string GearIcon;
        public string GearName;
        public string GearLevel_item;
        public string GearCategory_name;
        public string GearKind_name;
        public string GearMateria_slot;
        public List<Jobs> GearClassJobs;
        public List<Attributes_params> GearAttr;
    }
}
