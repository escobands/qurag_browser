using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.Web.WebView2.WinForms;

namespace Qurag_Browser
{
    public partial class Qurag : Form
    {

        public Qurag()
        {
            InitializeComponent();
            webView2Main = new WebView2();
            webView2Main.Dock = DockStyle.Fill;
            this.Controls.Add(webView2Main);
            this.Load += Form1_Load;
            
           
        }
            
            

        private void buttonVisit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxURL.Text))
            {
                try
                {
                    webView2Main.CoreWebView2.Navigate(textBoxURL.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Navigation has failed: " + ex.Message, "Qurag Browser", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Tworzymy WebView cz2
                webView2Main.Dock = DockStyle.None;
                webView2Main.Location = new Point(0, 50);
                webView2Main.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 50);
                webView2Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                this.Controls.Add(webView2Main);
                webView2Main.BringToFront();

                // Inicjalizacja WebView i update url, jeszcze daj tam back/fwd
                await webView2Main.EnsureCoreWebView2Async(null);
                webView2Main.CoreWebView2.NavigationCompleted += (s, args) =>
                {
                    textBoxURL.Text = webView2Main.Source.ToString();
                };

                await webView2Main.EnsureCoreWebView2Async(null);
                webView2Main.CoreWebView2.HistoryChanged += (s, args) =>
                {
                    buttonBack.Enabled = webView2Main.CanGoBack;
                    buttonFwd.Enabled = webView2Main.CanGoForward;
                };

                // Strona poczatkowa
                webView2Main.CoreWebView2.Navigate("about:blank");

                // Eventy dla myszy
                InitializeWebView2Events();

                // Fokus
                webView2Main.Focus();

                // Lepiej fokus sie lapie
                webView2Main.TabStop = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem initializing engine: " + ex.Message);
            }

           
        }

        private void BackButtonCL(object sender, EventArgs e)
        {
            if (webView2Main.CanGoBack)
                webView2Main.GoBack();
        }

        private void FwdButtonCL(object sender, EventArgs e)
        {
            if (webView2Main.CanGoForward)
                webView2Main.GoForward();
        }

        private void textBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonVisit_Click(sender, e);
            }
        }
        // W Konstruktorze lub w Load formy:
        private void InitializeWebView2Events()
        {
            // Rejestracja eventów na WebView2
            // Uzywano do debugowania z mysza
            // Chyba da sie usunac
            // Nie chce mi sie
            webView2Main.MouseDown += WebView2Main_MouseDown;
            webView2Main.MouseClick += WebView2Main_MouseClick;
            webView2Main.MouseWheel += WebView2Main_MouseWheel;
        }

        private void WebView2Main_MouseDown(object sender, MouseEventArgs e)
        {
            // Tutaj nic
        }

        private void WebView2Main_MouseClick(object sender, MouseEventArgs e)
        {
            // Tez nic
        }

        private void WebView2Main_MouseWheel(object sender, MouseEventArgs e)
        {
            // Nic
        }

        private void Qurag_FormClosing(object sender, FormClosingEventArgs e)
        {
            webView2Main.Dispose();
        }

        }
    }

