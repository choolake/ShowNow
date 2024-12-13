namespace ShowNow
{
    partial class Show
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button butMinimize;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show));
            butMinimize = new Button();
            lblLogo = new Label();
            lblTitle = new Label();
            VeriticalFlow01 = new FlowLayoutPanel();
            horizontalPanel1 = new FlowLayoutPanel();
            HorizontalPanel2 = new FlowLayoutPanel();
            flowHLayout2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            allIntf01 = new CheckBox();
            lblAllInterface01 = new Label();
            lblPubIp01 = new Label();
            lblIP02 = new Label();
            butPubIPCopy = new Button();
            txtBoxInterface01 = new TextBox();
            VeriticalFlow01.SuspendLayout();
            horizontalPanel1.SuspendLayout();
            HorizontalPanel2.SuspendLayout();
            flowHLayout2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // butMinimize
            // 
            butMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butMinimize.BackgroundImage = Properties.Resources.minimize_icon;
            butMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            butMinimize.FlatAppearance.BorderSize = 0;
            butMinimize.FlatStyle = FlatStyle.Flat;
            butMinimize.Location = new Point(471, 4);
            butMinimize.Margin = new Padding(3, 4, 3, 4);
            butMinimize.Name = "butMinimize";
            butMinimize.Size = new Size(20, 31);
            butMinimize.TabIndex = 0;
            butMinimize.UseVisualStyleBackColor = true;
            butMinimize.Click += butMinimize_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Image = Properties.Resources.ShowNowICO;
            lblLogo.Location = new Point(241, 0);
            lblLogo.MinimumSize = new Size(250, 100);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(250, 100);
            lblLogo.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Informal Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(23, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 54);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Show Now";
            lblTitle.Click += lblTitle_Click;
            // 
            // VeriticalFlow01
            // 
            VeriticalFlow01.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VeriticalFlow01.AutoSize = true;
            VeriticalFlow01.Controls.Add(horizontalPanel1);
            VeriticalFlow01.Controls.Add(HorizontalPanel2);
            VeriticalFlow01.Controls.Add(flowHLayout2);
            VeriticalFlow01.Controls.Add(txtBoxInterface01);
            VeriticalFlow01.FlowDirection = FlowDirection.TopDown;
            VeriticalFlow01.Location = new Point(2, -1);
            VeriticalFlow01.Name = "VeriticalFlow01";
            VeriticalFlow01.Size = new Size(500, 596);
            VeriticalFlow01.TabIndex = 4;
            // 
            // horizontalPanel1
            // 
            horizontalPanel1.Controls.Add(butMinimize);
            horizontalPanel1.FlowDirection = FlowDirection.RightToLeft;
            horizontalPanel1.Location = new Point(3, 3);
            horizontalPanel1.Name = "horizontalPanel1";
            horizontalPanel1.Size = new Size(494, 35);
            horizontalPanel1.TabIndex = 0;
            // 
            // HorizontalPanel2
            // 
            HorizontalPanel2.Controls.Add(lblLogo);
            HorizontalPanel2.Controls.Add(lblTitle);
            HorizontalPanel2.FlowDirection = FlowDirection.RightToLeft;
            HorizontalPanel2.Location = new Point(3, 44);
            HorizontalPanel2.Name = "HorizontalPanel2";
            HorizontalPanel2.Size = new Size(494, 105);
            HorizontalPanel2.TabIndex = 1;
            // 
            // flowHLayout2
            // 
            flowHLayout2.Controls.Add(flowLayoutPanel1);
            flowHLayout2.Controls.Add(lblPubIp01);
            flowHLayout2.Controls.Add(lblIP02);
            flowHLayout2.Controls.Add(butPubIPCopy);
            flowHLayout2.Location = new Point(3, 155);
            flowHLayout2.Name = "flowHLayout2";
            flowHLayout2.Size = new Size(494, 52);
            flowHLayout2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(allIntf01);
            flowLayoutPanel1.Controls.Add(lblAllInterface01);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(215, 44);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // allIntf01
            // 
            allIntf01.Appearance = Appearance.Button;
            allIntf01.AutoSize = true;
            allIntf01.Checked = true;
            allIntf01.CheckState = CheckState.Checked;
            allIntf01.Font = new Font("Segoe UI", 7F);
            allIntf01.Location = new Point(3, 16);
            allIntf01.Name = "allIntf01";
            allIntf01.Size = new Size(32, 25);
            allIntf01.TabIndex = 7;
            allIntf01.Text = "Up";
            allIntf01.UseVisualStyleBackColor = true;
            allIntf01.CheckedChanged += allIntf01_CheckedChanged;
            // 
            // lblAllInterface01
            // 
            lblAllInterface01.AutoSize = true;
            lblAllInterface01.Font = new Font("Segoe UI", 5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllInterface01.Location = new Point(3, 1);
            lblAllInterface01.Name = "lblAllInterface01";
            lblAllInterface01.Size = new Size(47, 12);
            lblAllInterface01.TabIndex = 6;
            lblAllInterface01.Text = "Interfaces";
            lblAllInterface01.Click += lblAllInterface01_Click;
            // 
            // lblPubIp01
            // 
            lblPubIp01.AutoSize = true;
            lblPubIp01.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPubIp01.Location = new Point(224, 0);
            lblPubIp01.Name = "lblPubIp01";
            lblPubIp01.Size = new Size(90, 25);
            lblPubIp01.TabIndex = 3;
            lblPubIp01.Text = "Public IP";
            // 
            // lblIP02
            // 
            lblIP02.AutoSize = true;
            lblIP02.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIP02.Location = new Point(320, 0);
            lblIP02.Name = "lblIP02";
            lblIP02.Size = new Size(92, 25);
            lblIP02.TabIndex = 4;
            lblIP02.Text = "Loading...";
            lblIP02.Click += label1_Click;
            // 
            // butPubIPCopy
            // 
            butPubIPCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butPubIPCopy.BackgroundImage = Properties.Resources.copy_icon;
            butPubIPCopy.BackgroundImageLayout = ImageLayout.Zoom;
            butPubIPCopy.FlatAppearance.BorderSize = 0;
            butPubIPCopy.FlatStyle = FlatStyle.Flat;
            butPubIPCopy.Location = new Point(418, 4);
            butPubIPCopy.Margin = new Padding(3, 4, 3, 4);
            butPubIPCopy.Name = "butPubIPCopy";
            butPubIPCopy.Size = new Size(21, 21);
            butPubIPCopy.TabIndex = 5;
            butPubIPCopy.UseVisualStyleBackColor = true;
            butPubIPCopy.Click += butPubIPCopy_Click;
            // 
            // txtBoxInterface01
            // 
            txtBoxInterface01.BackColor = SystemColors.Window;
            txtBoxInterface01.Dock = DockStyle.Fill;
            txtBoxInterface01.Location = new Point(3, 213);
            txtBoxInterface01.Multiline = true;
            txtBoxInterface01.Name = "txtBoxInterface01";
            txtBoxInterface01.ReadOnly = true;
            txtBoxInterface01.ScrollBars = ScrollBars.Both;
            txtBoxInterface01.Size = new Size(494, 275);
            txtBoxInterface01.TabIndex = 8;
            // 
            // Show
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(500, 600);
            Controls.Add(VeriticalFlow01);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Show";
            Load += Show_Load;
            VeriticalFlow01.ResumeLayout(false);
            VeriticalFlow01.PerformLayout();
            horizontalPanel1.ResumeLayout(false);
            HorizontalPanel2.ResumeLayout(false);
            HorizontalPanel2.PerformLayout();
            flowHLayout2.ResumeLayout(false);
            flowHLayout2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ListView listView1;
        private Label lblLogo;
        private Label lblTitle;
        private FlowLayoutPanel VeriticalFlow01;
        private FlowLayoutPanel horizontalPanel1;
        private FlowLayoutPanel HorizontalPanel2;
        private FlowLayoutPanel flowHLayout2;
        private Label lblPubIp01;
        private Label lblIP02;
        private Button butPubIPCopy;
        private TextBox txtBoxInterface01;
        private CheckBox allIntf01;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblAllInterface01;
    }
}
