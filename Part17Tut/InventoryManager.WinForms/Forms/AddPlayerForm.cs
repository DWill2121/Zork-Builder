using System.Windows.Forms;

namespace InventoryManager.WinForms.Forms
{
    public partial class AddPlayerForm : Form
    {
        public string PlayerName 
        { 
            get => nameTextBox.Text;
            set => nameTextBox.Text = value; 
        }
        public AddPlayerForm()
        {
            InitializeComponent();
        }
    }
}
