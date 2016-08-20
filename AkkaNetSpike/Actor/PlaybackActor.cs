using System;
using Akka.Actor;
using AkkaNetSpike.Messages;

namespace AkkaNetSpike.Actor
{
    internal class PlaybackActor : UntypedActor
    {
        protected override void OnReceive(object message)

        {
            var movieMessage = message as PlayMovieMessage;
            if (movieMessage != null)
            {
                var playMovieMessage = movieMessage;
                Console.WriteLine($"Received {playMovieMessage.UserId} {playMovieMessage.MovieTitle}");
                return;
            }

            Unhandled(message);
        }
    }
}