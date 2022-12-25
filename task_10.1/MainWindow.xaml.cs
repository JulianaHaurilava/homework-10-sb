using System.Windows;
using System.Windows.Controls;


namespace task_10._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Repository r;
        public MainWindow()
        {
            InitializeComponent();
            r = new Repository();
            usersList.ItemsSource = r.AllUsers;
        }
        public void UsersList_ItemActivate(object sender, System.EventArgs e)
        {
            textBox1.IsEnabled = true;
            User selectedUser = (User)usersList.SelectedItem;
            textBox1.Text = selectedUser.PhoneNumber;
        }

        public void Button_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                int index = FindIndex(r);
                r.AllUsers[index].PhoneNumber = textBox1.Text;
                textBox1.IsEnabled = false;
                textBox1.Text = "";
                usersList.Items.Refresh();
            }

        }

    

        private int FindIndex(Repository r)
        {
            int i = 0;
            foreach (User user in r.AllUsers)
            {
                if ((User)usersList.SelectedItem == user)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
