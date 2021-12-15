using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_doz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strUser = "O", strPc = "X";
        string selectLabel = "";
        int countWinUser = 0, countWinPc = 0 , countEqual=0;
        private void label1_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            selectLabel = selectLabel + "," + label.Name.Replace("label", "");

            label.Text = "O";
            label.BackColor = Color.Cyan;
            label.Enabled = false;

            checkWiner ();
            computerSelect ();
            checkWiner ();

            // MessageBox.Show(label.Name);
        }

        private void checkWiner()
        {
            //برنده شدن شما
            if ((label1.Text == strUser) && (label2.Text == strUser) && (label3.Text == strUser)) { MessageBox.Show("شما برنده شدید"); countWinUser++; result(); reset(); }
            else if ((label4.Text == strUser) && (label5.Text == strUser) && (label6.Text == strUser)) { MessageBox.Show("شما برنده شدید"); countWinUser++; result(); reset(); }
            else if ((label7.Text == strUser) && (label8.Text == strUser) && (label9.Text == strUser)) { MessageBox.Show("شما برنده شدید"); countWinUser++; result(); reset(); }
            else if ((label1.Text == strUser) && (label4.Text == strUser) && (label7.Text == strUser)) { MessageBox.Show("شما برنده شدید"); countWinUser++; result(); reset(); }
            else if ((label2.Text == strUser) && (label5.Text == strUser) && (label8.Text == strUser)) { MessageBox.Show("شما برنده شدید"); countWinUser++; result(); reset(); }
            else if ((label3.Text == strUser) && (label6.Text == strUser) && (label9.Text == strUser)) { MessageBox.Show("شما برنده شدید"); countWinUser++; result(); reset(); }
            else if ((label1.Text == strUser) && (label5.Text == strUser) && (label9.Text == strUser)) { MessageBox.Show("شما برنده شدید"); countWinUser++; result(); reset(); }
            else if ((label3.Text == strUser) && (label5.Text == strUser) && (label7.Text == strUser)) { MessageBox.Show("شما برنده شدید"); countWinUser++; result(); reset(); }
            //برنده شدن رایانه
            else if ((label1.Text == strPc) && (label2.Text == strPc) && (label3.Text == strPc)) { MessageBox.Show("رایانه برنده شد"); countWinPc++; result(); reset(); }
            else if ((label4.Text == strPc) && (label5.Text == strPc) && (label6.Text == strPc)) { MessageBox.Show("رایانه برنده شد"); countWinPc++; result(); reset(); }
            else if ((label7.Text == strPc) && (label8.Text == strPc) && (label9.Text == strPc)) { MessageBox.Show("رایانه برنده شد"); countWinPc++; result(); reset(); }
            else if ((label1.Text == strPc) && (label4.Text == strPc) && (label7.Text == strPc)) { MessageBox.Show("رایانه برنده شد"); countWinPc++; result(); reset(); }
            else if ((label2.Text == strPc) && (label5.Text == strPc) && (label8.Text == strPc)) { MessageBox.Show("رایانه برنده شد"); countWinPc++; result(); reset(); }
            else if ((label3.Text == strPc) && (label6.Text == strPc) && (label9.Text == strPc)) { MessageBox.Show("رایانه برنده شد"); countWinPc++; result(); reset(); }
            else if ((label1.Text == strPc) && (label5.Text == strPc) && (label9.Text == strPc)) { MessageBox.Show("رایانه برنده شد"); countWinPc++; result(); reset(); }
            else if ((label3.Text == strPc) && (label5.Text == strPc) && (label7.Text == strPc)) { MessageBox.Show("رایانه برنده شد"); countWinPc++; result(); reset(); }
            // مساوی شدن
            else if (label1.Enabled == false && label2.Enabled == false && label3.Enabled == false && label4.Enabled == false && label5.Enabled == false && label6.Enabled == false && label7.Enabled == false && label8.Enabled == false && label9.Enabled == false)
            {
                MessageBox.Show("هیچ کس برنده نشد");
                countEqual++;
                result();
                reset();
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            selectLabel = "";
            for (int i = 1; i <= 9; i++)
            {
                Controls.Find("label" + i.ToString(), false)[0].BackColor = Color.DarkGray;
                Controls.Find("label" + i.ToString().ToString(), false)[0].Text = "";
                Controls.Find("label" + i.ToString().ToString(), false)[0].Enabled = true;
            }
        }

        private void result()
        {
            lblWinPc.Text = countWinPc.ToString();
            lblWinUser.Text = countWinUser.ToString();
            lblEqual.Text = countEqual.ToString();
        }

        private void computerSelect()
        {
            
                //حمله
                //بررسی مقادیر افقی
                if ((label1.Text == strPc) && (label2.Text == strPc) && label3.Enabled) { label3.Text = strPc; label3.Enabled = false; label3.BackColor = Color.Magenta; selectLabel += ",3"; }
                else if ((label2.Text == strPc) && (label3.Text == strPc) && label1.Enabled) { label1.Text = strPc; label1.Enabled = false; label1.BackColor = Color.Magenta; selectLabel += ",1"; }
                else if ((label1.Text == strPc) && (label3.Text == strPc) && label2.Enabled) { label2.Text = strPc; label2.Enabled = false; label2.BackColor = Color.Magenta; selectLabel += ",2"; }
                else if ((label4.Text == strPc) && (label5.Text == strPc) && label6.Enabled) { label6.Text = strPc; label6.Enabled = false; label6.BackColor = Color.Magenta; selectLabel += ",6"; }
                else if ((label5.Text == strPc) && (label6.Text == strPc) && label4.Enabled) { label4.Text = strPc; label4.Enabled = false; label4.BackColor = Color.Magenta; selectLabel += ",4"; }
                else if ((label4.Text == strPc) && (label6.Text == strPc) && label5.Enabled) { label5.Text = strPc; label5.Enabled = false; label5.BackColor = Color.Magenta; selectLabel += ",5"; }
                else if ((label7.Text == strPc) && (label8.Text == strPc) && label9.Enabled) { label9.Text = strPc; label9.Enabled = false; label9.BackColor = Color.Magenta; selectLabel += ",9"; }
                else if ((label8.Text == strPc) && (label9.Text == strPc) && label7.Enabled) { label7.Text = strPc; label7.Enabled = false; label7.BackColor = Color.Magenta; selectLabel += ",7"; }
                else if ((label7.Text == strPc) && (label9.Text == strPc) && label8.Enabled) { label8.Text = strPc; label8.Enabled = false; label8.BackColor = Color.Magenta; selectLabel += ",8"; }
                //بررسی مقادیر عمودی                                          
                else if ((label1.Text == strPc) && (label4.Text == strPc) && label7.Enabled) { label7.Text = strPc; label7.Enabled = false; label7.BackColor = Color.Magenta; selectLabel += ",7"; }
                else if ((label4.Text == strPc) && (label7.Text == strPc) && label1.Enabled) { label1.Text = strPc; label1.Enabled = false; label1.BackColor = Color.Magenta; selectLabel += ",1"; }
                else if ((label1.Text == strPc) && (label7.Text == strPc) && label4.Enabled) { label4.Text = strPc; label4.Enabled = false; label4.BackColor = Color.Magenta; selectLabel += ",4"; }
                else if ((label2.Text == strPc) && (label5.Text == strPc) && label8.Enabled) { label8.Text = strPc; label8.Enabled = false; label8.BackColor = Color.Magenta; selectLabel += ",8"; }
                else if ((label5.Text == strPc) && (label8.Text == strPc) && label2.Enabled) { label2.Text = strPc; label2.Enabled = false; label2.BackColor = Color.Magenta; selectLabel += ",2"; }
                else if ((label2.Text == strPc) && (label8.Text == strPc) && label5.Enabled) { label5.Text = strPc; label5.Enabled = false; label5.BackColor = Color.Magenta; selectLabel += ",5"; }
                else if ((label3.Text == strPc) && (label6.Text == strPc) && label9.Enabled) { label9.Text = strPc; label9.Enabled = false; label9.BackColor = Color.Magenta; selectLabel += ",9"; }
                else if ((label6.Text == strPc) && (label9.Text == strPc) && label3.Enabled) { label3.Text = strPc; label3.Enabled = false; label3.BackColor = Color.Magenta; selectLabel += ",3"; }
                else if ((label3.Text == strPc) && (label9.Text == strPc) && label6.Enabled) { label6.Text = strPc; label6.Enabled = false; label6.BackColor = Color.Magenta; selectLabel += ",6"; }
                //بررسی مقادیر قطری                                         
                else if ((label1.Text == strPc) && (label5.Text == strPc) && label9.Enabled) { label9.Text = strPc; label9.Enabled = false; label9.BackColor = Color.Magenta; selectLabel += ",9"; }
                else if ((label5.Text == strPc) && (label9.Text == strPc) && label1.Enabled) { label1.Text = strPc; label1.Enabled = false; label1.BackColor = Color.Magenta; selectLabel += ",1"; }
                else if ((label1.Text == strPc) && (label9.Text == strPc) && label5.Enabled) { label5.Text = strPc; label5.Enabled = false; label5.BackColor = Color.Magenta; selectLabel += ",5"; }
                else if ((label3.Text == strPc) && (label5.Text == strPc) && label7.Enabled) { label7.Text = strPc; label7.Enabled = false; label7.BackColor = Color.Magenta; selectLabel += ",7"; }
                else if ((label5.Text == strPc) && (label7.Text == strPc) && label3.Enabled) { label3.Text = strPc; label3.Enabled = false; label3.BackColor = Color.Magenta; selectLabel += ",3"; }
                else if ((label3.Text == strPc) && (label7.Text == strPc) && label5.Enabled) { label5.Text = strPc; label5.Enabled = false; label5.BackColor = Color.Magenta; selectLabel += ",5"; }

                //دفاع
                //بررسی مقادیر افقی
                else if ((label1.Text == strUser) && (label2.Text == strUser) && label3.Enabled) { label3.Text = strPc; label3.Enabled = false; label3.BackColor = Color.Magenta; selectLabel += ",3"; }
                else if ((label2.Text == strUser) && (label3.Text == strUser) && label1.Enabled) { label1.Text = strPc; label1.Enabled = false; label1.BackColor = Color.Magenta; selectLabel += ",1"; }
                else if ((label1.Text == strUser) && (label3.Text == strUser) && label2.Enabled) { label2.Text = strPc; label2.Enabled = false; label2.BackColor = Color.Magenta; selectLabel += ",2"; }
                else if ((label4.Text == strUser) && (label5.Text == strUser) && label6.Enabled) { label6.Text = strPc; label6.Enabled = false; label6.BackColor = Color.Magenta; selectLabel += ",6"; }
                else if ((label5.Text == strUser) && (label6.Text == strUser) && label4.Enabled) { label4.Text = strPc; label4.Enabled = false; label4.BackColor = Color.Magenta; selectLabel += ",4"; }
                else if ((label4.Text == strUser) && (label6.Text == strUser) && label5.Enabled) { label5.Text = strPc; label5.Enabled = false; label5.BackColor = Color.Magenta; selectLabel += ",5"; }
                else if ((label7.Text == strUser) && (label8.Text == strUser) && label9.Enabled) { label9.Text = strPc; label9.Enabled = false; label9.BackColor = Color.Magenta; selectLabel += ",9"; }
                else if ((label8.Text == strUser) && (label9.Text == strUser) && label7.Enabled) { label7.Text = strPc; label7.Enabled = false; label7.BackColor = Color.Magenta; selectLabel += ",7"; }
                else if ((label7.Text == strUser) && (label9.Text == strUser) && label8.Enabled) { label8.Text = strPc; label8.Enabled = false; label8.BackColor = Color.Magenta; selectLabel += ",8"; }
                //بررسی مقادیر عمودی                                               
                else if ((label1.Text == strUser) && (label4.Text == strUser) && label7.Enabled) { label7.Text = strPc; label7.Enabled = false; label7.BackColor = Color.Magenta; selectLabel += ",7"; }
                else if ((label4.Text == strUser) && (label7.Text == strUser) && label1.Enabled) { label1.Text = strPc; label1.Enabled = false; label1.BackColor = Color.Magenta; selectLabel += ",1"; }
                else if ((label1.Text == strUser) && (label7.Text == strUser) && label4.Enabled) { label4.Text = strPc; label4.Enabled = false; label4.BackColor = Color.Magenta; selectLabel += ",4"; }
                else if ((label2.Text == strUser) && (label5.Text == strUser) && label8.Enabled) { label8.Text = strPc; label8.Enabled = false; label8.BackColor = Color.Magenta; selectLabel += ",8"; }
                else if ((label5.Text == strUser) && (label8.Text == strUser) && label2.Enabled) { label2.Text = strPc; label2.Enabled = false; label2.BackColor = Color.Magenta; selectLabel += ",2"; }
                else if ((label2.Text == strUser) && (label8.Text == strUser) && label5.Enabled) { label5.Text = strPc; label5.Enabled = false; label5.BackColor = Color.Magenta; selectLabel += ",5"; }
                else if ((label3.Text == strUser) && (label6.Text == strUser) && label9.Enabled) { label9.Text = strPc; label9.Enabled = false; label9.BackColor = Color.Magenta; selectLabel += ",9"; }
                else if ((label6.Text == strUser) && (label9.Text == strUser) && label3.Enabled) { label3.Text = strPc; label3.Enabled = false; label3.BackColor = Color.Magenta; selectLabel += ",3"; }
                else if ((label3.Text == strUser) && (label9.Text == strUser) && label6.Enabled) { label6.Text = strPc; label6.Enabled = false; label6.BackColor = Color.Magenta; selectLabel += ",6"; }
                //بررسی مقادیر قطری                                             
                else if ((label1.Text == strUser) && (label5.Text == strUser) && label9.Enabled) { label9.Text = strPc; label9.Enabled = false; label9.BackColor = Color.Magenta; selectLabel += ",9"; }
                else if ((label5.Text == strUser) && (label9.Text == strUser) && label1.Enabled) { label1.Text = strPc; label1.Enabled = false; label1.BackColor = Color.Magenta; selectLabel += ",1"; }
                else if ((label1.Text == strUser) && (label9.Text == strUser) && label5.Enabled) { label5.Text = strPc; label5.Enabled = false; label5.BackColor = Color.Magenta; selectLabel += ",5"; }
                else if ((label3.Text == strUser) && (label5.Text == strUser) && label7.Enabled) { label7.Text = strPc; label7.Enabled = false; label7.BackColor = Color.Magenta; selectLabel += ",7"; }
                else if ((label5.Text == strUser) && (label7.Text == strUser) && label3.Enabled) { label3.Text = strPc; label3.Enabled = false; label3.BackColor = Color.Magenta; selectLabel += ",3"; }
                else if ((label3.Text == strUser) && (label7.Text == strUser) && label5.Enabled) { label5.Text = strPc; label5.Enabled = false; label5.BackColor = Color.Magenta; selectLabel += ",5"; }

                //انتخاب تصادفی
                else
                {
                    Random random = new Random();
                    int randomNumber = 0;
                startRand:
                    randomNumber = random.Next(1, 10);
                    if (selectLabel.IndexOf(randomNumber.ToString()) >= 0)
                        goto startRand;
                    else
                    {
                        selectLabel += "," + randomNumber.ToString();
                        Controls.Find("label" + randomNumber.ToString(), false)[0].BackColor = Color.Magenta;
                        Controls.Find("label" + randomNumber.ToString(), false)[0].Text = strPc;
                        Controls.Find("label" + randomNumber.ToString(), false)[0].Enabled = false;

                    }
                }
            }
        }
    }

