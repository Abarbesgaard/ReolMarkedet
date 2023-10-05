using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class EnumMapperReol
    {
        public Dictionary<ETypeAfReol, string> enumToStringmapping = new Dictionary<ETypeAfReol, string>();

        public EnumMapperReol() 
        {
            enumToStringmapping.Add(ETypeAfReol.AflåstGlasSkab, "AflåstGlasSkab");
            enumToStringmapping.Add(ETypeAfReol.AflåstGlasSkabHylde, "AflåstGlasSkabHylde");
            enumToStringmapping.Add(ETypeAfReol.GulvPlads, "GulvPlads");
            enumToStringmapping.Add(ETypeAfReol.AlmindeligReol, "AlmindeligReol");

            
        }

        public string GetStringValueFromEnum(ETypeAfReol enumValue) 
        {
            if (enumToStringmapping.TryGetValue(enumValue, out string stringValue))
            {
                return stringValue;
            }
            else { return null; }
        }

       
    }
}
