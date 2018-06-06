﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TimeSpaceGenerator.Core;
using TimeSpaceGenerator.Enums;
using TimeSpaceGenerator.Errors;
using TimeSpaceGenerator.Handlers;
using TimeSpaceGenerator.Helpers;

namespace TimeSpaceGenerator
{
    public partial class Form1 : Form
    {
        public TriggerHandler PacketTriggerHandler { get; set; }

        public Form1()
        {
            InitializeComponent();
            PacketTriggerHandler = new TriggerHandler();
            PacketTriggerHandler.GenerateHandlerReferences(typeof(ScriptedInstancePacketHandler));
        }

        private void GenerateXmlButton_Click(object sender, EventArgs e)
        {
            ErrorTextBox.Text = string.Empty;
            ErrorManager.Instance.Error.Clear();
            foreach (string line in PacketTextBox.Lines.Where(s => !string.IsNullOrEmpty(s)))
            {
                string cpy = line;
                if (!char.IsLetter(line[0]))
                {
                    //I know this is dirty as fuck
                    cpy = line.Remove(0, PacketHelper.Instance.RemovableStringIndex(line, '[', ']', 2, 2));
                }
                string[] packetSplit = cpy.Split(' ');
                cpy = PacketHelper.Instance.FormatPacket(cpy, ' ');
                PacketTriggerHandler.TriggerHandlerPacket(packetSplit[0], cpy, true);
            }

            foreach (KeyValuePair<ErrorType, string> item in ErrorManager.Instance.Error)
            {
                ErrorTextBox.Text += $"{item.Key.ToString()}: {item.Value}" + Environment.NewLine;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
