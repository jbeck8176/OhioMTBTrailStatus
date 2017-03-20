using System;
using System.Collections.Generic;
using System.Text;

namespace OhioMTBTrailStatus.Data.Models
{
    public class Trail: OhioMTBTrailStatusBase
    {
		public string Name { get; set; }
		public string Address { get; set; }
		public string Website { get; set; }
		public DateTimeOffset LastUpdated { get; set; }
	}
}
