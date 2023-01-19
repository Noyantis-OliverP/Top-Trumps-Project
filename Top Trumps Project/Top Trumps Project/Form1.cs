using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top_Trumps_Project
{
    public partial class Form1 : Form
    {
        List<List<String>> cardDeck = new List<List<String>>();
        int onCard = 0;
        int listLength;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("SavedDeck.txt"))
            {
                
            }
            else
            {
                cardDeck.Add(new List<String>());
                for (int i = 0; i < 12; i++)
                {
                    cardDeck[onCard].Add("");
                }
            }

            listLength = cardDeck.Count;
            TextChange();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (File.Exists("SavedDeck.txt"))
            {
                File.Delete("SavedDeck.txt");
            }
            for (int i = 0; i < listLength; i++)
            {
                for (int x = 0; x < 12; x++)
                {
                    File.AppendAllText("SavedDeck.txt", cardDeck[i][x] + "\n");
                    Console.WriteLine(cardDeck[i][x]);
                }
                File.AppendAllText("SavedDeck.txt", "-----\n");
            }


            //this.Close();
        }

        private void txtBox_Card_Name_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][0] = txtBox_Card_Name.Text;
            if (cardDeck[onCard][0] != "")
            {
                lab_Card_Preview_Card_Name.Text = cardDeck[onCard][0];
            }
            else
            {
                lab_Card_Preview_Card_Name.Text = "Card Name";
            }
        }

        private void txtBox_Attribute1_Name_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][1] = txtBox_Attribute1_Name.Text;
            if (cardDeck[onCard][1] != "")
            {
                lab_Card_Preview_Attribute1_Name.Text = cardDeck[onCard][1];
            }
            else
            {
                lab_Card_Preview_Attribute1_Name.Text = "Attribute 1:";
            }
        }

        private void txtBox_Attribute1_Value_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][2] = txtBox_Attribute1_Value.Text; 
            if (cardDeck[onCard][2] != "")
            {
                lab_Card_Preview_Attribute1_Value.Text = cardDeck[onCard][2];
            }
            else
            {
                lab_Card_Preview_Attribute1_Value.Text = "Value";
            }
        }

        private void txtBox_Attribute2_Name_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][3] = txtBox_Attribute2_Name.Text;
            if (cardDeck[onCard][3] != "")
            {
                lab_Card_Preview_Attribute2_Name.Text = cardDeck[onCard][3];
                Console.WriteLine("triggered");
            }
            else
            {
                lab_Card_Preview_Attribute2_Name.Text = "Attribute 2:";
            }
        }

        private void txtBox_Attribute2_Value_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][4] = txtBox_Attribute2_Value.Text;
            if (cardDeck[onCard][4] != "")
            {
                lab_Card_Preview_Attribute2_Value.Text = cardDeck[onCard][4];
            }
            else
            {
                lab_Card_Preview_Attribute2_Value.Text = "Value";
            }
        }

        private void txtBox_Attribute3_Name_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][5] = txtBox_Attribute3_Name.Text;

            if (cardDeck[onCard][5] != "")
            {
                lab_Card_Preview_Attribute3_Name.Text = cardDeck[onCard][5];
            }
            else
            {
                lab_Card_Preview_Attribute3_Name.Text = "Attribute 3:";
            }
        }

        private void txtBox_Attribute3_Value_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][6] = txtBox_Attribute3_Value.Text;
            if (cardDeck[onCard][6] != "")
            {
                lab_Card_Preview_Attribute3_Value.Text = cardDeck[onCard][6];
            }
            else
            {
                lab_Card_Preview_Attribute3_Value.Text = "Value";
            }
        }

        private void txtBox_Attribute4_Name_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][7] = txtBox_Attribute4_Name.Text;
            if (cardDeck[onCard][7] != "")
            {
                lab_Card_Preview_Attribute4_Name.Text = cardDeck[onCard][7];
            }
            else
            {
                lab_Card_Preview_Attribute4_Name.Text = "Attribute 4:";
            }
        }

        private void txtBox_Attribute4_Value_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][8] = txtBox_Attribute4_Value.Text;
            if (cardDeck[onCard][8] != "")
            {
                lab_Card_Preview_Attribute4_Value.Text = cardDeck[onCard][8];
            }
            else
            {
                lab_Card_Preview_Attribute4_Value.Text = "Value";
            }
        }

        private void txtBox_Attribute5_Name_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][9] = txtBox_Attribute5_Name.Text;
            if (cardDeck[onCard][9] != "")
            {
                lab_Card_Preview_Attribute5_Name.Text = cardDeck[onCard][9];
            }
            else
            {
                lab_Card_Preview_Attribute5_Name.Text = "Attribute 5:";
            }
        }

        private void txtBox_Attribute5_Value_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][10] = txtBox_Attribute5_Value.Text;
            if (cardDeck[onCard][10] != "")
            {
                lab_Card_Preview_Attribute5_Value.Text = cardDeck[onCard][10];
            }
            else
            {
                lab_Card_Preview_Attribute5_Value.Text = "Value";
            }
        }

        private void txtBox_Image_TextChanged(object sender, EventArgs e)
        {
            cardDeck[onCard][11] = txtBox_Image.Text;
        }

        private void btn_Previous_Card_Click(object sender, EventArgs e)
        {
            if (onCard > 0)
            {
                onCard--;
                TextChange();
            }
            Console.WriteLine(onCard);
        }

        private void btn_Next_Card_Click(object sender, EventArgs e)
        {
            if (onCard + 1 < listLength)
            {
                onCard++;
                TextChange();
            }
            Console.WriteLine(onCard);
        }

        private void btn_Create_New_Card_Click(object sender, EventArgs e)
        {
            onCard = listLength;
            Console.WriteLine(onCard);
            cardDeck.Add(new List<String>());
            for (int i = 0; i < 12; i++)
            {
                cardDeck[onCard].Add("");
            }
            listLength = cardDeck.Count; 
            TextChange();
        }

        private void btn_Delete_Card_Click(object sender, EventArgs e)
        {
            if (listLength > 1)
            {
                Console.WriteLine(onCard);
                cardDeck.RemoveAt(onCard);
                if (onCard > 0)
                {
                    onCard--;
                    Console.WriteLine(onCard);
                }
                listLength = cardDeck.Count;
                TextChange();
                Console.WriteLine(listLength);
            }
        }

        private void TextChange()
        {
            txtBox_Card_Name.Text = cardDeck[onCard][0];
            if (cardDeck[onCard][0] != "")
            {
                lab_Card_Preview_Card_Name.Text = cardDeck[onCard][0];
            }
            else
            {
                lab_Card_Preview_Card_Name.Text = "Card Name";
            }

            txtBox_Attribute1_Name.Text = cardDeck[onCard][1];
            if (cardDeck[onCard][1] != "")
            {
                lab_Card_Preview_Attribute1_Name.Text = cardDeck[onCard][1];
            }
            else
            {
                lab_Card_Preview_Attribute1_Name.Text = "Attribute 1:";
            }

            txtBox_Attribute1_Value.Text = cardDeck[onCard][2];
            if (cardDeck[onCard][2] != "")
            {
                lab_Card_Preview_Attribute1_Value.Text = cardDeck[onCard][2];
            }
            else
            {
                lab_Card_Preview_Attribute1_Value.Text = "Value";
            }

            txtBox_Attribute2_Name.Text = cardDeck[onCard][3];
            if (cardDeck[onCard][3] != "")
            {
                lab_Card_Preview_Attribute2_Name.Text = cardDeck[onCard][3];
                Console.WriteLine("triggered");
            }
            else
            {
                lab_Card_Preview_Attribute2_Name.Text = "Attribute 2:";
            }

            txtBox_Attribute2_Value.Text = cardDeck[onCard][4];
            if (cardDeck[onCard][4] != "")
            {
                lab_Card_Preview_Attribute2_Value.Text = cardDeck[onCard][4];
            }
            else
            {
                lab_Card_Preview_Attribute2_Value.Text = "Value";
            }

            txtBox_Attribute3_Name.Text = cardDeck[onCard][5];
            if (cardDeck[onCard][5] != "")
            {
                lab_Card_Preview_Attribute3_Name.Text = cardDeck[onCard][5];
            }
            else
            {
                lab_Card_Preview_Attribute3_Name.Text = "Attribute 3:";
            }

            txtBox_Attribute3_Value.Text = cardDeck[onCard][6];
            if (cardDeck[onCard][6] != "")
            {
                lab_Card_Preview_Attribute3_Value.Text = cardDeck[onCard][6];
            }
            else
            {
                lab_Card_Preview_Attribute3_Value.Text = "Value";
            }

            txtBox_Attribute4_Name.Text = cardDeck[onCard][7];
            if (cardDeck[onCard][7] != "")
            {
                lab_Card_Preview_Attribute4_Name.Text = cardDeck[onCard][7];
            }
            else
            {
                lab_Card_Preview_Attribute4_Name.Text = "Attribute 4:";
            }

            txtBox_Attribute4_Value.Text = cardDeck[onCard][8];
            if (cardDeck[onCard][8] != "")
            {
                lab_Card_Preview_Attribute4_Value.Text = cardDeck[onCard][8];
            }
            else
            {
                lab_Card_Preview_Attribute4_Value.Text = "Value";
            }

            txtBox_Attribute5_Name.Text = cardDeck[onCard][9];
            if (cardDeck[onCard][9] != "")
            {
                lab_Card_Preview_Attribute5_Name.Text = cardDeck[onCard][9];
            }
            else
            {
                lab_Card_Preview_Attribute5_Name.Text = "Attribute 5:";
            }

            txtBox_Attribute5_Value.Text = cardDeck[onCard][10];
            if (cardDeck[onCard][10] != "")
            {
                lab_Card_Preview_Attribute5_Value.Text = cardDeck[onCard][10];
            }
            else
            {
                lab_Card_Preview_Attribute5_Value.Text = "Value";
            }

            lab_Card_Number.Text = "Card " + Convert.ToString(onCard + 1);
        }
    }
}
