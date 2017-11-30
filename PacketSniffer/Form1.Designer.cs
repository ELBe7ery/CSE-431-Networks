namespace PacketSniffer
{
    partial class PacketSniffer
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeviceListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stopCaptureButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.startCapture_Button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SelectAdapter_Button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Enabled = false;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(13, 471);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(213, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "CSE431- Networks project";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(563, 697);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(230, 80);
            this.materialDivider2.TabIndex = 9;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(790, 198);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-12, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(839, 54);
            this.materialTabSelector1.TabIndex = 11;
            this.materialTabSelector1.Text = "MainTabNavigator";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 139);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(811, 323);
            this.materialTabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.SelectAdapter_Button);
            this.tabPage1.Controls.Add(this.DeviceListView);
            this.tabPage1.Controls.Add(this.materialFlatButton2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adapter Setting";
            // 
            // DeviceListView
            // 
            this.DeviceListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeviceListView.CheckBoxes = true;
            this.DeviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.DeviceListView.Depth = 0;
            this.DeviceListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DeviceListView.ForeColor = System.Drawing.Color.Transparent;
            this.DeviceListView.FullRowSelect = true;
            this.DeviceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DeviceListView.Location = new System.Drawing.Point(6, 54);
            this.DeviceListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DeviceListView.MouseState = MaterialSkin.MouseState.OUT;
            this.DeviceListView.MultiSelect = false;
            this.DeviceListView.Name = "DeviceListView";
            this.DeviceListView.OwnerDraw = true;
            this.DeviceListView.Size = new System.Drawing.Size(781, 237);
            this.DeviceListView.TabIndex = 7;
            this.DeviceListView.UseCompatibleStateImageBehavior = false;
            this.DeviceListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adapters List";
            this.columnHeader1.Width = 657;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Enabled = false;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(142, 9);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(479, 36);
            this.materialFlatButton2.TabIndex = 8;
            this.materialFlatButton2.Text = "select any of the adapters above to start capturing packets";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.stopCaptureButton);
            this.tabPage2.Controls.Add(this.startCapture_Button);
            this.tabPage2.Controls.Add(this.materialFlatButton3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Packets";
            // 
            // stopCaptureButton
            // 
            this.stopCaptureButton.AutoSize = true;
            this.stopCaptureButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopCaptureButton.Depth = 0;
            this.stopCaptureButton.Icon = null;
            this.stopCaptureButton.Location = new System.Drawing.Point(141, 15);
            this.stopCaptureButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopCaptureButton.Name = "stopCaptureButton";
            this.stopCaptureButton.Primary = true;
            this.stopCaptureButton.Size = new System.Drawing.Size(120, 36);
            this.stopCaptureButton.TabIndex = 1;
            this.stopCaptureButton.Text = "stop capture";
            this.stopCaptureButton.UseVisualStyleBackColor = true;
            // 
            // startCapture_Button
            // 
            this.startCapture_Button.AutoSize = true;
            this.startCapture_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startCapture_Button.Depth = 0;
            this.startCapture_Button.Icon = null;
            this.startCapture_Button.Location = new System.Drawing.Point(7, 15);
            this.startCapture_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.startCapture_Button.Name = "startCapture_Button";
            this.startCapture_Button.Primary = true;
            this.startCapture_Button.Size = new System.Drawing.Size(128, 36);
            this.startCapture_Button.TabIndex = 1;
            this.startCapture_Button.Text = "start capture";
            this.startCapture_Button.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Enabled = false;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(268, 15);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(262, 36);
            this.materialFlatButton3.TabIndex = 0;
            this.materialFlatButton3.Text = "Current selected adapter : None";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // SelectAdapter_Button
            // 
            this.SelectAdapter_Button.AutoSize = true;
            this.SelectAdapter_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectAdapter_Button.Depth = 0;
            this.SelectAdapter_Button.Icon = null;
            this.SelectAdapter_Button.Location = new System.Drawing.Point(6, 6);
            this.SelectAdapter_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectAdapter_Button.Name = "SelectAdapter_Button";
            this.SelectAdapter_Button.Primary = true;
            this.SelectAdapter_Button.Size = new System.Drawing.Size(134, 36);
            this.SelectAdapter_Button.TabIndex = 9;
            this.SelectAdapter_Button.Text = "Select Adapter";
            this.SelectAdapter_Button.UseVisualStyleBackColor = true;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "asd";
            this.columnHeader2.Width = 120;
            // 
            // PacketSniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 522);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "PacketSniffer";
            this.Text = "PacketSniffer";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialListView DeviceListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialRaisedButton stopCaptureButton;
        private MaterialSkin.Controls.MaterialRaisedButton startCapture_Button;
        private MaterialSkin.Controls.MaterialRaisedButton SelectAdapter_Button;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

