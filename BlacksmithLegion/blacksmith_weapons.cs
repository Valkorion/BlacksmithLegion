﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksmithLegion
{
    public partial class blacksmith_weapons : Form
    {

        public blacksmith_weapons()
        {

            InitializeComponent();
     
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
    

            //Panel Color
            // Main Background
            itemVisualizer.BackColor = ColorTranslator.FromHtml("#071129");
            objectLevel.ForeColor = ColorTranslator.FromHtml("#ffd100");
            objectLqe.ForeColor = Color.White;
            objectUsage.ForeColor = Color.White;
            objectType.ForeColor = Color.White;
            objectDescription.ForeColor = ColorTranslator.FromHtml("#ffd100");
            

            //Quality Color
            objectName.Text = objectName_textbox.Text;
            // GREEN
            if (objectQuality_textbox.SelectedText == "Bonne (Vert)")
                objectName.ForeColor = ColorTranslator.FromHtml("#1eff00");



            objectLevel.Text = "Niveau d'objet " + objectIlvl_textbox.Text;
            objectLqe.Text = "Lié quand équipé";
            objectUsage.Text = objectUsage_combobox.Text;
            objectType.Text = objectType_combobox.Text;
            objectDescription.Text =  objectDescription_richtextbox.Text;
           

            if (objectStat1_combobox.SelectedIndex == -1 && objectStat2_combobox.SelectedIndex == -1 && objectStat3_combobox.SelectedIndex == -1 &&
                objectStat4_combobox.SelectedIndex == -1 && objectStat5_combobox.SelectedIndex == -1 && objectStat6_combobox.SelectedIndex == -1 &&
                objectStat7_combobox.SelectedIndex == -1 && objectStat8_combobox.SelectedIndex == -1 && objectStat9_combobox.SelectedIndex == -1 &&
                objectStat10_combobox.SelectedIndex == -1)
            {
                Stat1.Visible = false;
                Stat2.Visible = false;
                Stat3.Visible = false;
                Stat4.Visible = false;
                Stat5.Visible = false;
                Stat6.Visible = false;
                Stat7.Visible = false;
                Stat8.Visible = false;
                Stat9.Visible = false;
                Stat10.Visible = false;
    

                int newWidth = 298;
                int newHeight = 150;

                itemVisualizer.Size = new Size(newWidth, newHeight);
                itemVisualizer.AutoSize = true;

                objectRequiredLvL.Location = new Point(2, 68);
                objectDescription.Location = new Point(2, 81);


        
              }
            else
            {
                Stat1.Visible = true;
                Stat2.Visible = true;
                Stat3.Visible = true;
                Stat4.Visible = true;
                Stat5.Visible = true;
                Stat6.Visible = true;
                Stat7.Visible = true;
                Stat8.Visible = true;
                Stat9.Visible = true;
                Stat10.Visible = true;

                int baseWidth = 298;
                int baseHeight = 255;

                itemVisualizer.Size = new Size(baseWidth, baseHeight);
                itemVisualizer.AutoSize = true;

                objectRequiredLvL.Location = new Point(2, 211);
                objectDescription.Location = new Point(2, 224);
            }

            Stat1.Text = objectStat1_combobox.Text;
            Stat2.Text = objectStat2_combobox.Text;
            Stat3.Text = objectStat3_combobox.Text;
            Stat4.Text = objectStat4_combobox.Text;
            Stat5.Text = objectStat5_combobox.Text;
            Stat6.Text = objectStat6_combobox.Text;
            Stat7.Text = objectStat7_combobox.Text;
            Stat8.Text = objectStat8_combobox.Text;
            Stat9.Text = objectStat9_combobox.Text;
            Stat10.Text = objectStat10_combobox.Text;
            objectRequiredLvL.ForeColor = Color.White;
            objectRequiredLvL.Text = "Niveau " + objectLevel_textbox.Text + " requis";


      

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            while (true)
            {
                Thread.Sleep(100);
                this.itemVisualizer.Invoke(new MethodInvoker(delegate () { this.itemVisualizer.Refresh(); }));
                this.pictureBox1.Invoke(new MethodInvoker(delegate () { this.pictureBox1.Refresh(); }));
                if (string.IsNullOrWhiteSpace(this.objectIcon_textbox.Text))
                {
                    this.pictureBox1.Invoke(new MethodInvoker(delegate () { this.pictureBox1.ImageLocation = "http://wow.zamimg.com/images/wow/icons/large/inv_misc_questionmark.jpg"; }));
                }
                else
                {
                    if (pictureBox1.Image == pictureBox1.ErrorImage)
                    {
                        this.objectIcon_textbox.Invoke(new MethodInvoker(delegate () { this.objectIcon_textbox.Text = "Icône invalide !"; }));
                        this.objectIcon_textbox.Invoke(new MethodInvoker(delegate () { this.objectIcon_textbox.ForeColor = Color.Red; }));
                    }
                    else
                    {
                        this.pictureBox1.Invoke(new MethodInvoker(delegate () { this.pictureBox1.ImageLocation = "http://wow.zamimg.com/images/wow/icons/large/" + objectIcon_textbox.Text + ".jpg"; }));
                    }
                    
                }
                  
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void objectLevel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void objectType_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
        ItemClass = 2

        Subclass
        Axe One handed 0
        Axe Two handed 1
        Bow 2
        Gun 3
        Mace One handed 4
        Mace Two handed 5
        Polearm 6
        Sword One handed 7
        Sword Two handed 8
        Obsolete 9
        Staff 10
        Exotic 11
        Exotic 12
        Fist Weapon 13
        Miscellaneous (Blacksmith Hammer, Mining Pick, etc.) 14
        Dagger 15
        Thrown 16
        Spear 17
        Crossbow 18
        Wand 19
        */
    }
}