namespace _20260422_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnHome.Click += btnHome_Click;
            ShowScreen(new UC_Home());

        }

        // Button click events for UC/Home and Inventory from panelNav stimulus
        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Inventory());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Home());
        }

        // ShowScreen function on btnClick events
        private void ShowScreen(UserControl newScreen)
        {
            // Find existing controls and dispose them to free memory
            foreach (Control ctrl in panelContent.Controls)
            {
                ctrl.Dispose();
            }

            panelContent.Controls.Clear();           // Clear the controls
            newScreen.Dock = DockStyle.Fill;         // Set Dock to Fill
            panelContent.Controls.Add(newScreen);    // Add the UC to PanelContent
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)    // ???
        {

        }
    }
}