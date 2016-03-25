# Pixeez

Pixiv api for .NET platforms

### Example

~~~cs
class Program
{
    static void Main(string[] args)
    {
        Task.Run(async () => await Program.PixivDemo()).Wait();
    }

    static async Task PixivDemo()
    {
        // Create Tokens
        var tokens = await Pixeez.Auth.AuthorizeAsync("username", "password");

        var work = await tokens.GetWorksAsync(51796422);
        var user = await tokens.GetUsersAsync(11972);
        var myfeeds = await tokens.GetMyFeedsAsync(true);
        var usersWorks = await tokens.GetUsersWorksAsync(11972);
        var usersFavoriteWorks = await tokens.GetUsersFavoriteWorksAsync(11972);
        var ranking = await tokens.GetRankingAllAsync();
        var search = await tokens.SearchWorksAsync("フランドール・スカーレット", mode: "tag");
    }
}
~~~

#### License

* MIT License

#### Thanks to

* [pixivpy](https://github.com/upbit/pixivpy)