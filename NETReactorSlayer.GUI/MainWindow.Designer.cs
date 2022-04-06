﻿/*
    Copyright (C) 2021 CodeStrikers.org
    This file is part of NETReactorSlayer.
    NETReactorSlayer is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
    NETReactorSlayer is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
    You should have received a copy of the GNU General Public License
    along with NETReactorSlayer.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace NETReactorSlayer.GUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.panelLogs = new System.Windows.Forms.Panel();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.ctxLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.picBrowse = new System.Windows.Forms.PictureBox();
            this.pnlTextBox = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.tabelOptions = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llblGitHub = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.llblWebsite = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new NETReactorSlayer.GUI.UserControls.NRSButton();
            this.scrollbarLogs = new NETReactorSlayer.GUI.UserControls.NRSScrollBar();
            this.txtInput = new NETReactorSlayer.GUI.UserControls.NRSTextBox();
            this.chkPreserveAll = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkKeepOldMaxStack = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkDeobCFlow = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkDecryptMethods = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkCleanup = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkDecryptTokens = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkPatchAntiTD = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkRemoveRefProxies = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkDecryptHiddenCalls = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkDecryptStrings = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkDecryptResources = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkDumpDNRAsm = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.chkDumpCosturaAsm = new NETReactorSlayer.GUI.UserControls.NRSCheckBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.panelLogs.SuspendLayout();
            this.ctxLogs.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowse)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.tabelOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.Controls.Add(this.picMinimize);
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Controls.Add(this.picExit);
            this.pnlHeader.Controls.Add(this.picHeader);
            this.pnlHeader.Controls.Add(this.panel3);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(30, 5);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(0, 60);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(853, 60);
            this.pnlHeader.TabIndex = 2;
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMinimize.Image = global::NETReactorSlayer.GUI.Properties.Resources.Minimize;
            this.picMinimize.Location = new System.Drawing.Point(785, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 60);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMinimize.TabIndex = 3;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseEnter += new System.EventHandler(this.picMinimize_MouseEnter);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picMinimize_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(809, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 60);
            this.panel2.TabIndex = 16;
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picExit.Image = global::NETReactorSlayer.GUI.Properties.Resources.Close;
            this.picExit.Location = new System.Drawing.Point(819, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(24, 60);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // picHeader
            // 
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHeader.Image = global::NETReactorSlayer.GUI.Properties.Resources.Header;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(843, 60);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHeader.TabIndex = 1;
            this.picHeader.TabStop = false;
            this.picHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.picHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.picHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(843, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 60);
            this.panel3.TabIndex = 17;
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlBase.Controls.Add(this.pnlSeparator);
            this.pnlBase.Controls.Add(this.pnlButton);
            this.pnlBase.Controls.Add(this.panelLogs);
            this.pnlBase.Controls.Add(this.pnlInput);
            this.pnlBase.Controls.Add(this.pnlOptions);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(30, 65);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Padding = new System.Windows.Forms.Padding(30);
            this.pnlBase.Size = new System.Drawing.Size(853, 431);
            this.pnlBase.TabIndex = 3;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(30, 393);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(793, 10);
            this.pnlSeparator.TabIndex = 15;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnStart);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButton.Location = new System.Drawing.Point(30, 338);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(200, 5, 200, 5);
            this.pnlButton.Size = new System.Drawing.Size(793, 55);
            this.pnlButton.TabIndex = 16;
            // 
            // panelLogs
            // 
            this.panelLogs.Controls.Add(this.scrollbarLogs);
            this.panelLogs.Controls.Add(this.txtLogs);
            this.panelLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogs.Location = new System.Drawing.Point(30, 181);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Padding = new System.Windows.Forms.Padding(2);
            this.panelLogs.Size = new System.Drawing.Size(793, 157);
            this.panelLogs.TabIndex = 0;
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogs.ContextMenuStrip = this.ctxLogs;
            this.txtLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.ForeColor = System.Drawing.Color.Silver;
            this.txtLogs.Location = new System.Drawing.Point(2, 2);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtLogs.Size = new System.Drawing.Size(789, 153);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.TabStop = false;
            this.txtLogs.Text = "\n  Logs will appear here...";
            this.txtLogs.TextChanged += new System.EventHandler(this.txtLogs_TextChanged);
            // 
            // ctxLogs
            // 
            this.ctxLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ctxLogs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.copyLogsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.ctxLogs.Name = "ctxLogs";
            this.ctxLogs.ShowImageMargin = false;
            this.ctxLogs.Size = new System.Drawing.Size(186, 66);
            // 
            // copyLogsToolStripMenuItem
            // 
            this.copyLogsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.copyLogsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyLogsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.copyLogsToolStripMenuItem.Name = "copyLogsToolStripMenuItem";
            this.copyLogsToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.copyLogsToolStripMenuItem.Text = "  Copy Logs";
            this.copyLogsToolStripMenuItem.Click += new System.EventHandler(this.copyLogsToolStripMenuItem_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.picBrowse);
            this.pnlInput.Controls.Add(this.pnlTextBox);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(30, 134);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlInput.Size = new System.Drawing.Size(793, 47);
            this.pnlInput.TabIndex = 12;
            // 
            // picBrowse
            // 
            this.picBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.picBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBrowse.Image = global::NETReactorSlayer.GUI.Properties.Resources.Browse;
            this.picBrowse.Location = new System.Drawing.Point(742, 10);
            this.picBrowse.Name = "picBrowse";
            this.picBrowse.Size = new System.Drawing.Size(51, 27);
            this.picBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBrowse.TabIndex = 4;
            this.picBrowse.TabStop = false;
            this.picBrowse.Click += new System.EventHandler(this.picBrowse_Click);
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pnlTextBox.Controls.Add(this.txtInput);
            this.pnlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextBox.Location = new System.Drawing.Point(0, 10);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlTextBox.Size = new System.Drawing.Size(793, 27);
            this.pnlTextBox.TabIndex = 1;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.tabelOptions);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(30, 30);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlOptions.Size = new System.Drawing.Size(793, 104);
            this.pnlOptions.TabIndex = 11;
            // 
            // tabelOptions
            // 
            this.tabelOptions.ColumnCount = 3;
            this.tabelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelOptions.Controls.Add(this.chkPreserveAll, 0, 4);
            this.tabelOptions.Controls.Add(this.chkKeepOldMaxStack, 2, 3);
            this.tabelOptions.Controls.Add(this.chkDeobCFlow, 1, 0);
            this.tabelOptions.Controls.Add(this.chkDecryptMethods, 0, 0);
            this.tabelOptions.Controls.Add(this.chkCleanup, 1, 3);
            this.tabelOptions.Controls.Add(this.chkDecryptTokens, 0, 3);
            this.tabelOptions.Controls.Add(this.chkPatchAntiTD, 2, 0);
            this.tabelOptions.Controls.Add(this.chkRemoveRefProxies, 0, 1);
            this.tabelOptions.Controls.Add(this.chkDecryptHiddenCalls, 1, 1);
            this.tabelOptions.Controls.Add(this.chkDecryptStrings, 2, 1);
            this.tabelOptions.Controls.Add(this.chkDecryptResources, 0, 2);
            this.tabelOptions.Controls.Add(this.chkDumpDNRAsm, 1, 2);
            this.tabelOptions.Controls.Add(this.chkDumpCosturaAsm, 2, 2);
            this.tabelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabelOptions.Location = new System.Drawing.Point(3, 0);
            this.tabelOptions.Name = "tabelOptions";
            this.tabelOptions.RowCount = 5;
            this.tabelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabelOptions.Size = new System.Drawing.Size(790, 104);
            this.tabelOptions.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.llblGitHub);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.llblWebsite);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblAuthor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(30, 496);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.panel1.Size = new System.Drawing.Size(853, 40);
            this.panel1.TabIndex = 17;
            // 
            // llblGitHub
            // 
            this.llblGitHub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.llblGitHub.AutoSize = true;
            this.llblGitHub.Dock = System.Windows.Forms.DockStyle.Left;
            this.llblGitHub.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold);
            this.llblGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.llblGitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.llblGitHub.Location = new System.Drawing.Point(351, 10);
            this.llblGitHub.Name = "llblGitHub";
            this.llblGitHub.Size = new System.Drawing.Size(38, 12);
            this.llblGitHub.TabIndex = 7;
            this.llblGitHub.TabStop = true;
            this.llblGitHub.Tag = "https://github.com/SychicBoy/NETReactorSlayer";
            this.llblGitHub.Text = "GitHub";
            this.llblGitHub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.llblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGitHub_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(272, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repository: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(808, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Version:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.lblVersion.Location = new System.Drawing.Point(848, 10);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 12);
            this.lblVersion.TabIndex = 5;
            // 
            // llblWebsite
            // 
            this.llblWebsite.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.llblWebsite.AutoSize = true;
            this.llblWebsite.Dock = System.Windows.Forms.DockStyle.Left;
            this.llblWebsite.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold);
            this.llblWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.llblWebsite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.llblWebsite.Location = new System.Drawing.Point(166, 10);
            this.llblWebsite.Name = "llblWebsite";
            this.llblWebsite.Size = new System.Drawing.Size(106, 12);
            this.llblWebsite.TabIndex = 3;
            this.llblWebsite.TabStop = true;
            this.llblWebsite.Tag = "https://www.CodeStrikers.org";
            this.llblWebsite.Text = "www.CodeStrikers.org";
            this.llblWebsite.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.llblWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWebsite_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(99, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(67, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Website: ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.lblAuthor.Location = new System.Drawing.Point(48, 10);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 12);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "SychicBoy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author: ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 5);
            this.toolStripMenuItem2.Text = " ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 5);
            this.toolStripMenuItem1.Text = " ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnStart.BorderRadius = 25;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Silver;
            this.btnStart.Location = new System.Drawing.Point(200, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(393, 45);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start Deobfuscation";
            this.btnStart.TextTransform = NETReactorSlayer.GUI.UserControls.NRSButton.TextTransformEnum.None;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // scrollbarLogs
            // 
            this.scrollbarLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.scrollbarLogs.Dock = System.Windows.Forms.DockStyle.Right;
            this.scrollbarLogs.Location = new System.Drawing.Point(776, 2);
            this.scrollbarLogs.Maximum = 10;
            this.scrollbarLogs.Name = "scrollbarLogs";
            this.scrollbarLogs.Size = new System.Drawing.Size(15, 153);
            this.scrollbarLogs.TabIndex = 17;
            this.scrollbarLogs.Text = "nrsScrollBar1";
            this.scrollbarLogs.ViewSize = 9;
            this.scrollbarLogs.ValueChanged += new System.EventHandler<NETReactorSlayer.GUI.UserControls.ScrollValueEventArgs>(this.scrollbarLogs_ValueChanged);
            // 
            // txtInput
            // 
            this.txtInput.AllowDrop = true;
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtInput.BorderRadius = 0;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI Semibold", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Silver;
            this.txtInput.Location = new System.Drawing.Point(0, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceHolderColor = System.Drawing.Color.Gray;
            this.txtInput.PlaceHolderText = "DRAG & DROP TARGET FILE HERE OR ENTER FILE PATH";
            this.txtInput.Progress = 22F;
            this.txtInput.ProgressColor = System.Drawing.Color.MediumSeaGreen;
            this.txtInput.Size = new System.Drawing.Size(793, 21);
            this.txtInput.TabIndex = 2;
            this.txtInput.Tag = "";
            this.txtInput.Text = "DRAG & DROP TARGET FILE HERE OR ENTER FILE PATH";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.TextTransform = NETReactorSlayer.GUI.UserControls.NRSTextBox.TextTransformEnum.None;
            this.txtInput.WordWrap = false;
            this.txtInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtInput_DragDrop);
            this.txtInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtInput_DragEnter);
            // 
            // chkPreserveAll
            // 
            this.chkPreserveAll.AutoSize = true;
            this.chkPreserveAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkPreserveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPreserveAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkPreserveAll.ForeColor = System.Drawing.Color.Silver;
            this.chkPreserveAll.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkPreserveAll.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkPreserveAll.HoverForeColor = System.Drawing.Color.Gray;
            this.chkPreserveAll.Location = new System.Drawing.Point(3, 83);
            this.chkPreserveAll.Name = "chkPreserveAll";
            this.chkPreserveAll.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkPreserveAll.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkPreserveAll.PressForeColor = System.Drawing.Color.White;
            this.chkPreserveAll.Size = new System.Drawing.Size(183, 18);
            this.chkPreserveAll.TabIndex = 15;
            this.chkPreserveAll.Tag = "--preserve-all";
            this.chkPreserveAll.Text = "Preserve All MD Tokens";
            this.chkPreserveAll.UseVisualStyleBackColor = true;
            // 
            // chkKeepOldMaxStack
            // 
            this.chkKeepOldMaxStack.AutoSize = true;
            this.chkKeepOldMaxStack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkKeepOldMaxStack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkKeepOldMaxStack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkKeepOldMaxStack.ForeColor = System.Drawing.Color.Silver;
            this.chkKeepOldMaxStack.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkKeepOldMaxStack.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkKeepOldMaxStack.HoverForeColor = System.Drawing.Color.Gray;
            this.chkKeepOldMaxStack.Location = new System.Drawing.Point(529, 63);
            this.chkKeepOldMaxStack.Name = "chkKeepOldMaxStack";
            this.chkKeepOldMaxStack.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkKeepOldMaxStack.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkKeepOldMaxStack.PressForeColor = System.Drawing.Color.White;
            this.chkKeepOldMaxStack.Size = new System.Drawing.Size(197, 14);
            this.chkKeepOldMaxStack.TabIndex = 14;
            this.chkKeepOldMaxStack.Tag = "--keep-stack";
            this.chkKeepOldMaxStack.Text = "Keep Old Max Stack Value";
            this.chkKeepOldMaxStack.UseVisualStyleBackColor = true;
            // 
            // chkDeobCFlow
            // 
            this.chkDeobCFlow.AutoSize = true;
            this.chkDeobCFlow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkDeobCFlow.Checked = true;
            this.chkDeobCFlow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeobCFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDeobCFlow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDeobCFlow.ForeColor = System.Drawing.Color.Silver;
            this.chkDeobCFlow.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDeobCFlow.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDeobCFlow.HoverForeColor = System.Drawing.Color.Gray;
            this.chkDeobCFlow.Location = new System.Drawing.Point(266, 3);
            this.chkDeobCFlow.Name = "chkDeobCFlow";
            this.chkDeobCFlow.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDeobCFlow.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDeobCFlow.PressForeColor = System.Drawing.Color.White;
            this.chkDeobCFlow.Size = new System.Drawing.Size(197, 14);
            this.chkDeobCFlow.TabIndex = 4;
            this.chkDeobCFlow.Tag = "--deobfuscate-cflow";
            this.chkDeobCFlow.Text = "Deobfuscate Control Flow";
            this.chkDeobCFlow.UseVisualStyleBackColor = true;
            // 
            // chkDecryptMethods
            // 
            this.chkDecryptMethods.AutoSize = true;
            this.chkDecryptMethods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkDecryptMethods.Checked = true;
            this.chkDecryptMethods.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDecryptMethods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDecryptMethods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptMethods.ForeColor = System.Drawing.Color.Silver;
            this.chkDecryptMethods.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptMethods.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptMethods.HoverForeColor = System.Drawing.Color.Gray;
            this.chkDecryptMethods.Location = new System.Drawing.Point(3, 3);
            this.chkDecryptMethods.Name = "chkDecryptMethods";
            this.chkDecryptMethods.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptMethods.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptMethods.PressForeColor = System.Drawing.Color.White;
            this.chkDecryptMethods.Size = new System.Drawing.Size(134, 14);
            this.chkDecryptMethods.TabIndex = 7;
            this.chkDecryptMethods.Tag = "--decrypt-methods";
            this.chkDecryptMethods.Text = "Decrypt Methods";
            this.chkDecryptMethods.UseVisualStyleBackColor = true;
            // 
            // chkCleanup
            // 
            this.chkCleanup.AutoSize = true;
            this.chkCleanup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkCleanup.Checked = true;
            this.chkCleanup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCleanup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCleanup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkCleanup.ForeColor = System.Drawing.Color.Silver;
            this.chkCleanup.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkCleanup.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkCleanup.HoverForeColor = System.Drawing.Color.Gray;
            this.chkCleanup.Location = new System.Drawing.Point(266, 63);
            this.chkCleanup.Name = "chkCleanup";
            this.chkCleanup.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkCleanup.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkCleanup.PressForeColor = System.Drawing.Color.White;
            this.chkCleanup.Size = new System.Drawing.Size(78, 14);
            this.chkCleanup.TabIndex = 2;
            this.chkCleanup.Tag = "-cleanup";
            this.chkCleanup.Text = "Cleanup";
            this.chkCleanup.UseVisualStyleBackColor = true;
            // 
            // chkDecryptTokens
            // 
            this.chkDecryptTokens.AutoSize = true;
            this.chkDecryptTokens.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkDecryptTokens.Checked = true;
            this.chkDecryptTokens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDecryptTokens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDecryptTokens.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptTokens.ForeColor = System.Drawing.Color.Silver;
            this.chkDecryptTokens.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptTokens.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptTokens.HoverForeColor = System.Drawing.Color.Gray;
            this.chkDecryptTokens.Location = new System.Drawing.Point(3, 63);
            this.chkDecryptTokens.Name = "chkDecryptTokens";
            this.chkDecryptTokens.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptTokens.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptTokens.PressForeColor = System.Drawing.Color.White;
            this.chkDecryptTokens.Size = new System.Drawing.Size(127, 14);
            this.chkDecryptTokens.TabIndex = 8;
            this.chkDecryptTokens.Tag = "--decrypt-tokens";
            this.chkDecryptTokens.Text = "Decrypt Tokens";
            this.chkDecryptTokens.UseVisualStyleBackColor = true;
            // 
            // chkPatchAntiTD
            // 
            this.chkPatchAntiTD.AutoSize = true;
            this.chkPatchAntiTD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkPatchAntiTD.Checked = true;
            this.chkPatchAntiTD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPatchAntiTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPatchAntiTD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkPatchAntiTD.ForeColor = System.Drawing.Color.Silver;
            this.chkPatchAntiTD.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkPatchAntiTD.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkPatchAntiTD.HoverForeColor = System.Drawing.Color.Gray;
            this.chkPatchAntiTD.Location = new System.Drawing.Point(529, 3);
            this.chkPatchAntiTD.Name = "chkPatchAntiTD";
            this.chkPatchAntiTD.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkPatchAntiTD.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkPatchAntiTD.PressForeColor = System.Drawing.Color.White;
            this.chkPatchAntiTD.Size = new System.Drawing.Size(148, 14);
            this.chkPatchAntiTD.TabIndex = 11;
            this.chkPatchAntiTD.Tag = "--anti-tamper";
            this.chkPatchAntiTD.Text = "Patch Anti-Tamper";
            this.chkPatchAntiTD.UseVisualStyleBackColor = true;
            // 
            // chkRemoveRefProxies
            // 
            this.chkRemoveRefProxies.AutoSize = true;
            this.chkRemoveRefProxies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkRemoveRefProxies.Checked = true;
            this.chkRemoveRefProxies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveRefProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRemoveRefProxies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkRemoveRefProxies.ForeColor = System.Drawing.Color.Silver;
            this.chkRemoveRefProxies.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkRemoveRefProxies.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkRemoveRefProxies.HoverForeColor = System.Drawing.Color.Gray;
            this.chkRemoveRefProxies.Location = new System.Drawing.Point(3, 23);
            this.chkRemoveRefProxies.Name = "chkRemoveRefProxies";
            this.chkRemoveRefProxies.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkRemoveRefProxies.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkRemoveRefProxies.PressForeColor = System.Drawing.Color.White;
            this.chkRemoveRefProxies.Size = new System.Drawing.Size(197, 14);
            this.chkRemoveRefProxies.TabIndex = 5;
            this.chkRemoveRefProxies.Tag = "--remove-ref-proxies";
            this.chkRemoveRefProxies.Text = "Remove Reference Proxies";
            this.chkRemoveRefProxies.UseVisualStyleBackColor = true;
            // 
            // chkDecryptHiddenCalls
            // 
            this.chkDecryptHiddenCalls.AutoSize = true;
            this.chkDecryptHiddenCalls.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkDecryptHiddenCalls.Checked = true;
            this.chkDecryptHiddenCalls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDecryptHiddenCalls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDecryptHiddenCalls.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptHiddenCalls.ForeColor = System.Drawing.Color.Silver;
            this.chkDecryptHiddenCalls.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptHiddenCalls.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptHiddenCalls.HoverForeColor = System.Drawing.Color.Gray;
            this.chkDecryptHiddenCalls.Location = new System.Drawing.Point(266, 23);
            this.chkDecryptHiddenCalls.Name = "chkDecryptHiddenCalls";
            this.chkDecryptHiddenCalls.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptHiddenCalls.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptHiddenCalls.PressForeColor = System.Drawing.Color.White;
            this.chkDecryptHiddenCalls.Size = new System.Drawing.Size(169, 14);
            this.chkDecryptHiddenCalls.TabIndex = 12;
            this.chkDecryptHiddenCalls.Tag = "--decrypt-hidden-calls";
            this.chkDecryptHiddenCalls.Text = "Decrypt Hidden Calls";
            this.chkDecryptHiddenCalls.UseVisualStyleBackColor = true;
            // 
            // chkDecryptStrings
            // 
            this.chkDecryptStrings.AutoSize = true;
            this.chkDecryptStrings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkDecryptStrings.Checked = true;
            this.chkDecryptStrings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDecryptStrings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDecryptStrings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptStrings.ForeColor = System.Drawing.Color.Silver;
            this.chkDecryptStrings.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptStrings.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptStrings.HoverForeColor = System.Drawing.Color.Gray;
            this.chkDecryptStrings.Location = new System.Drawing.Point(529, 23);
            this.chkDecryptStrings.Name = "chkDecryptStrings";
            this.chkDecryptStrings.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptStrings.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptStrings.PressForeColor = System.Drawing.Color.White;
            this.chkDecryptStrings.Size = new System.Drawing.Size(134, 14);
            this.chkDecryptStrings.TabIndex = 13;
            this.chkDecryptStrings.Tag = "--decrypt-strings";
            this.chkDecryptStrings.Text = "Decrypt Strings";
            this.chkDecryptStrings.UseVisualStyleBackColor = true;
            // 
            // chkDecryptResources
            // 
            this.chkDecryptResources.AutoSize = true;
            this.chkDecryptResources.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkDecryptResources.Checked = true;
            this.chkDecryptResources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDecryptResources.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDecryptResources.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptResources.ForeColor = System.Drawing.Color.Silver;
            this.chkDecryptResources.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptResources.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptResources.HoverForeColor = System.Drawing.Color.Gray;
            this.chkDecryptResources.Location = new System.Drawing.Point(3, 43);
            this.chkDecryptResources.Name = "chkDecryptResources";
            this.chkDecryptResources.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDecryptResources.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDecryptResources.PressForeColor = System.Drawing.Color.White;
            this.chkDecryptResources.Size = new System.Drawing.Size(148, 14);
            this.chkDecryptResources.TabIndex = 6;
            this.chkDecryptResources.Tag = "--decrypt-resources";
            this.chkDecryptResources.Text = "Decrypt Resources";
            this.chkDecryptResources.UseVisualStyleBackColor = true;
            // 
            // chkDumpDNRAsm
            // 
            this.chkDumpDNRAsm.AutoSize = true;
            this.chkDumpDNRAsm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkDumpDNRAsm.Checked = true;
            this.chkDumpDNRAsm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDumpDNRAsm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDumpDNRAsm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDumpDNRAsm.ForeColor = System.Drawing.Color.Silver;
            this.chkDumpDNRAsm.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDumpDNRAsm.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDumpDNRAsm.HoverForeColor = System.Drawing.Color.Gray;
            this.chkDumpDNRAsm.Location = new System.Drawing.Point(266, 43);
            this.chkDumpDNRAsm.Name = "chkDumpDNRAsm";
            this.chkDumpDNRAsm.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDumpDNRAsm.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDumpDNRAsm.PressForeColor = System.Drawing.Color.White;
            this.chkDumpDNRAsm.Size = new System.Drawing.Size(162, 14);
            this.chkDumpDNRAsm.TabIndex = 10;
            this.chkDumpDNRAsm.Tag = "--dump-assemblies";
            this.chkDumpDNRAsm.Text = "Dump DNR Assemblies";
            this.chkDumpDNRAsm.UseVisualStyleBackColor = true;
            // 
            // chkDumpCosturaAsm
            // 
            this.chkDumpCosturaAsm.AutoSize = true;
            this.chkDumpCosturaAsm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.chkDumpCosturaAsm.Checked = true;
            this.chkDumpCosturaAsm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDumpCosturaAsm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDumpCosturaAsm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDumpCosturaAsm.ForeColor = System.Drawing.Color.Silver;
            this.chkDumpCosturaAsm.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDumpCosturaAsm.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDumpCosturaAsm.HoverForeColor = System.Drawing.Color.Gray;
            this.chkDumpCosturaAsm.Location = new System.Drawing.Point(529, 43);
            this.chkDumpCosturaAsm.Name = "chkDumpCosturaAsm";
            this.chkDumpCosturaAsm.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.chkDumpCosturaAsm.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.chkDumpCosturaAsm.PressForeColor = System.Drawing.Color.White;
            this.chkDumpCosturaAsm.Size = new System.Drawing.Size(225, 14);
            this.chkDumpCosturaAsm.TabIndex = 9;
            this.chkDumpCosturaAsm.Tag = "--dump-costura-assemblies";
            this.chkDumpCosturaAsm.Text = "Dump Costura-Fody Assemblies";
            this.chkDumpCosturaAsm.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(913, 536);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(30, 5, 30, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Reactor Slayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.panelLogs.ResumeLayout(false);
            this.ctxLogs.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBrowse)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.tabelOptions.ResumeLayout(false);
            this.tabelOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.RichTextBox txtLogs;
        private UserControls.NRSCheckBox chkCleanup;
        private System.Windows.Forms.TableLayoutPanel tabelOptions;
        private UserControls.NRSCheckBox chkDecryptResources;
        private UserControls.NRSCheckBox chkRemoveRefProxies;
        private UserControls.NRSCheckBox chkDeobCFlow;
        private UserControls.NRSCheckBox chkDumpCosturaAsm;
        private UserControls.NRSCheckBox chkDecryptTokens;
        private UserControls.NRSCheckBox chkDecryptMethods;
        private System.Windows.Forms.Panel pnlOptions;
        private UserControls.NRSCheckBox chkDumpDNRAsm;
        private UserControls.NRSCheckBox chkDecryptStrings;
        private UserControls.NRSCheckBox chkDecryptHiddenCalls;
        private UserControls.NRSCheckBox chkPatchAntiTD;
        private UserControls.NRSCheckBox chkPreserveAll;
        private UserControls.NRSCheckBox chkKeepOldMaxStack;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlButton;
        private UserControls.NRSButton btnStart;
        private UserControls.NRSTextBox txtInput;
        private System.Windows.Forms.Panel pnlTextBox;
        private System.Windows.Forms.PictureBox picBrowse;
        private System.Windows.Forms.Panel panelLogs;
        private UserControls.NRSScrollBar scrollbarLogs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel llblWebsite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llblGitHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip ctxLogs;
        private System.Windows.Forms.ToolStripMenuItem copyLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

