using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpzMail.Api.Model
{
    public class NumberTextSegmentField
    {
        public NumberTextSegmentFieldType FieldType { get; set; }
        public NumberAndStringModifier Modifier { get; set; }
        public string Value { get; set; }
    }
}
