using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Zork_Builder.Data
{
	public class Room : INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;

		public string Name { get; set; }

		
	}
}
