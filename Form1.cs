using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFiglet
{
    public partial class Form1 : Form
    {
        const string figFontsPath = @"Fonts/";
        bool coloringDark = true;

        public Form1()
        {
            InitializeComponent();
            InitFonts();
            tbFigOut.Clear();
            DoFig(tbInput.Text);
            pbCharacterError.Hide();
        }

        // METHODS
        void InitFonts()
        {
            var fonts = Directory.GetFiles(figFontsPath, "*.flf");
            ddlFontList.Items.Clear();
            foreach (var font in fonts)
            {
                ddlFontList.Items.Add(Path.GetFileName(font));
            }
            if (ddlFontList.Items.Count != 0)
                ddlFontList.SelectedIndex = 0;

            SetTitle(ddlFontList.Items.Count);

            ddlFontList.SelectedItem = "Fraktur.flf";
        }
        private void SetTitle(int fontsCount)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            string versionString = $"v{version.Major}.{version.Minor}";

            Text = $"{Text} {versionString} ({ddlFontList.Items.Count} Fonts loaded)";
        }
        private void ChangeColoring(bool changeColor = false)
        {
            if (changeColor)
                coloringDark = !coloringDark;

            // Update Button
            if (coloringDark)
            {
                tbFigOut.ForeColor = Color.LawnGreen;
                tbFigOut.BackColor = Color.Black;
                btnColoring.Text = "☀️";
                toolTip1.SetToolTip(btnColoring, "Switch to Light Figlet");
            }
            else
            {
                tbFigOut.ForeColor = Color.Black;
                tbFigOut.BackColor = SystemColors.Control;
                btnColoring.Text = "☽︎";
                toolTip1.SetToolTip(btnColoring, "Switch to dark Figlet");
            }
        }
        private void DoFig(string text)
        {
            pbCharacterError.Hide();

            if (string.IsNullOrWhiteSpace(text))
                return;

            var fontFile = ddlFontList.SelectedItem.ToString();
            if (!String.IsNullOrWhiteSpace(fontFile))
            {
                var fig = new Figlet();
                FigletResult result = null;

                try
                {
                    //Load specific font (Figlet format)
                    fig.LoadFont(figFontsPath + fontFile);
                }
                catch (Exception)
                {
                    var str = $"!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!{Environment.NewLine}" +
                        $"Error loading font: {figFontsPath}{fontFile}{Environment.NewLine}" +
                        $"!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!{Environment.NewLine}";
                    result = new FigletResult(str, true);
                }


                //Generate ASCII-Art Text (if no error)
                if (result == null)
                {
                    result = fig.ToAsciiArt(text);
                }

                tbFigOut.Clear();
                tbFigOut.AppendText(result.String);

                if (result.CharacterError)
                {
                    pbCharacterError.Show();
                }
            }
        }

        // EVENTS
        private void btnFiglet_Click(object sender, EventArgs e)
        {
            DoFig(tbInput.Text);
            tbInput.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInput.Clear();
            tbFigOut.Clear();
            tbInput.Focus();
            pbCharacterError.Hide();
        }
        private void ddlFontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoFig(tbInput.Text);
        }
        private void linkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SiL3NC3/WinFiglet");
            tbInput.Focus();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            ChangeColoring();
            tbInput.Focus();
        }
        private void btnFontDown_Click(object sender, EventArgs e)
        {
            if (ddlFontList.Items.Count > ddlFontList.SelectedIndex + 1)
                ddlFontList.SelectedIndex = ddlFontList.SelectedIndex + 1;
            tbInput.Focus();
        }
        private void btnFontUp_Click(object sender, EventArgs e)
        {
            if (ddlFontList.SelectedIndex - 1 >= 0)
                ddlFontList.SelectedIndex = ddlFontList.SelectedIndex - 1;
            tbInput.Focus();
        }
        private void btnClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFigOut.Text))
                Clipboard.SetText(tbFigOut.Text);
            tbInput.Focus();
        }
        private void btnColoring_Click(object sender, EventArgs e)
        {
            ChangeColoring(true);
            tbInput.Focus();
        }

    }
}
