using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork_Builder.Data;
using Zork_Builder.ViewModels;
using System.Linq;

namespace Zork_Builder.Forms
{
    public partial class ZorkBuilder : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
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

        private bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            { 
                mIsWorldLoaded = value;
                mainTabControl.Enabled = mIsWorldLoaded;
            }
        }

        public ZorkBuilder()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
        }

        private void ZorkBuilder_Load(object sender, EventArgs e)
        {

        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
           
        }       

        private void PlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deletePlayersButton.Enabled = playersListBox.SelectedItem != null;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            using (AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                if (addPlayerForm.ShowDialog() == DialogResult.OK)
                {

                    Player player = new Player { Name = addPlayerForm.PlayerName };
                    ViewModel.Players.Add(player);
                }
            }
        }

        private void DeletePlayersButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Players.Remove((Player)playersListBox.SelectedItem);
                playersListBox.SelectedItem = ViewModel.Players.FirstOrDefault();
            }
        }

		#region Main Menu
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                IsWorldLoaded = true;
            }
        }

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld();

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ViewModel.Filename = saveFileDialog.FileName;
				ViewModel.SaveWorld();
			}
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		private WorldViewModel mViewModel;
		private bool mIsWorldLoaded;

		
	}
}
