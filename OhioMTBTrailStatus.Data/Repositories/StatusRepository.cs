using OhioMTBTrailStatus.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OhioMTBTrailStatus.Data.Repositories
{
	public interface IStatusRepository : Base.IRepository<Status>
	{ }

	public class StatusRepository : Base.OhioMTBTrailStatusBaseRepository<Status>, IStatusRepository
    {
		public StatusRepository() : base("Statuses") {
		}
    }
}
