using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._3___MusicPlayer
{
				class MusicPlayer
				{
								private int songCounter;
								private Song[] songs;

								public MusicPlayer()
								{
												songs = new Song[20];
												songCounter = 0;
								}

								public bool AddSong(Song nwSong)
								{
												songs[songCounter] = nwSong;
												songCounter++;

												return true;
								}

								public Song GetSong(int id)
								{
												if (id >= 0 && id < songCounter)
																return songs[id];
												else
																return null;
								}

								public Song[] GetSongs()
								{
												return songs;
								}

								public int GetSongAmount()
								{
												return songCounter;
								}

								public Song[] GetSongs(string titleOrArtist)
								{
												titleOrArtist = titleOrArtist.ToLower();
												Song[] newList = new Song[songCounter];
												int newListCounter = 0;

												for (int i = 0; i < songCounter; i++)
												{
																Song song = songs[i];

																if (song.GetTitle().ToLower().Contains(titleOrArtist) || song.GetArtist().ToLower().Contains(titleOrArtist))
																{
																				newList[newListCounter] = song;
																				newListCounter++;
																}
												}

												return newList;
								}

								public Song[] GetSongs(int durationMinSeconds, int durationMaxSeconds)
								{
												Song[] newList = new Song[songCounter];
												int newListCounter = 0;

												for (int i = 0; i < songCounter; i++)
												{
																int duration = songs[i].GetDuration();
																if (duration >= durationMinSeconds && ((durationMaxSeconds > -1) ? (duration <= durationMaxSeconds) : true))
																{
																				newList[newListCounter] = songs[i];
																				newListCounter++;
																}
												}

												return newList;
								}
				}

				class Song
				{
								private int id;
								private string path;
								private string title;
								private string singer;
								private int durationInSeconds;
								private System.Media.SoundPlayer player;

								public Song(int _id, string nwPath, int nwDurationInSeconds, string nwTitle)
								{
												durationInSeconds = nwDurationInSeconds;
												title = nwTitle;
												path = nwPath;
												id = _id;

												player = new System.Media.SoundPlayer();
												player.SoundLocation = path;
								}

								public Song(int _id, string nwPath, int nwDurationInSeconds, string nwTitle, string nwSinger)
								{
												durationInSeconds = nwDurationInSeconds;
												singer = nwSinger;
												title = nwTitle;
												path = nwPath;
												id = _id;

												player = new System.Media.SoundPlayer();
												player.SoundLocation = path;
								}

								public void Play()
								{
												player.Play();
								}

								public int GetId()
								{
												return id;
								}

								public string GetInfo()
								{
												return $"{id} : {singer} - {title} ({durationInSeconds / 60}:{durationInSeconds % 60})";
								}

								public string GetTitle()
								{
												return title;
								}

								public string GetArtist()
								{
												return singer;
								}

								public int GetDuration()
								{
												return durationInSeconds;
								}
				}
}
