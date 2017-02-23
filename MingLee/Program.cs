using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace MingLee
{
    class Program
    {
        static void Main(string[] args) => new Program().Start();
        

        public DiscordClient _client;

        public void Start()
        {
            _client = new DiscordClient();

            _client.ServerAvailable += (s, e) =>
            {
                e.Server.GetChannel(234750115171008522).SendMessage("Ming Lee is Online :white_check_mark: ");

            };

            _client.MessageReceived += async (s, e) =>
            {
                if (!e.Message.IsAuthor)
                {
                    //await e.Channel.SendMessage(e.Message.Text);
                    if (e.Message.Text.ToLower() == "weather")
                    {
                        await e.Channel.SendMessage("weather");
                    }

                    if (e.Message.Text.ToLower() == "hi")
                    {
                        await e.Channel.SendMessage("Hi!");
                    }
                    if (e.Message.Text.ToLower() == "demarco?")
                    {
                        await e.Channel.SendMessage("Demarco can't read this!");
                    }
                    if (e.Message.Text.ToLower() == "pizza?")
                    {
                        await e.Channel.SendMessage("Ey b0ss can i habe a piza pls! https://youtu.be/6McY361EGvE?t=50");

                    }
                    if (e.Message.Text.ToLower() == "!list")
                    {
                        await e.Channel.SendMessage("Heres all my commands thus far 1.hi 2.weather 3.demarco? 4.pizza? 5.Hillary or Trump? 6.rekt 7.kms 8.!list");

                    }
                    if (e.Message.Text.ToLower() == "hillary or trump?")
                    {
                        await e.Channel.SendMessage("Hillary and Trump killed Harambe! Vote for Harambe! :gorilla: ");

                    }
                    if (e.Message.Text.ToLower() == "rekt")
                    {
                        await e.Channel.SendMessage("Rekt");

                    }
                    if (e.Message.Text.ToLower() == "kms")
                    {
                        await e.Channel.SendMessage("https://streamable.com/25bo?t=1.8");

                    }
                    if (e.Message.Text.ToLower() == "who is jason to you?")
                    {
                        await e.Channel.SendMessage("My Older brother");

                    }
                    if (e.Message.Text.ToLower() == "sing to me")
                    {
                        await e.Channel.SendMessage(" https://www.youtube.com/watch?v=qlQItNqYg80 ");

                    }
                    if (e.Message.Text.ToLower() == "who are you")
                    {
                        await e.Channel.SendMessage(" :minglee: ");

                    }
                }

            }; 
           
          _client.ExecuteAndWait(async () => {
                await _client.Connect("", TokenType.Bot); 
                
            });
            

        }
    }
}