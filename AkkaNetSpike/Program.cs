using System;
using System.Threading.Tasks;
using Akka.Actor;
using AkkaNetSpike.Actor;

namespace AkkaNetSpike
{
    internal class Program
    {
        private static ActorSystem _actorSystem;

        private static void Main(string[] args)
        {
            _actorSystem = ActorSystem.Create("MovieActorSystem");
            var props = Props.Create<PlaybackActor>();
            var playbackActorRef = _actorSystem.ActorOf(props, nameof(PlaybackActor));

            Console.ReadLine();

            _actorSystem.Terminate().Wait();
        }
    }
}