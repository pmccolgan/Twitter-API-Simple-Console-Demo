using System;
using System.Configuration;
using TweetSharp;

namespace TwitterAPI
{
    class Program
    {
 
        static void Main()
        {
            // https://github.com/danielcrenna/tweetsharp
            Console.WriteLine("Google Calender API v3");

            try
            {
                var consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
                var consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
                var token = ConfigurationManager.AppSettings["Token"];
                var tokenSecret = ConfigurationManager.AppSettings["TokenSecret"];

                var service = new TwitterService(consumerKey, consumerSecret);
                service.AuthenticateWith(token, tokenSecret);

                var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
                
                foreach (var tweet in tweets)
                {
                    Console.WriteLine("{0} says '{1}'", tweet.User.ScreenName, tweet.Text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception encountered: {0}", e.Message);
            }

            Console.WriteLine("Press any key to continue...");

            while (!Console.KeyAvailable)
            {
            }
        }
    }
}
