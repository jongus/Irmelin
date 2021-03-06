﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Irmelin
{
    public partial class Form1 : Form
    {
        Label[] labels = new Label[19];
        List<Tuple<string, string, string, string, string>> games = new List<Tuple<string, string, string, string, string>>();
        int menuStartPos = 0;
        int menuSelectedGame = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up the labels array
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
                labels[i].Text = "";
                labels[i].Top = 625 + (i * 50);
                this.Controls.Add(labels[i]);
            }
            //Read the games file and add it to games list
            try
            {
                using (StreamReader reader = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "games_l.cfg"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        games.Add(new Tuple<string, string, string, string, string>(parts[0], parts[1], parts[2], parts[3], parts[4]));
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine("I have problems redrawing the menu...");
                Console.WriteLine(ex.Message);
            }
            ReDrawMenu();
        }

        private void ReDrawMenu()
        {
            try
            {
                int cnt = games.Count > labels.Length ? labels.Length - 1 : games.Count - 1;
                for (int i = 0; i <= cnt; i++)
                {
                    labels[i].Text = games[i + menuStartPos].Item1;
                    labels[i].BackColor = menuSelectedGame == i ? Color.DimGray : Color.DarkGray;
                    labels[i].ForeColor = menuSelectedGame == i ? Color.DarkGray : Color.DimGray;
                    if (menuSelectedGame == i)
                    {
                        lblPlatform.Text = games[i + menuStartPos].Item2;
                        try
                        {
                            gamePicture.Image = Image.FromFile(games[i + menuStartPos].Item3);
                        } catch (Exception ex)
                        {
                            gamePicture.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("I have problems redrawing the menu...");
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                if(menuSelectedGame == 9)
                {
                    menuStartPos = menuStartPos > 0 ? menuStartPos - 1 : 0;
                    if (menuStartPos == 0)
                    {
                        menuSelectedGame = menuSelectedGame > 0 ? menuSelectedGame - 1 : 0;
                    }
                } else
                {
                    menuSelectedGame = menuSelectedGame > 0 ? menuSelectedGame - 1 : 0;
                }
                ReDrawMenu();
            }
            else if(e.KeyCode == Keys.Down)
            {
                if (menuSelectedGame == 9)
                {
                    menuStartPos = (games.Count - menuStartPos) >= labels.Length ? menuStartPos + 1 : games.Count - labels.Length;
                    if (menuStartPos == games.Count - labels.Length)
                    {
                        menuSelectedGame = menuSelectedGame < labels.Length - 1 ? menuSelectedGame + 1 : labels.Length - 1;
                        if (menuSelectedGame >= games.Count) menuSelectedGame = games.Count - 1;
                    }
                }
                else
                {
                    menuSelectedGame = menuSelectedGame < labels.Length - 1 ? menuSelectedGame + 1 : labels.Length - 1;
                    if (menuSelectedGame >= games.Count) menuSelectedGame = games.Count - 1;
                }
                ReDrawMenu();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Process ExternalProcess = new Process();
                    ExternalProcess.StartInfo.FileName = games[menuSelectedGame + menuStartPos].Item4;
                    ExternalProcess.StartInfo.Arguments = games[menuSelectedGame + menuStartPos].Item5;
                    ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    ExternalProcess.Start();
                    ExternalProcess.WaitForExit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not run " + games[menuSelectedGame + menuStartPos].Item4 + " " + games[menuSelectedGame + menuStartPos].Item5);
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
