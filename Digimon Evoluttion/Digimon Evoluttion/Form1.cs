using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Digimon_Evoluttion
{
    public partial class Form1 : Form
    {

		/*public List<Digimon> digimonsBaby = new List<Digimon>();
		public List<Digimon> digimonsInTraining = new List<Digimon>();
		public List<Digimon> digimonsRookie = new List<Digimon>();
		public List<Digimon> digimonsChampion = new List<Digimon>();
		public List<Digimon> digimonsUltimate = new List<Digimon>();
		public List<Digimon> digimonsMega = new List<Digimon>();
		public List<Digimon> digimonsDigiEgg = new List<Digimon>();
		public List<Digimon> digimonsBeyondMega = new List<Digimon>();*/

		string[] digimons;
		string path = @"C:\Users\daniel.louro\Desktop\DigimonCyberSleuthEvolution\Digimon Evoluttion\Digimon Evoluttion\bin\Debug\All digimon list.txt";

        public Form1()
        {
            InitializeComponent();
			digimons = File.ReadAllLines(path);

			for(int i = 0; i < digimons.Length; i++) MessageBox.Show(digimons[i]);
        }

		private void changeTheChosenLevel(object sender, EventArgs e)
		{
			if (radioButtonBaby.Checked)
			{
				string[] onLevelDigimon = digimons[0].Split(';');
				comboBox1.Items.Clear();
				for (int i = 0; i < onLevelDigimon.Length; i++) comboBox1.Items.Add(onLevelDigimon[i]);
			}
			else if (radioButtonInTraining.Checked)
			{
				string[] onLevelDigimon = digimons[1].Split(';');
				comboBox1.Items.Clear();
				for (int i = 0; i < onLevelDigimon.Length; i++) comboBox1.Items.Add(onLevelDigimon[i]);
			}
			else if (radioButtonRookie.Checked)
			{
				string[] onLevelDigimon = digimons[2].Split(';');
				comboBox1.Items.Clear();
				for (int i = 0; i < onLevelDigimon.Length; i++) comboBox1.Items.Add(onLevelDigimon[i]);
			}
			else if (radioButtonChampion.Checked)
			{
				string[] onLevelDigimon = digimons[3].Split(';');
				comboBox1.Items.Clear();
				for (int i = 0; i < onLevelDigimon.Length; i++) comboBox1.Items.Add(onLevelDigimon[i]);
			}
			else if (radioButtonUltimate.Checked)
			{
				string[] onLevelDigimon = digimons[4].Split(';');
				comboBox1.Items.Clear();
				for (int i = 0; i < onLevelDigimon.Length; i++) comboBox1.Items.Add(onLevelDigimon[i]);
			}
			else if (radioButtonMega.Checked)
			{
				string[] onLevelDigimon = digimons[5].Split(';');
				comboBox1.Items.Clear();
				for (int i = 0; i < onLevelDigimon.Length; i++) comboBox1.Items.Add(onLevelDigimon[i]);
			}
			else if (radioButtonDigiEggs.Checked)
			{
				string[] onLevelDigimon = digimons[6].Split(';');
				comboBox1.Items.Clear();
				for (int i = 0; i < onLevelDigimon.Length; i++) comboBox1.Items.Add(onLevelDigimon[i]);
			}
			else if (radioButtonBeyondMega.Checked)
			{
				string[] onLevelDigimon = digimons[7].Split(';');
				comboBox1.Items.Clear();
				for (int i = 0; i < onLevelDigimon.Length; i++) comboBox1.Items.Add(onLevelDigimon[i]);
			}
		}
    }
}
