using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum SegmentField
    {
        [XmlEnum("firstName")]
        FirstName = 0,
        [XmlEnum("lastName")]
        LastName = 1,
        [XmlEnum("email")]
        Email = 2,
        [XmlEnum("houseNo")]
        HouseNo = 3,
        [XmlEnum("address1")]
        Address1 = 4,
        [XmlEnum("address2")]
        Address2 = 5,
        [XmlEnum("town")]
        Town = 6,
        [XmlEnum("county")]
        County = 7,
        [XmlEnum("country")]
        Country = 8,
        [XmlEnum("postCode")]
        PostCode = 9,
        [XmlEnum("dateOfBirth")]
        DateOfBirth = 10,
        [XmlEnum("gender")]
        Gender = 11,
        [XmlEnum("job")]
        Job = 12,
        [XmlEnum("dateAdded")]
        DateAdded = 13,
        [XmlEnum("customField1")]
        CustomField1 = 14,
        [XmlEnum("customField2")]
        CustomField2 = 15,
        [XmlEnum("customField2")]
        CustomField3 = 16,
        [XmlEnum("customField2")]
        CustomField4 = 17,
        [XmlEnum("customField2")]
        CustomField5 = 18,
        [XmlEnum("customField2")]
        CustomField6 = 19,
        [XmlEnum("customField2")]
        CustomField7 = 20,
        [XmlEnum("customField2")]
        CustomField8 = 21,
        [XmlEnum("customField2")]
        CustomField9 = 22,
        [XmlEnum("customField2")]
        CustomField10 = 23
    }
}
