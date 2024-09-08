using ToDoApp.BAL.ToDoItemServices;
using ToDoApp.BAL.UserServices;
using ToDoApp.DAL.AppDBContext;
using ToDoApp.Domain;
using ToDoApp.UI.RegisterForms;

namespace ToDoApp.UI.AppForm
{
    public partial class ToDoAppForm : Form
    {
        private readonly ToDoItemServices _services;
        private readonly int _userId;
        private ListViewItem _draggedItem;
        private Point _mouseDownLocation;
        private readonly User _user;

        public ToDoAppForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            var dbContext = new AppDbContext();
            var userServices = new UserServices(dbContext);
            _user = userServices.GetUserById(_userId);
            _services = new ToDoItemServices(dbContext);
            lnklblUserName.Text = _user.UserName.ToUpper().Trim();
            LoadToDoItems();

        }
        private void LoadToDoItems()
        {
            List<ToDoItem> items = _services.GetUserToDoItems(_userId);
            lvToDoList.Items.Clear();
            lvToDoChecked.Items.Clear();

            foreach (var toDoIt in items)
            {
                ListViewItem lvItem = new ListViewItem(toDoIt.ToDoItemID.ToString());
                lvItem.SubItems.Add(toDoIt.Title);
                lvItem.SubItems.Add(toDoIt.Description);
                lvItem.SubItems.Add(toDoIt.DueDate.ToShortDateString());
                lvItem.SubItems.Add(toDoIt.IsCompleted ? "✓" : "X");

                if (toDoIt.IsCompleted)
                {
                    lvToDoChecked.Items.Add(lvItem);
                }
                else
                {
                    lvToDoList.Items.Add(lvItem);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ToDoItem toDoItem = new ToDoItem
                {
                    Title = txtTitle.Text,
                    Description = rtxtDescription.Text,
                    DueDate = dtDueDate.Value,
                    IsCompleted = false,
                    UserID = _userId
                };

                _services.AddToDoItems(toDoItem, _userId);
                LoadToDoItems();

                MessageBox.Show("Görev başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvToDoList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
                _draggedItem = lvToDoList.GetItemAt(e.X, e.Y);
            }
        }
        private void lvToDoList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _draggedItem != null)
            {

                if ((Math.Abs(e.X - _mouseDownLocation.X) > SystemInformation.DragSize.Width / 2) ||
                    (Math.Abs(e.Y - _mouseDownLocation.Y) > SystemInformation.DragSize.Height / 2))
                {
                    lvToDoList.DoDragDrop(_draggedItem, DragDropEffects.Move);
                }
            }
        }
        private void lvToDoChecked_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void lvToDoChecked_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                try
                {
                    ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                    int toDoItemId = int.Parse(draggedItem.SubItems[0].Text);
                    _services.CompleteToDoItem(toDoItemId);
                    lvToDoList.Items.Remove(draggedItem);
                    draggedItem.SubItems[4].Text = "✓";
                    lvToDoChecked.Items.Add(draggedItem);
                    LoadToDoItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Aynı satırı olduğu yere ekleyemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void lvToDoChecked_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
                _draggedItem = lvToDoChecked.GetItemAt(e.X, e.Y);
            }
        }
        private void lvToDoChecked_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _draggedItem != null)
            {

                if ((Math.Abs(e.X - _mouseDownLocation.X) > SystemInformation.DragSize.Width / 2) ||
                    (Math.Abs(e.Y - _mouseDownLocation.Y) > SystemInformation.DragSize.Height / 2))
                {
                    lvToDoChecked.DoDragDrop(_draggedItem, DragDropEffects.Move);
                }
            }
        }
        private void lvToDoList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void lvToDoList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                try
                {
                    ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                    int toDoItemId = int.Parse(draggedItem.SubItems[0].Text);
                    _services.UncompleteToDoItem(toDoItemId);
                    lvToDoChecked.Items.Remove(draggedItem);
                    draggedItem.SubItems[4].Text = "X";
                    lvToDoList.Items.Add(draggedItem);
                    LoadToDoItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Aynı satırı olduğu yere ekleyemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void lnklblUserName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserUpdate userUpdateForm = new UserUpdate(_userId);
            userUpdateForm.Show();
        }
        private void lvToDoList_ItemActivate(object sender, EventArgs e)
        {
            if (lvToDoList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvToDoList.SelectedItems[0];
                txtTitle.Text = selectedItem.SubItems[1].Text;
                rtxtDescription.Text = selectedItem.SubItems[2].Text;
                dtDueDate.Value = DateTime.Parse(selectedItem.SubItems[3].Text);

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvToDoList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvToDoList.SelectedItems[0];
                int toDoItemId = int.Parse(selectedItem.SubItems[0].Text);
                _services.DeleteToDoItem(toDoItemId);
                LoadToDoItems();
                ClearFormFields();
                MessageBox.Show("Görev başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lvToDoChecked.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvToDoChecked.SelectedItems[0];
                int toDoItemId = int.Parse(selectedItem.SubItems[0].Text);

                ToDoItem toDoItem = new ToDoItem
                {
                    ToDoItemID = toDoItemId,
                    Title = txtTitle.Text,
                    Description = rtxtDescription.Text,
                    DueDate = dtDueDate.Value,
                    UserID = _userId
                };

                _services.UpdateToDoItem(toDoItem);
                LoadToDoItems();
                ClearFormFields();
                MessageBox.Show("Görev başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvToDoList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvToDoList.SelectedItems[0];
                int toDoItemId = int.Parse(selectedItem.SubItems[0].Text);

                ToDoItem toDoItem = new ToDoItem
                {
                    ToDoItemID = toDoItemId,
                    Title = txtTitle.Text,
                    Description = rtxtDescription.Text,
                    DueDate = dtDueDate.Value,
                    UserID = _userId
                };

                _services.UpdateToDoItem(toDoItem);
                LoadToDoItems();
                ClearFormFields();
                MessageBox.Show("Görev başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lvToDoChecked.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvToDoChecked.SelectedItems[0];
                int toDoItemId = int.Parse(selectedItem.SubItems[0].Text);

                ToDoItem toDoItem = new ToDoItem
                {
                    ToDoItemID = toDoItemId,
                    Title = txtTitle.Text,
                    Description = rtxtDescription.Text,
                    DueDate = dtDueDate.Value,
                    UserID = _userId
                };

                _services.UpdateToDoItem(toDoItem);
                LoadToDoItems();
                ClearFormFields();
                MessageBox.Show("Görev başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void ClearFormFields()
        {
            txtTitle.Clear();
            rtxtDescription.Clear();
            dtDueDate.Value = DateTime.Now;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }
        private void txtSearchDo_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearchDo.Text.ToLower();
            FilterListView(lvToDoList, filterText);
        }
        private void txtSearchCompleted_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearchCompleted.Text.ToLower();
            FilterListView(lvToDoChecked, filterText);
        }
        private void FilterListView(ListView listView, string filterText)
        {
            foreach (ListViewItem item in listView.Items)
            {
                bool itemVisible = false;

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(filterText))
                    {
                        itemVisible = true;
                        break;
                    }
                }

                item.BackColor = itemVisible ? Color.White : Color.Gray;
                item.ForeColor = itemVisible ? Color.Black : Color.Gray;
            }
        }
        private void lvToDoChecked_ItemActivate(object sender, EventArgs e)
        {
            if (lvToDoChecked.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvToDoChecked.SelectedItems[0];
                txtTitle.Text = selectedItem.SubItems[1].Text;
                rtxtDescription.Text = selectedItem.SubItems[2].Text;
                dtDueDate.Value = DateTime.Parse(selectedItem.SubItems[3].Text);

            }
        }
    }
}
