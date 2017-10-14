using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irmelin
{
    public partial class Form1 : Form
    {
        Label[] labels = new Label[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string settingsFile = System.AppDomain.CurrentDomain.BaseDirectory + "arcade.cfg";


            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Font = labelModel.Font;
                labels[i].Width = labelModel.Width;
                labels[i].Height = labelModel.Height;
                labels[i].BackColor = labelModel.BackColor;
                labels[i].ForeColor = labelModel.ForeColor;
                labels[i].Left = labelModel.Left;
                labels[i].TextAlign = labelModel.TextAlign;
                labels[i].Text = "-";
                labels[i].Top = 625 + (i * 50);
                this.Controls.Add(labels[i]);
            }


        }
    }
}
