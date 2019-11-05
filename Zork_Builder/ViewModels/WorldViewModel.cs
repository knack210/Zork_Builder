using Zork_Builder.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zork_Builder.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public World World { get; set; }       

    }
}
