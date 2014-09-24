#Twitter API Simple Console Demo

Simple console application to use the TweetSharp package (https://github.com/danielcrenna/tweetsharp) to read a users timeline.  Toyed with the idea of doing all the authentication through REST (no package) but felt it was overkill after looking through this excellent guide:  Toyed with writing it all following this excellent guide: http://www.i-avington.com/Posts/Post/making-a-twitter-oauth-api-call-using-c

To use set up application credentials (this will produce an API key and secret and an access token and secret): https://dev.twitter.com/

Get the TweetSharp by running the following in the package manager console: Install-Package TweetSharp

Replace the four keys in the app.config:
```
    <add key="ConsumerKey" value="YOUR_CONSUMER_KEY" />
    <add key="ConsumerSecret" value="YOUR_CONSUMER_SECRET" />
    <add key="Token" value="YOUR_TOKEN" />
    <add key="TokenSecret" value="YOUR_TOKEN_SECRET" />
```