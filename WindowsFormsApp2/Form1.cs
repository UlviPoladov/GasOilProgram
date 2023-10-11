using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        private double benzinTotalam = 0;
        private double coffeeTotal = 0;
        private double snickersTotal = 0;
        private double redbullTotal = 0;
        private double spriteTotal = 0;
        private double fantaTotal = 0;
        private double fulltotalamount = 0;
        public Form1()
        {
            InitializeComponent();
            CheckRadioButtonStatus();
            fuelSelectBox.SelectedIndex = 0;
        }

        private void benzinSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = fuelSelectBox.SelectedIndex;

            
            switch (selectedIndex)
            {
                case 0:
                    oilpricelabel.Text = "0.80";
                    break;
                case 1:
                    oilpricelabel.Text = "1";
                    break;
                case 2:
                    oilpricelabel.Text = "2";
                    break;
                case 3:
                    oilpricelabel.Text = "2.50";
                    break;
                default:
                  
                    break;
            }
        }

        private void CheckRadioButtonStatus()
        {
            if (RadioButton1.Checked)
            {
                litrmaskedbox.Enabled = false; 
                pricemaskedbox.Enabled = true;  
            }
            else if (RadioButton2.Checked)
            {
                litrmaskedbox.Enabled = true;  
                pricemaskedbox.Enabled = false; 
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            litrmaskedbox.Clear();
            benzinTotalLb.Text = "0";
            CheckRadioButtonStatus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pricemaskedbox.Clear();
            benzinTotalLb.Text = "0";
            CheckRadioButtonStatus();
        }

        private void pricemaskedbox_TextChanged(object sender, EventArgs e)
        {
            benzinTotalLb.Text= pricemaskedbox.Text;
        }

        private void litrmaskedbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(oilpricelabel.Text) && double.TryParse(oilpricelabel.Text, out double oilPrice))
            {
                if (double.TryParse(litrmaskedbox.Text, out double liters))
                {
                    benzinTotalLb.Text = (liters * oilPrice).ToString();
                }
                else
                {
                    benzinTotalLb.Text = ""; 
                }
            }

        }

        private void CoffeUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (CoffeeBox.Checked)
            {
                if (double.TryParse(coffepricelbl.Text, out double coffeePrice))
                {
                    double quantity = (double)CoffeUpDown.Value;
                    coffeeTotal = coffeePrice * quantity;
                    UpdateTotalLabel();
                }
            }
        }

        private void snickersupdown_ValueChanged(object sender, EventArgs e)
        {
            if (snickersBox.Checked)
            {
                if (double.TryParse(snickerspricelbl.Text, out double snickersPrice))
                {
                    double quantity = (double)snickersupdown.Value;
                    snickersTotal = snickersPrice * quantity;
                    UpdateTotalLabel();
                }
            }
            
        }

        private void redbullupdown_ValueChanged(object sender, EventArgs e)
        {
            if (redbullBox.Checked)
            {
                if (double.TryParse(redbullpricelbl.Text, out double redbullPrice))
                {
                    double quantity = (double)redbullupdown.Value;
                    redbullTotal = redbullPrice * quantity;
                    UpdateTotalLabel();
                }
            }
        }

        private void spriteupdown_ValueChanged(object sender, EventArgs e)
        {
            if (spriteBox.Checked)
            {
                if (double.TryParse(spritepricelbl.Text, out double spritePrice))
                {
                    double quantity = (double)spriteupdown.Value;
                    spriteTotal = spritePrice * quantity;
                    UpdateTotalLabel();
                }
            }
        }

        private void fantaupdown_ValueChanged(object sender, EventArgs e)
        {
            if (fantaBox.Checked)
            {
                if (double.TryParse(fantapricelbl.Text, out double fantaPrice))
                {
                    double quantity = (double)fantaupdown.Value;
                    fantaTotal = fantaPrice * quantity;
                    UpdateTotalLabel();
                }
            }
        }

        private void UpdateTotalLabel()
        {
           fulltotalamount = coffeeTotal + snickersTotal + redbullTotal + spriteTotal + fantaTotal;
            label2.Text = fulltotalamount.ToString();
        }

        private void benzinTotalLb_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(benzinTotalLb.Text, out double benzinAmount))
            {
                benzinTotalam = benzinAmount;
                UpdateLabel3();
            }
        }
        private void label2_TextChanged(object sender, EventArgs e)
        {   
                UpdateLabel3();
            
        }
        private void UpdateLabel3()
        {
            double totalAmount = benzinTotalam + fulltotalamount;
            label3.Text = totalAmount.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buyBtr_Click(object sender, EventArgs e)
        {
            double howmuchlitr = benzinTotalam / double.Parse(oilpricelabel.Text);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfFilePath = Path.Combine(desktopPath, "bill.pdf");
            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                doc.Open();


                string billtxt = $@"
                -------------------------------------------
                |          CAFE BILL                       
                |  COFFE {CoffeUpDown.Value} piece          
                |  Snickers {snickersupdown.Value} piece   
                |  RedBull {redbullupdown.Value} piece     
                |  Sprite {spriteupdown.Value} piece       
                |  Fanta {fantaupdown.Value} piece         
                |                                          
                |           Oil BILL                       
                |  You Take {howmuchlitr} Litr  Oil        
                |                                          
                |   Total : {double.Parse(label3.Text)}    
                |   Your Rate : {guna2RatingStar1.Value}   
                --------------------------------------------
                    ";



                Paragraph paragraph = new Paragraph(billtxt);
                doc.Add(paragraph);

                doc.Close();
            }

            
            
        }
    }
}

