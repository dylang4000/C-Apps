namespace _2024_25_02_03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemsButton_Click(object sender, EventArgs e)
        {
           
            if (InventoryTreeView.SelectedNode != null)
            {
                foreach (string item in ItemsBox.CheckedItems)
                {
                    
                    InventoryTreeView.SelectedNode.Nodes.Add(item);
                }
            }
            else { MessageBox.Show("select a box to enter items into"); }
        }
        public int boxcount = 0;
        private void AddBoxButton_Click(object sender, EventArgs e)
        {
            boxcount++;
            InventoryTreeView.Nodes.Add("box" + boxcount);
        }

        private void InventoryTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            BoxRenameTextbox.Visible = true;
            BoxRenameButton.Visible = true;
        }

        private void BoxRenameButton_Click(object sender, EventArgs e)
        {

            InventoryTreeView.SelectedNode.Text = BoxRenameTextbox.Text;
            BoxRenameTextbox.Visible = false;
            BoxRenameButton.Visible = false;
        }
    }
}
