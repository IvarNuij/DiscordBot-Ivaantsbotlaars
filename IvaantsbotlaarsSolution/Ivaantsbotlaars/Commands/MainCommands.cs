using DSharpPlus;
using DSharpPlus.Interactivity;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity.Extensions;

namespace Ivaantsbotlaars.Commands
{
    internal class MainCommands : BaseCommandModule
    {
        [Command("Ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel
                .SendMessageAsync("Pong")
                    .ConfigureAwait(false);
        }

        [Command("Add")]
        public async Task Add(CommandContext ctx, int numberOne, int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne + numberTwo).ToString())
                    .ConfigureAwait(false);
        }

        [Command("Response")]
        public async Task Response(CommandContext ctx)
        {
            //Detect message
            var interactivity = ctx.Client.GetInteractivity();
            
            var userInput = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel)
                .ConfigureAwait(false);

            //Response
            await ctx.Channel
                .SendMessageAsync(userInput.Result.Content);
        }

        [Command("Play")]
        public async Task Play(CommandContext ctx, string link)
        {
            var interactivity = ctx.Client.GetInteractivity();

            if (interactivity)
        }
    }
}