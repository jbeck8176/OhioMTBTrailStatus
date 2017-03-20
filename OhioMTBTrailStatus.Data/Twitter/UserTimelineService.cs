using System;
using System.Collections.Generic;
using System.Text;

namespace OhioMTBTrailStatus.Data.Twitter
{
	public class UserTimelineService
	{
		public string ConsumerKey { get; set; }
		public string ConsumerSecret { get; set; }
		public string Token { get; set; }
		public string TokenSecret { get; set; }

		public object GetUserTimeline(string user, int count)
		{
			Tweetinvi.Auth.SetUserCredentials(this.ConsumerKey, this.ConsumerSecret, this.Token, this.TokenSecret);

			var userTimelineParams = new Tweetinvi.Parameters.UserTimelineParameters()
			{
				ExcludeReplies = true,
				IncludeRTS = false,
				TrimUser = true,
				MaximumNumberOfTweetsToRetrieve = count
			};

			Tweetinvi.Timeline.GetUserTimeline(user, userTimelineParams);
			return new object();

		}
    }
}
