namespace Windows_MediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Library");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Playlists");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Album");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Artists", 1, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Genre", 5, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Music", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Videos");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Pictures");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.panelPlaylist = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.organizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordedTVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyMediaInformationChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowInternetAccessToHomeMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.turnOnMeidaStreamingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createAutoPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabplaybt = new System.Windows.Forms.Button();
            this.tabburnbt = new System.Windows.Forms.Button();
            this.tabsyncbt = new System.Windows.Forms.Button();
            this.Playbt = new System.Windows.Forms.Button();
            this.Stopbt = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.roundButton1 = new Windows_MediaPlayer.RoundButton();
            this.backButton = new Windows_MediaPlayer.RoundButton();
            this.forwardButton = new Windows_MediaPlayer.RoundButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelLibrary.SuspendLayout();
            this.panelPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 405);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(709, 45);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "if_ic_arrow_back_48px_352020.png");
            this.imageList2.Images.SetKeyName(1, "if_ic_arrow_forward_48px_352024.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelLibrary);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(709, 346);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Library";
            treeNode1.Text = "Library";
            treeNode2.Name = "Playlists";
            treeNode2.Text = "Playlists";
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "Node1";
            treeNode3.SelectedImageKey = "if_cd_173172.png";
            treeNode3.Text = "Album";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node2";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Artists";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "Node3";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "Genre";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Music";
            treeNode7.Name = "Videos";
            treeNode7.Text = "Videos";
            treeNode8.Name = "Pictures";
            treeNode8.Text = "Pictures";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(151, 344);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "if_083_Music_183211.png");
            this.imageList1.Images.SetKeyName(1, "if_165-man-singer-1_3099417.png");
            this.imageList1.Images.SetKeyName(2, "if_ic_arrow_back_48px_352020.png");
            this.imageList1.Images.SetKeyName(3, "if_ic_arrow_forward_48px_352024.png");
            this.imageList1.Images.SetKeyName(4, "if_cd_173172.png");
            this.imageList1.Images.SetKeyName(5, "if_folder_cds_61606.png");
            // 
            // panelLibrary
            // 
            this.panelLibrary.Controls.Add(this.panelPlaylist);
            this.panelLibrary.Controls.Add(this.label1);
            this.panelLibrary.Location = new System.Drawing.Point(3, 11);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(312, 330);
            this.panelLibrary.TabIndex = 1;
            // 
            // panelPlaylist
            // 
            this.panelPlaylist.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelPlaylist.Controls.Add(this.label2);
            this.panelPlaylist.Location = new System.Drawing.Point(0, 100);
            this.panelPlaylist.Name = "panelPlaylist";
            this.panelPlaylist.Size = new System.Drawing.Size(312, 230);
            this.panelPlaylist.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Playlist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "library";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 344);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 28);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizeToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.createPlaylistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // organizeToolStripMenuItem
            // 
            this.organizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLibraryToolStripMenuItem,
            this.applyMediaInformationChangesToolStripMenuItem,
            this.toolStripSeparator1,
            this.sortByToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionToolStripMenuItem});
            this.organizeToolStripMenuItem.Name = "organizeToolStripMenuItem";
            this.organizeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.organizeToolStripMenuItem.Text = "Organize";
            // 
            // manageLibraryToolStripMenuItem
            // 
            this.manageLibraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem,
            this.videosToolStripMenuItem,
            this.picturesToolStripMenuItem,
            this.recordedTVToolStripMenuItem});
            this.manageLibraryToolStripMenuItem.Name = "manageLibraryToolStripMenuItem";
            this.manageLibraryToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.manageLibraryToolStripMenuItem.Text = "Manage library";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // videosToolStripMenuItem
            // 
            this.videosToolStripMenuItem.Name = "videosToolStripMenuItem";
            this.videosToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.videosToolStripMenuItem.Text = "Videos";
            // 
            // picturesToolStripMenuItem
            // 
            this.picturesToolStripMenuItem.Name = "picturesToolStripMenuItem";
            this.picturesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.picturesToolStripMenuItem.Text = "Pictures";
            // 
            // recordedTVToolStripMenuItem
            // 
            this.recordedTVToolStripMenuItem.Name = "recordedTVToolStripMenuItem";
            this.recordedTVToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.recordedTVToolStripMenuItem.Text = "Recorded TV";
            // 
            // applyMediaInformationChangesToolStripMenuItem
            // 
            this.applyMediaInformationChangesToolStripMenuItem.Name = "applyMediaInformationChangesToolStripMenuItem";
            this.applyMediaInformationChangesToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.applyMediaInformationChangesToolStripMenuItem.Text = "Apply media information changes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.sortByToolStripMenuItem.Text = "Sort by";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowInternetAccessToHomeMediaToolStripMenuItem,
            this.toolStripSeparator3,
            this.turnOnMeidaStreamingToolStripMenuItem});
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // allowInternetAccessToHomeMediaToolStripMenuItem
            // 
            this.allowInternetAccessToHomeMediaToolStripMenuItem.Name = "allowInternetAccessToHomeMediaToolStripMenuItem";
            this.allowInternetAccessToHomeMediaToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.allowInternetAccessToHomeMediaToolStripMenuItem.Text = "Allow Internet access to home media";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(266, 6);
            // 
            // turnOnMeidaStreamingToolStripMenuItem
            // 
            this.turnOnMeidaStreamingToolStripMenuItem.Name = "turnOnMeidaStreamingToolStripMenuItem";
            this.turnOnMeidaStreamingToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.turnOnMeidaStreamingToolStripMenuItem.Text = "Turn on meida streaming";
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPlaylistToolStripMenuItem1,
            this.createAutoPlaylistToolStripMenuItem});
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.createPlaylistToolStripMenuItem.Text = "Create Playlist";
            // 
            // createPlaylistToolStripMenuItem1
            // 
            this.createPlaylistToolStripMenuItem1.Name = "createPlaylistToolStripMenuItem1";
            this.createPlaylistToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.createPlaylistToolStripMenuItem1.Text = "Create playlist";
            // 
            // createAutoPlaylistToolStripMenuItem
            // 
            this.createAutoPlaylistToolStripMenuItem.Name = "createAutoPlaylistToolStripMenuItem";
            this.createAutoPlaylistToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.createAutoPlaylistToolStripMenuItem.Text = "Create auto playlist";
            // 
            // tabplaybt
            // 
            this.tabplaybt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabplaybt.Location = new System.Drawing.Point(476, 10);
            this.tabplaybt.Name = "tabplaybt";
            this.tabplaybt.Size = new System.Drawing.Size(75, 47);
            this.tabplaybt.TabIndex = 1;
            this.tabplaybt.Text = "Play";
            this.tabplaybt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabplaybt.UseVisualStyleBackColor = true;
            this.tabplaybt.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabburnbt
            // 
            this.tabburnbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabburnbt.Location = new System.Drawing.Point(553, 10);
            this.tabburnbt.Name = "tabburnbt";
            this.tabburnbt.Size = new System.Drawing.Size(75, 47);
            this.tabburnbt.TabIndex = 9;
            this.tabburnbt.Text = "Burn";
            this.tabburnbt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabburnbt.UseVisualStyleBackColor = true;
            // 
            // tabsyncbt
            // 
            this.tabsyncbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsyncbt.Location = new System.Drawing.Point(633, 10);
            this.tabsyncbt.Name = "tabsyncbt";
            this.tabsyncbt.Size = new System.Drawing.Size(71, 47);
            this.tabsyncbt.TabIndex = 10;
            this.tabsyncbt.Text = "Sync";
            this.tabsyncbt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabsyncbt.UseVisualStyleBackColor = true;
            // 
            // Playbt
            // 
            this.Playbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Playbt.Location = new System.Drawing.Point(227, 416);
            this.Playbt.Name = "Playbt";
            this.Playbt.Size = new System.Drawing.Size(75, 23);
            this.Playbt.TabIndex = 11;
            this.Playbt.Text = "Start";
            this.Playbt.UseVisualStyleBackColor = true;
            this.Playbt.Click += new System.EventHandler(this.button4_Click);
            // 
            // Stopbt
            // 
            this.Stopbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Stopbt.Location = new System.Drawing.Point(418, 415);
            this.Stopbt.Name = "Stopbt";
            this.Stopbt.Size = new System.Drawing.Size(75, 23);
            this.Stopbt.TabIndex = 12;
            this.Stopbt.Text = "Stop";
            this.Stopbt.UseVisualStyleBackColor = true;
            this.Stopbt.Click += new System.EventHandler(this.Stopbt_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "if_button_blue_pause_40716.png");
            this.imageList3.Images.SetKeyName(1, "if_button_blue_play_40717.png");
            // 
            // roundButton1
            // 
            this.roundButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roundButton1.ImageIndex = 1;
            this.roundButton1.ImageList = this.imageList3;
            this.roundButton1.Location = new System.Drawing.Point(335, 405);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(46, 45);
            this.roundButton1.TabIndex = 13;
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // backButton
            // 
            this.backButton.ImageIndex = 0;
            this.backButton.ImageList = this.imageList2;
            this.backButton.Location = new System.Drawing.Point(9, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(29, 29);
            this.backButton.TabIndex = 8;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.MouseLeave += new System.EventHandler(this.roundButton1_MouseLeave);
            this.backButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseMove);
            this.backButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseUp);
            // 
            // forwardButton
            // 
            this.forwardButton.ImageIndex = 1;
            this.forwardButton.ImageList = this.imageList2;
            this.forwardButton.Location = new System.Drawing.Point(38, 4);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(28, 29);
            this.forwardButton.TabIndex = 7;
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.MouseLeave += new System.EventHandler(this.roundButton2_MouseLeave);
            this.forwardButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.roundButton2_MouseMove);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(476, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(233, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(225, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Play";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(225, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Burn";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(225, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sync";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.Stopbt);
            this.Controls.Add(this.Playbt);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.tabplaybt);
            this.Controls.Add(this.tabburnbt);
            this.Controls.Add(this.tabsyncbt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            this.panelPlaylist.ResumeLayout(false);
            this.panelPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem organizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyMediaInformationChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowInternetAccessToHomeMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem turnOnMeidaStreamingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createAutoPlaylistToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private RoundButton forwardButton;
        private RoundButton backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tabplaybt;
        private System.Windows.Forms.Button tabburnbt;
        private System.Windows.Forms.Button tabsyncbt;
        private System.Windows.Forms.Button Playbt;
        private System.Windows.Forms.Button Stopbt;
        private RoundButton roundButton1;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordedTVToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPlaylist;
        private System.Windows.Forms.Label label2;
    }
}

