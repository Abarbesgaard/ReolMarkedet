using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class EnumMapperVareType
    {
        public Dictionary<EVareType, string> enumToStringMapping = new Dictionary<EVareType, string>(); 
        public EnumMapperVareType() 
        {
            enumToStringMapping.Add(EVareType.Tøj, "Tøj");
            enumToStringMapping.Add(EVareType.Ting, "Ting");
        }

        public string GetStringValueFromEnum(EVareType VareType) 
        {
            if(enumToStringMapping.TryGetValue(VareType, out string stringvalue)) 
            {
                return stringvalue;
            }
            else { return string.Empty; }
        }

    }

    

   
}
