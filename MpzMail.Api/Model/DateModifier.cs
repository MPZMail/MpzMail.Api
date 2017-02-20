using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum DateModifier
    {
        [XmlElement("Is")]
        Is = 0,
        [XmlElement("Is After")]
        IsAfter = 1,
        [XmlElement("Is Before")]
        IsBefore = 2,
        [XmlElement("Day Is")]
        DayIs = 3,
        [XmlElement("Month Is")]
        MonthIs = 4,
        [XmlElement("Year Is")]
        YearIs = 5
    }
}
