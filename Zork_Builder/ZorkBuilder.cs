using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork_Builder.Data;

namespace Zork_Builder
{
	public partial class ZorkBuilder : Form
	{
		private World World
		{
			get => mWorld;
			set => mWorld = value;
		}

		public ZorkBuilder()
		{
			InitializeComponent();
		}

        private void ZorkBuilder_Load(object sender, EventArgs e)
        {

        }

		private void SelectFileButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
				filenameTextBox.Text = openFileDialog.FileName;
			}
		}

		private World mWorld;
	}
}
