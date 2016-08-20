using System;
using Akka.Actor;
using AkkaNetSpike.Messages;

namespace AkkaNetSpike.Actor
{
    internal class PlaybackActor : ReceiveActor
    {
        public PlaybackActor()
        {
            Receive<PlayMovieMessage>(message => HandlePlayMovieMessage(message));
        }

        private void HandlePlayMovieMessage(PlayMovieMessage message)
        {
            Console.WriteLine($"Received {message.UserId} {message.MovieTitle}");
        }
    }
}