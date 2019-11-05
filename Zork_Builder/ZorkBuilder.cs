using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork_Builder.Data;
using Zork_Builder.ViewModels;

namespace Zork_Builder
{
	public partial class ZorkBuilder : Form
	{
		private WorldViewModel ViewModel
		{
			get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
		}

		public ZorkBuilder()
		{
			InitializeComponent();
            ViewModel = new WorldViewModel();
		}

        private void ZorkBuilder_Load(object sender, EventArgs e)
        {

        }

		private void SelectFileButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
				ViewModel.Filename = openFileDialog.FileName;
			}
		}

		private WorldViewModel mViewModel;

        private void PlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
