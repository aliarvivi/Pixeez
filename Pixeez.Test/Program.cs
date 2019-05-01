using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixeez.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () => await Program.PixivDemo()).Wait();
        }

        static async Task PixivDemo()
        {
            // Create Tokens
            var tokens = await Pixeez.Auth.AuthorizeAsync("xup6u43838@gmail.com", "78951236");

            //var work = await tokens.GetWorksAsync(51796422);
            var user = await tokens.GetUsersAsync(11972);
            foreach (Objects.User userElent in user){
                Console.WriteLine(userElent.Account);

            }
            //var myfeeds = await tokens.GetMyFeedsAsync(0,true);
            //var usersWorks = await tokens.GetUsersWorksAsync(11972);
            //var usersFavoriteWorks = await tokens.GetUsersFavoriteWorksAsync(11972);
            //var ranking = await tokens.GetRankingAllAsync();
            //var search = await tokens.SearchWorksAsync("フランドール・スカーレット", mode: "tag");
        }
    }
}
