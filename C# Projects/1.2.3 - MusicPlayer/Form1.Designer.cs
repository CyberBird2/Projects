namespace _1._2._3___MusicPlayer
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
												this.groupBox1 = new System.Windows.Forms.GroupBox();
												this.label6 = new System.Windows.Forms.Label();
												this.tbxSinger = new System.Windows.Forms.TextBox();
												this.btnBrowse = new System.Windows.Forms.Button();
												this.tbxPath = new System.Windows.Forms.TextBox();
												this.label5 = new System.Windows.Forms.Label();
												this.label4 = new System.Windows.Forms.Label();
												this.tbxAdd = new System.Windows.Forms.Button();
												this.label2 = new System.Windows.Forms.Label();
												this.label1 = new System.Windows.Forms.Label();
												this.label3 = new System.Windows.Forms.Label();
												this.tbxTitle = new System.Windows.Forms.TextBox();
												this.tbxMin = new System.Windows.Forms.TextBox();
												this.tbxSec = new System.Windows.Forms.TextBox();
												this.lbxPlaylist = new System.Windows.Forms.ListBox();
												this.btnPlay = new System.Windows.Forms.Button();
												this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
												this.tbxSongSearch = new System.Windows.Forms.TextBox();
												this.lblSearch = new System.Windows.Forms.Label();
												this.groupBox1.SuspendLayout();
												this.SuspendLayout();
												// 
												// groupBox1
												// 
												this.groupBox1.Controls.Add(this.label6);
												this.groupBox1.Controls.Add(this.tbxSinger);
												this.groupBox1.Controls.Add(this.btnBrowse);
												this.groupBox1.Controls.Add(this.tbxPath);
												this.groupBox1.Controls.Add(this.label5);
												this.groupBox1.Controls.Add(this.label4);
												this.groupBox1.Controls.Add(this.tbxAdd);
												this.groupBox1.Controls.Add(this.label2);
												this.groupBox1.Controls.Add(this.label1);
												this.groupBox1.Controls.Add(this.label3);
												this.groupBox1.Controls.Add(this.tbxTitle);
												this.groupBox1.Controls.Add(this.tbxMin);
												this.groupBox1.Controls.Add(this.tbxSec);
												this.groupBox1.Location = new System.Drawing.Point(12, 12);
												this.groupBox1.Name = "groupBox1";
												this.groupBox1.Size = new System.Drawing.Size(357, 155);
												this.groupBox1.TabIndex = 0;
												this.groupBox1.TabStop = false;
												this.groupBox1.Text = "Song";
												// 
												// label6
												// 
												this.label6.AutoSize = true;
												this.label6.Location = new System.Drawing.Point(6, 100);
												this.label6.Name = "label6";
												this.label6.Size = new System.Drawing.Size(40, 13);
												this.label6.TabIndex = 12;
												this.label6.Text = "Singer:";
												// 
												// tbxSinger
												// 
												this.tbxSinger.Location = new System.Drawing.Point(118, 97);
												this.tbxSinger.Name = "tbxSinger";
												this.tbxSinger.Size = new System.Drawing.Size(233, 20);
												this.tbxSinger.TabIndex = 13;
												this.tbxSinger.Text = "Je Moeder";
												// 
												// btnBrowse
												// 
												this.btnBrowse.Location = new System.Drawing.Point(276, 19);
												this.btnBrowse.Name = "btnBrowse";
												this.btnBrowse.Size = new System.Drawing.Size(75, 23);
												this.btnBrowse.TabIndex = 10;
												this.btnBrowse.Text = "Browse...";
												this.btnBrowse.UseVisualStyleBackColor = true;
												this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
												// 
												// tbxPath
												// 
												this.tbxPath.Location = new System.Drawing.Point(118, 19);
												this.tbxPath.Name = "tbxPath";
												this.tbxPath.Size = new System.Drawing.Size(152, 20);
												this.tbxPath.TabIndex = 11;
												// 
												// label5
												// 
												this.label5.AutoSize = true;
												this.label5.Location = new System.Drawing.Point(6, 24);
												this.label5.Name = "label5";
												this.label5.Size = new System.Drawing.Size(50, 13);
												this.label5.TabIndex = 7;
												this.label5.Text = "File path:";
												// 
												// label4
												// 
												this.label4.AutoSize = true;
												this.label4.Location = new System.Drawing.Point(327, 48);
												this.label4.Name = "label4";
												this.label4.Size = new System.Drawing.Size(24, 13);
												this.label4.TabIndex = 6;
												this.label4.Text = "sec";
												// 
												// tbxAdd
												// 
												this.tbxAdd.Location = new System.Drawing.Point(118, 123);
												this.tbxAdd.Name = "tbxAdd";
												this.tbxAdd.Size = new System.Drawing.Size(233, 23);
												this.tbxAdd.TabIndex = 1;
												this.tbxAdd.Text = "Add to playlist";
												this.tbxAdd.UseVisualStyleBackColor = true;
												this.tbxAdd.Click += new System.EventHandler(this.tbxAdd_Click);
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Location = new System.Drawing.Point(6, 48);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(50, 13);
												this.label2.TabIndex = 1;
												this.label2.Text = "Duration:";
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Location = new System.Drawing.Point(6, 74);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(30, 13);
												this.label1.TabIndex = 0;
												this.label1.Text = "Title:";
												// 
												// label3
												// 
												this.label3.AutoSize = true;
												this.label3.Location = new System.Drawing.Point(197, 48);
												this.label3.Name = "label3";
												this.label3.Size = new System.Drawing.Size(23, 13);
												this.label3.TabIndex = 2;
												this.label3.Text = "min";
												// 
												// tbxTitle
												// 
												this.tbxTitle.Location = new System.Drawing.Point(118, 71);
												this.tbxTitle.Name = "tbxTitle";
												this.tbxTitle.Size = new System.Drawing.Size(233, 20);
												this.tbxTitle.TabIndex = 3;
												this.tbxTitle.Text = "I Like Pizza";
												// 
												// tbxMin
												// 
												this.tbxMin.Location = new System.Drawing.Point(118, 45);
												this.tbxMin.Name = "tbxMin";
												this.tbxMin.Size = new System.Drawing.Size(73, 20);
												this.tbxMin.TabIndex = 5;
												this.tbxMin.Text = "1";
												// 
												// tbxSec
												// 
												this.tbxSec.Location = new System.Drawing.Point(248, 45);
												this.tbxSec.Name = "tbxSec";
												this.tbxSec.Size = new System.Drawing.Size(73, 20);
												this.tbxSec.TabIndex = 4;
												this.tbxSec.Text = "53";
												// 
												// lbxPlaylist
												// 
												this.lbxPlaylist.FormattingEnabled = true;
												this.lbxPlaylist.Location = new System.Drawing.Point(12, 173);
												this.lbxPlaylist.Name = "lbxPlaylist";
												this.lbxPlaylist.Size = new System.Drawing.Size(357, 238);
												this.lbxPlaylist.TabIndex = 8;
												// 
												// btnPlay
												// 
												this.btnPlay.Location = new System.Drawing.Point(212, 417);
												this.btnPlay.Name = "btnPlay";
												this.btnPlay.Size = new System.Drawing.Size(157, 23);
												this.btnPlay.TabIndex = 9;
												this.btnPlay.Text = "Play selected song";
												this.btnPlay.UseVisualStyleBackColor = true;
												this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
												// 
												// openFileDialog
												// 
												this.openFileDialog.FileName = "openFileDialog";
												// 
												// tbxSongSearch
												// 
												this.tbxSongSearch.Location = new System.Drawing.Point(62, 419);
												this.tbxSongSearch.Name = "tbxSongSearch";
												this.tbxSongSearch.Size = new System.Drawing.Size(141, 20);
												this.tbxSongSearch.TabIndex = 10;
												this.tbxSongSearch.Tag = "";
												this.tbxSongSearch.TextChanged += new System.EventHandler(this.tbxSongSearch_TextChanged);
												// 
												// lblSearch
												// 
												this.lblSearch.AutoSize = true;
												this.lblSearch.Location = new System.Drawing.Point(12, 422);
												this.lblSearch.Name = "lblSearch";
												this.lblSearch.Size = new System.Drawing.Size(44, 13);
												this.lblSearch.TabIndex = 11;
												this.lblSearch.Text = "Search:";
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(382, 451);
												this.Controls.Add(this.lblSearch);
												this.Controls.Add(this.tbxSongSearch);
												this.Controls.Add(this.btnPlay);
												this.Controls.Add(this.lbxPlaylist);
												this.Controls.Add(this.groupBox1);
												this.Name = "Form1";
												this.Text = "Music Player Application";
												this.groupBox1.ResumeLayout(false);
												this.groupBox1.PerformLayout();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion
								private System.Windows.Forms.GroupBox groupBox1;
								private System.Windows.Forms.Button btnBrowse;
								private System.Windows.Forms.TextBox tbxPath;
								private System.Windows.Forms.Label label5;
								private System.Windows.Forms.Label label4;
								private System.Windows.Forms.Button tbxAdd;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.Label label3;
								private System.Windows.Forms.TextBox tbxTitle;
								private System.Windows.Forms.TextBox tbxMin;
								private System.Windows.Forms.TextBox tbxSec;
								private System.Windows.Forms.ListBox lbxPlaylist;
								private System.Windows.Forms.Button btnPlay;
								private System.Windows.Forms.OpenFileDialog openFileDialog;
								private System.Windows.Forms.Label label6;
								private System.Windows.Forms.TextBox tbxSinger;
								private System.Windows.Forms.TextBox tbxSongSearch;
								private System.Windows.Forms.Label lblSearch;
				}
}

