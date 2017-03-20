using System;
using System.Collections.Generic;
using System.Text;

namespace OhioMTBTrailStatus.Data.Models
{
    public class TrailStatus : OhioMTBTrailStatusBase
    {
		public string Decsription { get; set; }
		public int Trail_Id { get; set; }
		public int Source_Id { get; set; }
		public int Status_Id { get; set; }
		public DateTimeOffset Created { get; set; }
	}
}
