using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingLee
{
    class MyBot
    {
        DiscordClient discord;


        public MyBot()
        {
            discord = new DiscordClient(x =>
            

        public void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            //if (e.Message.IsAuthor) return;
            if (e.Message.Text.ToLower() == "Hi") {
                e.Channel.SendMessage("Hi");
            }
            

            }
        
        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
   
}
