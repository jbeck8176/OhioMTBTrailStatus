using System;
using System.Collections.Generic;
using System.Text;

namespace OhioMTBTrailStatus.Data.Models
{
    public class Source : OhioMTBTrailStatusBase
    {
		public string Name { get; set; }
		public string UserName { get; set; }
		public string URL { get; set; }
		public int SourceType_Id { get; set; }
	}
}
