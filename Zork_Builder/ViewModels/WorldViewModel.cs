using System;
using Zork_Builder.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zork_Builder.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public BindingList<Player> Players { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public World World
        {
            set
            {
                if (mWorld != value)
                {
                    mWorld = value;
                    Players = new BindingList<Player>(mWorld.Players);
                    Rooms = new BindingList<Room>(mWorld.Rooms);
                }

                else
                {
                    Players = new BindingList<Player>(Array.Empty<Player>());
                    Rooms = new BindingList<Room>(Array.Empty<Room>());
                }
            }
        }

        public WorldViewModel(World world = null)
        {
            World = world;
        }

        private World mWorld;

    }
}
