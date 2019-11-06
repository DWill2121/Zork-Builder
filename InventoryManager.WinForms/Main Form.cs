using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using InventoryManager.Data;
using InventoryManager.WinForms.ViewModels;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace InventoryManager.WinForms
{
    public partial class MainForm : Form
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
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
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

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPlayersButton_Click(object sender, EventArgs e)
        {

        }

        private void DeletePlayersButton_Click(object sender, EventArgs e)
        {

        }
    }
}
