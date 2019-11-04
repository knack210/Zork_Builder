using System.Collections.Generic;

namespace Zork_Builder.Data
{
	public class Player
	{
		public string Name { get; set; }	

		public int Health { get; set; }	

		public int Score { get; set; }

		public List<Room> Inventory { get; set; }
	}
}
