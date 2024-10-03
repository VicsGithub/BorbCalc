using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BorbCalc
{
    public partial class BorbCalc : Form
    {
        public BorbCalc()
        {
            InitializeComponent();
        }

        int Num1; // First inputted number
        int Num2; // Second inputted number
        string Option; // Math symbol
        int Result;

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "1";
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "2";
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "3";
        }

        private void Btn4_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "4";
        }

        private void Btn5_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "5";
        }

        private void Btn6_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "6";
        }

        private void Btn7_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "7";
        }

        private void Btn8_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "8";
        }

        private void Btn9_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "9";
        }

        private void Btn0_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text += "0";
        }

        private void BtnPlus_Click(object sender, System.EventArgs e)
        {
            Option = "+";
            Num1 = int.Parse(BorbsTotal.Text);

            BorbsTotal.Text = "";
        }

        private void BtnMin_Click(object sender, System.EventArgs e)
        {
            Option = "-";
            Num1 = int.Parse(BorbsTotal.Text);

            BorbsTotal.Text = "";
        }

        private void BtnMul_Click(object sender, System.EventArgs e)
        {
            Option = "*";
            Num1 = int.Parse(BorbsTotal.Text);

            BorbsTotal.Text = "";
        }

        private void BtnDiv_Click(object sender, System.EventArgs e)
        {
            Option = "/";
            Num1 = int.Parse(BorbsTotal.Text);

            BorbsTotal.Text = "";
        }

        private void BtnEql_Click(object sender, System.EventArgs e)
        {
            Num2 = int.Parse(BorbsTotal.Text);

            if (Option.Equals("+"))
                Result = Num1 + Num2;
            
            if(Option.Equals("-"))
                Result = Num1 - Num2;

            if (Option.Equals("*"))
                Result = Num1 * Num2;

            if (Option.Equals ("/"))
                Result = Num1 / Num2;

            BorbsTotal.Text = Result + "";
        }

        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            BorbsTotal.Text = string.Empty;
            Result = (0);
            Num1 = (0);
            Num2 = (0);
        }

        private void SaveBtn_Click(object sender, System.EventArgs e)
        {
            string CaveFileText = "# CaveInfo\r\n{\r\n\t{c000} 4 1 \t# SublevelCount\r\n\t{_eof} \r\n}\r\n1 # FloorInfo\r\n{\r\n\t{f000} 4 0 # CurrentSublevelIndex\r\n\t{f001} 4 0 # CurrentSublevelIndex\r\n\t{f002} 4 1 # EntityTotal\r\n\t{f003} 4 0 # TreasureTotal\r\n\t{f004} 4 0 # GateTotal\r\n\t{f005} 4 1 # RoomTotal\r\n\t{f006} 4 0.2 # CorridorRatio\r\n\t{f007} 4 0 # Geyser\r\n\t{f008} -1 1_ABE_ari_metal.txt # UnitFile\r\n\t{f009} -1 normal_light_lv0.ini # LightFile\r\n\t{f00A} -1 none # Skybox\r\n\t{f010} 4 0 # CloggedHole\r\n\t{f011} 4 0 # Unknown\r\n\t{f012} 4 0 # MusicType\r\n\t{f013} 4 0 # SolidPlane\r\n    {f014} 4 50 # DeadEndTotal\r\n\t{f015} 4 1 # Version(0=IgnoreCapInfo)\r\n\t{f016} 4 0 # WaterwraithTimer\r\n\t{f017} 4 0 # Seesaw(1=True)\r\n\t{_eof} \r\n}\r\n# TekiInfo\r\n{\r\n\t1 # num\r\n\tChappy " + Result + "" + "0 # weight\r\n\t0 # type\r\n}\r\n# ItemInfo\r\n{\r\n\t0 # num\r\n}\r\n# GateInfo\r\n{\r\n\t0 # num\r\n}\r\n# CapInfo\r\n{\r\n\t0 # num\r\n}\r\n";
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "urcave.txt"), CaveFileText);
            _ = MessageBox.Show("Cave saved in app directory.", "BorbCalc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RickAstleyLabel_Click(object sender, EventArgs e)
        {
            // :)
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
