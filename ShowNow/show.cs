
using ShowNow.lib;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShowNow
{
    public partial class Show : Form
    {

        private NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
        private string ipAddress;
        private Ctrl control;

        public Show()
        {
            InitializeComponent();
            control = new Ctrl();
            initForm();


        }

        private void initForm()
        {
            //  Show Now Icon in the Notification tray
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon("Resources/ShowNowICO.ico");
            notifyIcon.Visible = true;
            notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("Show", null, ShowForm);
            notifyIcon.ContextMenuStrip.Items.Add("Copy: Public IP", null, (s, e) =>
            {
                Clipboard.SetText(ipAddress);
            });
            notifyIcon.ContextMenuStrip.Items.Add("Exit", null, ExitApplication);

            //// WIndow size
            //this.Size = new Size((int)(Screen.PrimaryScreen.WorkingArea.Width * 0.3), (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.5)); // 30% of screen width, fixed height
            this.Size = new Size(500, (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.5)); // 30% of screen width, fixed height
            PositionFormAtBottomRight();
            //////
            // remove hte top border
            ////
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.White;
            ShowIcon = false;
            ////
            // Handle tray icon double-click
            notifyIcon.DoubleClick += ShowForm;

            // Hide the form when it's minimized
            this.Resize += (s, e) =>
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Hide();
                }
            };

            // Allow dragging of the borderless form
            this.MouseDown += show_MouseDown;

            // TImer setup
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000;
            timer.Tick += async (sender, e) =>
            {
                ipAddress = await control.GetPublicIpArddress();
                notifyIcon.Text = $"Public IP: {ipAddress}";
                lblIP02.Invoke(new Action(() => { lblIP02.Text = ipAddress; }));
            };
            timer.Start();

            //Fetch IP on startup
            Task.Run(async () =>
            {
                ipAddress = await control.GetPublicIpArddress();
                notifyIcon.Text = $"Public IP: {ipAddress}";
                lblIP02.Invoke(new Action(() => { lblIP02.Text = ipAddress; }));

            });

            this.WindowState = FormWindowState.Normal;
            PositionFormAtBottomRight();
            this.ShowInTaskbar = false;


        }

        private void PositionFormAtBottomRight()
        {
            // Position the form at the bottom-right corner
            var workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(
                workingArea.Width - this.Width,
                workingArea.Height - this.Height
            );
        }
        private void show_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow dragging of borderless form
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                var msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void Show_Load(object sender, EventArgs e)
        {
            //
            txtBoxInterface01.Text = string.Join(Environment.NewLine,control.NetwokDetails());
            Debug.WriteLine(string.Join(Environment.NewLine, control.NetwokDetails()));
        }



        private void butMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PositionFormAtBottomRight();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
        private void ShowForm(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            PositionFormAtBottomRight(); // Reposition to ensure it stays in the bottom-right
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            timer.Stop();
            notifyIcon.Dispose();
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAllInterface01_Click(object sender, EventArgs e)
        {

        }

        private void butPubIPCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ipAddress);
        }
    }
}
