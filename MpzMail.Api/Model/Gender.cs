using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum Gender
    {
        [XmlEnum("Male")]
        Male,
        [XmlEnum("Female")]
        Female
    }
}
