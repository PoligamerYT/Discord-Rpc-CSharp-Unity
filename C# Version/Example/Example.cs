using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRichPresence;

class Example
{
    private DiscordRpc.EventHandlers handlers;
    private DiscordRpc.RichPresence presence;

    static void Main(string[] args)
    {
        this.handlers = default(DiscordRpc.EventHandlers);
        DiscordRpc.Initialize("Bot ID", ref this.handlers, true, null);
        this.handlers = default(DiscordRpc.EventHandlers);
        DiscordRpc.Initialize("Bot ID", ref this.handlers, true, null);
        this.presence.details = "Text 1";
        this.presence.state = "Text 2";
        this.presence.largeImageKey = "Image 1";
        this.presence.smallImageKey = "Image 2";
        this.presence.largeImageText = "Image 1 Text";
        this.presence.smallImageText = "Image 2 Text";
        DiscordRpc.UpdatePresence(ref this.presence);
    }
}