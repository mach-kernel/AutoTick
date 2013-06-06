using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTick
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in SettingsSerializer.loadUsers())
            {
                userView.Items.Add(lvi);
            }

            latBox.Text = Properties.Settings.Default.latitude;
            longBox.Text = Properties.Settings.Default.longitude;

            tickSnooze.Text = Properties.Settings.Default.sleep_time.ToString();
            tzId.Text = Properties.Settings.Default.timezone_id;
            uaBox.Text =      Properties.Settings.Default.user_agent;
            gmBox.Text =      Properties.Settings.Default.gmt_offset;
            pAPIbox.Text =    Properties.Settings.Default.phewtick_server;
            locTail.Text =    Properties.Settings.Default.location_tail;
            scanTail.Text =   Properties.Settings.Default.scan_tail;
            refTail.Text =    Properties.Settings.Default.refresh_tail;
            verLB.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); 

        }

        private void menuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            uiTabs.SelectTab(menuTree.SelectedNode.Index);
        }

        private void addUsr_Click(object sender, EventArgs e)
        {
            edPan.Visible = true;
            saveUsr.Visible = true;
        }

        private void clPan_Click(object sender, EventArgs e)
        {
            edPan.Visible = false;
        }

        private void saveUsr_Click(object sender, EventArgs e)
        {
            ListViewItem newUsr = new ListViewItem();
            ListViewItem.ListViewSubItem newTk = new ListViewItem.ListViewSubItem();
            newUsr.Text = nameBx.Text;
            newTk.Text = tokeBx.Text;
            newUsr.SubItems.Add(newTk);

            userView.Items.Add(newUsr);

            List<ListViewItem> dongs = new List<ListViewItem>();
            foreach (ListViewItem item in userView.Items)
            {
                dongs.Add(item);
            }

            SettingsSerializer.saveUsers(dongs);

        }

        private void editUsr_Click(object sender, EventArgs e)
        {
            edPan.Visible = true;
            edBt.Visible = true;

            if (userView.CheckedItems.Count > 0)
            {
                nameBx.Text = userView.CheckedItems[0].Text;
                tokeBx.Text = userView.CheckedItems[0].SubItems[1].Text;
            }
            else
            {
                MessageBox.Show("You need something to edit, right guy?", "User error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void edBt_Click(object sender, EventArgs e)
        {
            userView.CheckedItems[0].Text = nameBx.Text;
            userView.CheckedItems[0].SubItems[1].Text = tokeBx.Text;

            List<ListViewItem> dongs = new List<ListViewItem>();
            foreach (ListViewItem item in userView.Items)
            {
                dongs.Add(item);
            }

            SettingsSerializer.saveUsers(dongs);
        }

        private void delUsr_Click(object sender, EventArgs e)
        {
            userView.Items.Remove(userView.CheckedItems[0]);

            List<ListViewItem> dongs = new List<ListViewItem>();
            foreach (ListViewItem item in userView.Items)
            {
                dongs.Add(item);
            }

            SettingsSerializer.saveUsers(dongs);
        }

        delegate void updateTickerDelegate(ListViewItem news); 

        private void updateTicker(ListViewItem news)
        {
            if (InvokeRequired)
            {
                Invoke(new updateTickerDelegate(updateTicker), news); 
            }
            else
            {
                tickView.Items.Add(news);
            }
        }

        delegate void updateStatsDelegate(); 

        private void updateStats()
        {
            if (InvokeRequired)
            {
                Invoke(new updateStatsDelegate(updateStats));
            }
            else
            {
                DateTime currently = DateTime.Now;
                lMeetup.Text = currently.ToString("HH:mm:ss");
                nMeetup.Text = currently.AddHours(1.0).ToString("HH:mm:ss");

                int points = 0;

                foreach (ListViewItem item in tickView.Items)
                {
                    points = points + Convert.ToInt32(item.SubItems[1].Text);
                }

                totPts.Text = points.ToString();
                avgPts.Text = Convert.ToString(points / tickView.Items.Count);
            }
        }

        private void botWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int dongs = 0;
            foreach (ListViewItem member in userView.Items)
            {
                if (member.Index == userView.Items.Count - 1)
                {
                    updateStats();
                    scanInt.Start();
                    Console.WriteLine(dongs);
                    PhewTick.updateLoc(userView.Items[member.Index].SubItems[1].Text);
                    break;
                }
                else
                {
                    scanInt.Stop();
                    for (int i = member.Index + 1; i < userView.Items.Count; i++)
                    {
                        PhewTick.updateLoc(userView.Items[member.Index].SubItems[1].Text);
                        string[] meetup = PhewTick.doScan(userView.Items[member.Index].SubItems[1].Text, userView.Items[i].SubItems[1].Text);

                        ListViewItem ticker = new ListViewItem();
                        ListViewItem.ListViewSubItem points = new ListViewItem.ListViewSubItem();
                        points.Text = meetup[1];
                        ticker.Text = userView.Items[member.Index].Text + " & " + userView.Items[i].Text;

                        ticker.SubItems.Add(points);
                        updateTicker(ticker);
                        System.Threading.Thread.Sleep(Properties.Settings.Default.sleep_time);
                        dongs++;
                    }
                }
            }
        }

        private void scanInt_Tick(object sender, EventArgs e)
        {
            botWorker.RunWorkerAsync();
        }

        private void enableBt_Click(object sender, EventArgs e)
        {
            scanInt.Enabled = true;
            scanInt.Start();
            statLB.Text = "Enabled";
            statLB.ForeColor = Color.Green;
            botWorker.RunWorkerAsync();
        }

        private void disBt_Click(object sender, EventArgs e)
        {
            scanInt.Stop();
            statLB.Text = "Disabled";
            statLB.ForeColor = Color.IndianRed;
        }

        private void updLoc_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.latitude = latBox.Text;
            Properties.Settings.Default.longitude = longBox.Text;

            Properties.Settings.Default.Save();
        }

        private void updSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.sleep_time = Convert.ToInt32(tickSnooze.Text);
            Properties.Settings.Default.timezone_id = tzId.Text;
            Properties.Settings.Default.user_agent = uaBox.Text;
            Properties.Settings.Default.gmt_offset = gmBox.Text;
            Properties.Settings.Default.phewtick_server = pAPIbox.Text;
            Properties.Settings.Default.location_tail = locTail.Text;
            Properties.Settings.Default.scan_tail = scanTail.Text;
            Properties.Settings.Default.refresh_tail = refTail.Text;

            Properties.Settings.Default.Save();
        }
    }
}
