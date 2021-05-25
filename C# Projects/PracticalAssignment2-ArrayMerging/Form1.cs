using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2PracticalAssignment2_ArrayMerging
{
    public partial class ArrayMerging : Form
    {
        //We know that c1 and c2 have 14 items each
        //Since we know these arrays have a fixed size, we can use arrays
        //And initialize them. "hard-coding"
        int[] c1 = { 1, 7, 3, 9, 2, 8, 5, 7, 2, 1, 9, 1, 3, 7 };
        int[] c2 = { 6, 2, 9, 5, 9, 7, 3, 2, 6, 4, 5, 0, 9, 5 };
        //You can also create the arrays here (e.g. new int[14]) and then add all the
        //items in the constructor

        //The results of the different methods of merging will be calculated at run-time
        //so we don't know how long they will be. So we use Lists
        List<int> concatenate = new List<int>(); //result of c1+c2
        List<int> merge = new List<int>(); //result of adding them one element from each array
        List<int> symmetricDiff = new List<int>(); //elements that are only in one of the arrays
        List<int> intersection = new List<int>(); //elements that are in both arrays

        //Convenience List versions of the arrays
        List<int> c1List = new List<int>();
        List<int> c2List = new List<int>();

        public ArrayMerging()
        {
            InitializeComponent();

            //first we add the arrays to the listBoxes for display purposes
            for (int i = 0; i < c1.Length; i++)
            {
                lbC1.Items.Add(c1[i]);
            }

            for (int i = 0; i < c2.Length; i++)
            {
                lbC2.Items.Add(c2[i]);
            }


            //Lets convert our arrays to Lists. We don't use it everywhere but I use it
            //to show you how to achieve the same results using different ways.
            for (int i = 0; i < c1.Length; i++)
            {
                c1List.Add(c1[i]);
            }
            for (int i = 0; i < c2.Length; i++)
            {
                c2List.Add(c2[i]);
            }
        }

        private void BtC1PlusC2_Click(object sender, EventArgs e)
        {
            concatenate.Clear(); //start fresh

            //this one is relatively easy... first add all elements from c1 to the list
            for (int i = 0; i < c1.Length; i++)
            {
                concatenate.Add(c1[i]);
            }
            //then all elements from c2
            for (int i = 0; i < c2.Length; i++)
            {
                concatenate.Add(c2[i]);
            }

            //Now, we have a List (concatenate) with our result
            //We still need to display it in the relevant ListBox
            lbAdd.Items.Clear();
            //Since we have a List, and we don't need to modify it anymore,
            //we can use foreach to iterate through the items
            foreach (var item in concatenate)
            {
                lbAdd.Items.Add(item);
            }
        }

        private void BtInterMerge_Click(object sender, EventArgs e)
        {
            merge.Clear(); //just in case we already have items in there

            //Here, we need to iterate through both arrays at the same time
            //so we only need one loop
            //The assumption here is that both arrays are the same length
            for (int i = 0; i < c1.Length; i++)
            {
                merge.Add(c1[i]);
                merge.Add(c2[i]);
            }

            //Similar to above, we need to display it
            lbMerge.Items.Clear();
            foreach (var item in merge)
            {
                lbMerge.Items.Add(item);
            }

        }

        private void BtSymmetricDiff_Click(object sender, EventArgs e)
        {
            symmetricDiff.Clear(); //start with empty list

            //This one is a bit more complicated. You need to loop through the first
            //array and search for each item in the second array (with an inner for loop.
            //You only add an item to the list if it is not found. Then repeat it the 
            //other way around: looping through second array and searching in the first array.
            //All the while, making sure you have no duplicate items

            //Or, if you are lazy like me, you can convert the arrays to lists and
            //use the List built-in methods. 
            //There is always more than one way to do something

            //Since we converted our arrays to lists (see constructor), we can use the 
            //List.Contains() method :D
            //.... and foreach
            foreach (var item in c1)
            {
                //if the item from c1 is NOT in c2...
                if (!c2.Contains(item))
                {
                    //... and the item is NOT already in symmetricDiff...
                    if (!symmetricDiff.Contains(item))
                    {
                        // we add it to the symmetricDiff list
                        symmetricDiff.Add(item);
                    }
                }
            }

            //and repeat it the other way around
            foreach (var item in c2)
            {
                //if the item from c2 is NOT in c1
                if (!c1.Contains(item))
                {
                    //... and the item is NOT already in symmetricDiff...
                    if (!symmetricDiff.Contains(item))
                    {
                        //we add it to the symmetricDiff list
                        symmetricDiff.Add(item);
                    }
                }
            }

            //... and we display it in the listbox
            lbDiff.Items.Clear();
            foreach (var item in symmetricDiff)
            {
                lbDiff.Items.Add(item);
            }
        }

        private void BtIntersection_Click(object sender, EventArgs e)
        {
            intersection.Clear();

            //Here you can do something similar to the previous method and loop 
            //through each item to make sure it is also present in the other array (or list).

            //I will use the converted lists we created in the constructor
            foreach (var item in c1List)
            {
                //if item from c1 exists in c2
                if (c2List.Contains(item))
                {
                    //and NOT already in intersection list
                    if (!intersection.Contains(item))
                    {
                        //add it to intersection list
                        intersection.Add(item);
                    }
                }
            }

            //We don't have to do the same for items in the second list because if the
            //item was not in the first list then we don't want to include it

            { //***BONUS***

                //If you did some research you would see that Lists have a method called 
                //Intersection() which does exactly what we want. But it does not return
                //a List, it returns an IEnurable which you need to change to a list.
                //You absolutely DO NOT need to know this for your exam but 
                //if you can be lazy, always be lazy. (as long as you still do it correctly)

                //If we use List.Intersect(), the foreach above can be replaced with
                //one line of code:
                intersection = c1List.Intersect(c2List).ToList();

            } //***END BONUS***


            //we now have to display the list in a listbox
            lbIntersect.Items.Clear();
            foreach (var item in intersection)
            {
                lbIntersect.Items.Add(item);
            }
        }
    }
}
