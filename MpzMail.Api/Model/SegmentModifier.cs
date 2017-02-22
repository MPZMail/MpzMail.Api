using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum SegmentModifier
    {
        [XmlEnum("Equals")]
        Equals = 0,
        [XmlEnum("Doesnt Equal")]
        DoesntEqual = 1,
        [XmlEnum("Contains")]
        Contains = 2,
        [XmlEnum("Does Not Contain")]
        DoesNotContain = 3,
        [XmlEnum("Is Provided")]
        IsProvided = 4,
        [XmlEnum("Is Not Provided")]
        IsNotProvided = 5,
        [XmlEnum("Is")]
        Is = 6,
        [XmlEnum("Is After")]
        IsAfter = 7,
        [XmlEnum("Is Before")]
        IsBefore = 8,
        [XmlEnum("Day Is")]
        DayIs = 9,
        [XmlEnum("Month Is")]
        MonthIs = 10,
        [XmlEnum("Year Is")]
        YearIs = 11
    }
}
