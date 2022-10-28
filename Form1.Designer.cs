
namespace WinFiglet
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
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlFontList = new System.Windows.Forms.ComboBox();
            this.tbFigOut = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnFiglet = new System.Windows.Forms.Button();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFontDown = new System.Windows.Forms.Button();
            this.btnFontUp = new System.Windows.Forms.Button();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnColoring = new System.Windows.Forms.Button();
            this.pbCharacterError = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacterError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(594, 10);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(28, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "❌";
            this.toolTip1.SetToolTip(this.btnClear, "Clear Text and Figlet");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FONTS";
            // 
            // ddlFontList
            // 
            this.ddlFontList.FormattingEnabled = true;
            this.ddlFontList.Location = new System.Drawing.Point(137, 13);
            this.ddlFontList.Margin = new System.Windows.Forms.Padding(4);
            this.ddlFontList.Name = "ddlFontList";
            this.ddlFontList.Size = new System.Drawing.Size(189, 24);
            this.ddlFontList.TabIndex = 3;
            this.ddlFontList.SelectedIndexChanged += new System.EventHandler(this.ddlFontList_SelectedIndexChanged);
            // 
            // tbFigOut
            // 
            this.tbFigOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFigOut.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFigOut.Location = new System.Drawing.Point(13, 45);
            this.tbFigOut.Margin = new System.Windows.Forms.Padding(4);
            this.tbFigOut.Multiline = true;
            this.tbFigOut.Name = "tbFigOut";
            this.tbFigOut.ReadOnly = true;
            this.tbFigOut.Size = new System.Drawing.Size(753, 367);
            this.tbFigOut.TabIndex = 8;
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(370, 14);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(216, 22);
            this.tbInput.TabIndex = 5;
            this.tbInput.Text = "WinFiglet";
            // 
            // btnFiglet
            // 
            this.btnFiglet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiglet.Location = new System.Drawing.Point(630, 10);
            this.btnFiglet.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiglet.Name = "btnFiglet";
            this.btnFiglet.Size = new System.Drawing.Size(100, 28);
            this.btnFiglet.TabIndex = 7;
            this.btnFiglet.Text = "⭐FIG it⭐";
            this.toolTip1.SetToolTip(this.btnFiglet, "Generate Figlet from Text");
            this.btnFiglet.UseVisualStyleBackColor = true;
            this.btnFiglet.Click += new System.EventHandler(this.btnFiglet_Click);
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(392, 6);
            this.linkLabelGithub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(75, 16);
            this.linkLabelGithub.TabIndex = 1;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github.com";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGit_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Made with 💙 for ASCII Art - Source code and release available at ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.linkLabelGithub);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(152, 413);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 30);
            this.panel1.TabIndex = 9;
            // 
            // btnFontDown
            // 
            this.btnFontDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFontDown.Location = new System.Drawing.Point(105, 11);
            this.btnFontDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnFontDown.Name = "btnFontDown";
            this.btnFontDown.Size = new System.Drawing.Size(28, 28);
            this.btnFontDown.TabIndex = 1;
            this.btnFontDown.Text = "⯆";
            this.toolTip1.SetToolTip(this.btnFontDown, "Next Font");
            this.btnFontDown.UseVisualStyleBackColor = true;
            this.btnFontDown.Click += new System.EventHandler(this.btnFontDown_Click);
            // 
            // btnFontUp
            // 
            this.btnFontUp.Location = new System.Drawing.Point(73, 11);
            this.btnFontUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnFontUp.Name = "btnFontUp";
            this.btnFontUp.Size = new System.Drawing.Size(28, 28);
            this.btnFontUp.TabIndex = 2;
            this.btnFontUp.Text = "⯅";
            this.toolTip1.SetToolTip(this.btnFontUp, "Previous Font");
            this.btnFontUp.UseVisualStyleBackColor = true;
            this.btnFontUp.Click += new System.EventHandler(this.btnFontUp_Click);
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point(334, 11);
            this.btnClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(28, 28);
            this.btnClipboard.TabIndex = 4;
            this.btnClipboard.Text = "📋";
            this.toolTip1.SetToolTip(this.btnClipboard, "Copy Figlet to Clipboard");
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // btnColoring
            // 
            this.btnColoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColoring.Location = new System.Drawing.Point(738, 10);
            this.btnColoring.Margin = new System.Windows.Forms.Padding(4);
            this.btnColoring.Name = "btnColoring";
            this.btnColoring.Size = new System.Drawing.Size(28, 28);
            this.btnColoring.TabIndex = 10;
            this.btnColoring.Text = "☀";
            this.btnColoring.UseVisualStyleBackColor = true;
            this.btnColoring.Click += new System.EventHandler(this.btnColoring_Click);
            // 
            // pbCharacterError
            // 
            this.pbCharacterError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCharacterError.BackColor = System.Drawing.SystemColors.Control;
            this.pbCharacterError.Image = global::WinFiglet.Properties.Resources.zeimusu_Warning_sign;
            this.pbCharacterError.Location = new System.Drawing.Point(734, 415);
            this.pbCharacterError.Name = "pbCharacterError";
            this.pbCharacterError.Size = new System.Drawing.Size(32, 26);
            this.pbCharacterError.TabIndex = 11;
            this.pbCharacterError.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCharacterError, "Some characters of the text are unsupported by the font!\r\nPossibly special chars " +
        "or umlauts.\r\nRendering for these chars are skipped, so they are missing!");
            // 
            // Form1
            // 
            this.AcceptButton = this.btnFiglet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.pbCharacterError);
            this.Controls.Add(this.btnColoring);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.btnFontUp);
            this.Controls.Add(this.btnFontDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlFontList);
            this.Controls.Add(this.tbFigOut);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnFiglet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(795, 483);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinFiglet";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacterError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlFontList;
        private System.Windows.Forms.TextBox tbFigOut;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnFiglet;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFontDown;
        private System.Windows.Forms.Button btnFontUp;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnColoring;
        private System.Windows.Forms.PictureBox pbCharacterError;
    }
}

