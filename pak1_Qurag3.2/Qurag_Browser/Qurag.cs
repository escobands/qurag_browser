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

                // Inicjalizacja WebView
                await webView2Main.EnsureCoreWebView2Async(null);

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
        // W Konstruktorze lub w Load formy:
        private void InitializeWebView2Events()
        {
            // Rejestracja eventów na WebView2
            // Uzywano do debugowania z mysza
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

        }
    }

