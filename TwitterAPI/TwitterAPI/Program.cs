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
            Console.WriteLine("Twitter API");

            try
            {
                var consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
                var consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
                var token = ConfigurationManager.AppSettings["Token"];
                var tokenSecret = ConfigurationManager.AppSettings["TokenSecret"];

                var service = new TwitterService(consumerKey, consumerSecret);
                service.AuthenticateWith(token, tokenSecret);

                var options = new SendTweetOptions
                {
                    Status = string.Format("{0} {1}", DateTime.Now, "C# Twitter API Test")
                };

                Console.WriteLine("Tweet status: {0}", options.Status);

                var status = service.SendTweet(options);

                Console.WriteLine(
                    status.Id > 0 ? "Tweet looks good, id greater than zero: {0}" : "Issue tweeting, returned id: {0}",
                    status.Id);

                Console.WriteLine("Read tweets from Home Timeline");

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
