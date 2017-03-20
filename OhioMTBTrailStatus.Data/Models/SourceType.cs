using System;
using System.Collections.Generic;
using System.Text;

namespace OhioMTBTrailStatus.Data.Models
{
    public class SourceType: OhioMTBTrailStatusBase
    {
		public string Name { get; set; }
		public string CredentialJSON { get; set; }
	}
}
