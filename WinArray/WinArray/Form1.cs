using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] A = txt1.Text.Split(' ').Select(int.Parse).ToArray();
            int[] B = txt2.Text.Split(' ').Select(int.Parse).ToArray();

            int[] intersection = getIntersect(A, B);
            int[] difference = getDiff(A, B);
            int[] symmetricalDifference = getSymmDiff(A, B);
            int[] union = getUnion(A, B);

            IntersectionLBL.Text = ("Intersection: " + string.Join(", ", intersection));
            DifferenceLBL.Text = ("Difference: " + string.Join(", ", difference));
            SymmDiffLBL.Text = ("Symmetrical Difference: " + string.Join(", ", symmetricalDifference));
            UnionLBL.Text = ("Union: " + string.Join(", ", union));

        }
        public int[] getIntersect(int[] A, int[] B)
        {
            var intersection = A.Intersect(B).ToArray();
            Array.Sort(intersection);
            return intersection;

        }

        public int[] getDiff(int[] A, int[] B)
        {
            var difference = B.Except(A).ToArray();
            Array.Sort(difference);
            return difference;
        }

        public int[] getSymmDiff(int[] A, int[] B)
        {
            var symmetricalDifference = A.Union(B).Except(A.Intersect(B)).ToArray();
            Array.Sort(symmetricalDifference);
            return symmetricalDifference;
        }

        public int[] getUnion(int[] A, int[] B)
        {
            var union = A.Union(B).ToArray();
            Array.Sort(union);
            return union;
        }
    }
}
