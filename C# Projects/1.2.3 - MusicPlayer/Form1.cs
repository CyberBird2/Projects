using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2._3___MusicPlayer
{
				public partial class Form1 : Form
				{
								private MusicPlayer musicPlayer;

								public Form1()
								{
												InitializeComponent();
												musicPlayer = new MusicPlayer();
								}

								private void btnBrowse_Click(object sender, EventArgs e)
								{
												DialogResult dr = openFileDialog.ShowDialog();
												if (dr == DialogResult.OK)
												{  //the user pushed the OK-button of openFileDialog1
																tbxPath.Text = openFileDialog.FileName;
												}
												else
												{  //the user pushed the CANCEL-button of openFileDialog1
															// MessageBox.Show("You pushed the CANCEL-button.");
												}
								}

								private void tbxAdd_Click(object sender, EventArgs e)
								{
												string durationMin = tbxMin.Text.Trim();
												string durationSec = tbxSec.Text.Trim();
												if (durationMin == null || durationSec == null || durationMin == "" || durationSec == "")
												{
																MessageBox.Show("You haven't filled in everything", "Error");
																return;
												}

												int durationInSeconds = (Convert.ToInt32(tbxMin.Text) * 60) + Convert.ToInt32(tbxSec.Text);
												string singer = tbxSinger.Text.Trim();
												string title = tbxTitle.Text.Trim();
												string path = tbxPath.Text.Trim();

												if (title == null || path == null || title == "" || path == "")
												{
																MessageBox.Show("You haven't filled in everything", "Error");
																return;
												}

												if (singer == "")
																musicPlayer.AddSong(new Song(5, path, durationInSeconds, title));
												else
																musicPlayer.AddSong(new Song(5, path, durationInSeconds, title, singer));

												tbxSinger.Text = "";
												tbxTitle.Text = "";
												tbxPath.Text = "";
												tbxMin.Text = "";
												tbxSec.Text = "";

												updateInterface(null);
								}

								private Song[] updateInterface(string searchQuery)
								{
												Song[] songs;

												if (searchQuery == null)
																songs = musicPlayer.GetSongs();
												else
												{
																songs = musicPlayer.GetSongs(searchQuery);
																MatchCollection matches = Regex.Matches(searchQuery, @"^(\d+)(-(\d+))?$");

																if (matches.Count > 0)
																{
																				Match match = matches[0];
																				if (match.Groups[1] != null)
																				{
																								int duration = Convert.ToInt32(match.Groups[1].ToString());
																								int maxDuration = -1;

																								if (match.Groups[3].Success)
																												maxDuration = Convert.ToInt32(match.Groups[3].ToString());

																								Song[] newArrVals = musicPlayer.GetSongs(duration, maxDuration);
																								Song[] newArr = new Song[songs.Length + newArrVals.Length];

																								songs.CopyTo(newArr, 0);
																								newArrVals.CopyTo(newArr, songs.Length);

																								songs = newArr;
																				}
																}
												}

												lbxPlaylist.Items.Clear();
												for (int i = 0; i < songs.Length; i++)
												{
																Song song = songs[i];

																if (song != null)
																				lbxPlaylist.Items.Add($"[{i + 1}]   {song.GetInfo()}");
												}

												return songs;
								}

								private void btnPlay_Click(object sender, EventArgs e)
								{
												int selectedItem = lbxPlaylist.SelectedIndex;
												string query = tbxSongSearch.Text.Trim();

												Console.WriteLine(selectedItem);

												if (query != "")
																updateInterface(tbxSongSearch.Text)[selectedItem].Play();
												else if (selectedItem > -1)
																musicPlayer.GetSong(selectedItem).Play();
								}

								private void tbxSongSearch_TextChanged(object sender, EventArgs e)
								{
												updateInterface(tbxSongSearch.Text.Trim());
								}
				}
}
