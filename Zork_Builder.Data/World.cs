using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Zork_Builder.Data
{
	public class World : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public List<Player> Players { get; set; }

		public List<Room> Rooms { get; set; }

        public World()
        {
            Players = new List<Player>();
            Rooms = new List<Room>();
        }
	}
}
