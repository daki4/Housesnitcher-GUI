using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.GUI.Controls;
using Housesnitcher_GUI.GUI.Controls.Complaints;
using Housesnitcher_GUI.GUI.Controls.Tasks;
using Housesnitcher_GUI.GUI.Events;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class MainForm : Form
    {
        User _user { get; }
        public void ForceUdate(object _, EventArgs __)
        {
            HydratePages();
        }

        // initializing the whole form and filling in the different data.
        void HydratePages()
        {
            {
                flpComplaintsHome.Controls.Clear();
                flpInShort.Controls.Clear();
                flowTasksHome.Controls.Clear();
                flpAdminComplaints.Controls.Clear();
                flpMyTasks.Controls.Clear();
                flpAdminTasks.Controls.Clear();
                flpAnnouncements.Controls.Clear();

                // populate the homepage
                foreach (var complaint in ComplaintHandler.AllComplaints().Take(10))
                {
                    flpComplaintsHome.Controls.Add(new ComplaintControl(complaint));
                }

                foreach (var task in TennantTaskHandler.AllTasks().Take(10))
                {
                    flowTasksHome.Controls.Add(new TaskControl(task));
                }

                // populate in-short section
                foreach (var complaint in ComplaintHandler.SpecificUserComplaints(_user))
                {
                    flpInShort.Controls.Add(new CompactComplaintControl(complaint));
                }

                foreach (var task in TennantTaskHandler.SpecificUserTask(_user))
                {
                    flpMyTasks.Controls.Add(new UserTaskControl(_user.Username) { UpdateUsingObject = task });
                }

                // populate adminstrator page
                foreach (var complaint in ComplaintHandler.AllComplaints())
                {
                    flpAdminComplaints.Controls.Add(new AdminComplaintControl(complaint));
                }

                foreach (var task in TennantTaskHandler.AllTasks())
                {
                    flpAdminTasks.Controls.Add(new AdminTaskControl() { UpdateUsingObject = task });
                }

                foreach (var announcement in AnnouncementHandler.GetAnnouncements())
                {
                    flpAnnouncements.Controls.Add(new AnnouncementControl(announcement));
                }
            }
        }
        public MainForm(User user)
        {
            ForceRefreshEvent.RefreshNeeded += new EventHandler(ForceUdate);
            // reminder to the next person: keep this at the top ffs. Second time I fall for this in an hour.
            _user = user;
            InitializeComponent();
            ShowAppropriatePages();
            // if you have other important things to add to here, please respect the order.

            lblUserData.Text = _user.ToString();
            HydratePages();
        }


        // complaints creation section of the code, boring stuff.
        private void btnLodgeComplaint_Click(object sender, EventArgs e)
        {
            CreateComplaintForm newForm = new CreateComplaintForm(_user.Username);
            newForm.Show();
        }

        // after login check which pages should be shown
        private void ShowAppropriatePages()
        {
            HomeTabControl.TabPages.Clear();
            HomeTabControl.TabPages.Add(tpHomepage);
            HomeTabControl.TabPages.Add(tpSelf);
            if (_user.AuthLevel == ScopeLevel.Admin)
            {
                HomeTabControl.TabPages.Add(tpAdmin);
            }
            if (_user.AuthLevel == ScopeLevel.None)
            {
                return;
            }

            // keep this here, rules page, pls dont move stuff around
            HomeTabControl.TabPages.Add(RulesPage);
        }

        // logout button, duh.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }

        private void HomeTabControl_Selected(object sender, TabControlEventArgs e)
        {
            HydratePages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreateTaskForm().Show();
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            new CreateTaskForm().Show();
        }

        private void btnAnnounce_Click(object sender, EventArgs e)
        {
            new CreateAnnouncement(_user).Show();
        }
    }
}