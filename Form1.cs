using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Chooseitemquantity();
        }


        string snackname = "";
        Double Price;
        



        private void Button1_Click(object sender, EventArgs e)

        {
            listBox1.Items.Clear();
            List<string> snackslist;
            snackslist = new List<string>();
            snackslist.Add("Fries");
            snackslist.Add("Hamburger");
            snackslist.Add("Cocacola");
            snackslist.Add("Frikandel");
            snackslist.Add("Loempia");
            snackslist.Add("Fries");
            snackslist.Add("Icecream");
            foreach (string snack in snackslist)
            {
            
                listBox1.Items.Add(snack);
            }
        }


        public void Calculate_SnackPrice()
        {
            string itemquantity = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            listBox1.Items.Add(itemquantity);
            int quantity = Convert.ToInt32(itemquantity);



            Double totalPrices = Price * quantity;


        }

        public void Additems()
        {
          
            if (radioButton1.Checked)
            {
                snackname = radioButton1.Text;
                 Price = 2.75;
            }

            if (radioButton2.Checked)
            {
                snackname = radioButton2.Text;
                 Price = 4.65;
            }
            if (radioButton3.Checked)
            {
                snackname = radioButton3.Text;
                 Price = 2.50;
            }
            if (radioButton4.Checked)
            {
                snackname = radioButton4.Text;
                 Price = 3.00;

            }

            if (radioButton5.Checked)
            {
                snackname = radioButton5.Text;
                 Price = 3.00;
            }
            if (radioButton6.Checked)
            {
                snackname = radioButton6.Text;
                Price = 2.50;
            }
            string itemquantity = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            int addquantity = Convert.ToInt32(itemquantity);
            listBox1.Items.Add(snackname + " " + Price + " " + "x" + " " + addquantity);



        }

       
        private void Button2_Click(object sender, EventArgs e)
        {

           
            Additems();

        }

        public void Chooseitemquantity()
        {
            List<int> Quantity;
            Quantity = new List<int>();

          

            for (int i = 1; i <= 50; i++)
            {
                Quantity.Add(i);

            }

          comboBox1.DataSource = Quantity;
           

        }

        public void Removeitems()
        {

            if (radioButton1.Checked)
            {
                snackname = radioButton1.Text;
                Price = 2.75;
            }

            if (radioButton2.Checked)
            {
                snackname = radioButton2.Text;
                Price = 4.65;
            }
            if (radioButton3.Checked)
            {
                snackname = radioButton3.Text;
                Price = 2.50;
            }
            if (radioButton4.Checked)
            {
                snackname = radioButton4.Text;
                Price = 3.00;

            }

            if (radioButton5.Checked)
            {
                snackname = radioButton5.Text;
                Price = 3.00;
            }
            if (radioButton6.Checked)
            {
                snackname = radioButton6.Text;
                Price = 2.50;
            }

            string itemquantity = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            int removequantity = Convert.ToInt32(itemquantity);
            listBox1.Items.Remove(snackname + " " + Price + " " + "x" + " " + removequantity);

        }







        private void Button3_Click(object sender, EventArgs e)
        {
            Removeitems();




        }



        }

       

        
    }

    




