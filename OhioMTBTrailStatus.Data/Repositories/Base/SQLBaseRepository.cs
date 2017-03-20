using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OhioMTBTrailStatus.Data.Repositories.Base
{
	public abstract class SQLBaseRepository
	{
		public static SqlConnection OMTSDbConnection()
		{
			var connection = new SqlConnection(Properties.Resources.ResourceManager.GetString("sqlConnectionString"));
		
			return connection;
		}
	}
}
