using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpzMail.Api.Model
{
    public class SegmentFilter
    {
        public int GroupId { get; set; }
        public List<DateSegmentField> DateFilters { get; set; }
        public List<NumberTextSegmentField> NumberTextFilters { get; set; }
        public MatchType MatchType { get; set; }
    }
}
