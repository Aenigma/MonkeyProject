﻿using System.Drawing;
using System.Windows.Forms;

namespace MonkeyProject
{
    partial class MonkeyAppWindow
    {
        Rectangle resolution = Screen.PrimaryScreen.Bounds;
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
            SaveResults();
            base.Dispose(disposing);
            sw.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resolution = Screen.PrimaryScreen.Bounds;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyAppWindow));
            this.SuspendLayout();
            // 
            // MonkeyAppWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(resolution.X, resolution.Y);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MonkeyAppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MonkeyAppWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.updateShapes);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortcutHandler);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonkeyPress);
            this.ResumeLayout(false);

        }

        #endregion

    }
}

