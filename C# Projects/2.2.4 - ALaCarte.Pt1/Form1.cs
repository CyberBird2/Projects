using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2._4___ALaCarte.Pt1
{
				public partial class Form1 : Form
				{
								private List<Group> queue;

								public Form1()
								{
												InitializeComponent();
												queue = new List<Group>();
								}

								private Group dequeue()
								{
												Group t = queue[0];
												queue.RemoveAt(0);
												return t;
								}

								private void updateInterface()
								{
												tbQueue.Items.Clear();

												foreach (Group g in queue)
																tbQueue.Items.Add(g.GetName());
								}

								private void btnAdd_Click(object sender, EventArgs e)
								{
												string name = tbName.Text.Trim();

												if (name.Length > 0)
																queue.Add(new Group(name));

												updateInterface();
								}

								private void btnRemove_Click(object sender, EventArgs e)
								{
												int selectedNum = tbQueue.SelectedIndex;

												if (selectedNum > -1)
																queue.RemoveAt(selectedNum);

												updateInterface();
								}

								private void lblTable_Click(object sender, EventArgs e)
								{
												if (queue.Count > 0)
												{
																((Label)sender).Text += dequeue().GetName();
																updateInterface();
												}
								}
				}
}
