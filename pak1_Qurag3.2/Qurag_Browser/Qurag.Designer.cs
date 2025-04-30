using System;
using Microsoft.Web.WebView2.WinForms;

namespace Qurag_Browser
{
    partial class Qurag
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qurag));
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonVisit = new System.Windows.Forms.Button();
            this.webView2Main = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 14);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(1155, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // buttonVisit
            // 
            this.buttonVisit.Location = new System.Drawing.Point(1173, 12);
            this.buttonVisit.Name = "buttonVisit";
            this.buttonVisit.Size = new System.Drawing.Size(118, 23);
            this.buttonVisit.TabIndex = 1;
            this.buttonVisit.Text = "Visit";
            this.buttonVisit.UseVisualStyleBackColor = true;
            this.buttonVisit.Click += new System.EventHandler(this.buttonVisit_Click);
            // 
            // webView2Main
            // 
            this.webView2Main.AllowExternalDrop = true;
            this.webView2Main.CreationProperties = null;
            this.webView2Main.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2Main.Location = new System.Drawing.Point(0, 0);
            this.webView2Main.Name = "webView2Main";
            this.webView2Main.Size = new System.Drawing.Size(0, 0);
            this.webView2Main.TabIndex = 0;
            this.webView2Main.ZoomFactor = 1D;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.webView21.CreationProperties = null;
            this.webView21.Cursor = System.Windows.Forms.Cursors.Cross;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.ImeMode = System.Windows.Forms.ImeMode.On;
            this.webView21.Location = new System.Drawing.Point(13, 40);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1477, 785);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // Qurag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 837);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.buttonVisit);
            this.Controls.Add(this.textBoxURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Qurag";
            this.Text = "Qurag 3.2 (Hotfix)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView2Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private WebView2 webView2Main;


        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonVisit;
        private WebView2 webView21;
    }
}

