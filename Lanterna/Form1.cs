using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanterna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            timer.Start();
            Lanterna lanterna = new Lanterna();

            ptBDesligada.Visible = false;
            lblStatusDesc.Text = "Ligada";
            ptBLigada.Visible = true;
         
         
             ptBLigada.Visible = true;
         

          
            if (progBarBateria.Value < 100)
            {
                progBarBateria.Value += 1;
                lblDuracao.Text = progBarBateria.Value.ToString() + "%";
            }
           
        }

       
    private void timer_Tick(object sender, EventArgs e)
        {
            Lanterna lanterna = new Lanterna();

            //  Ligar();
            // Desligar();


            Bateria bateria = new Bateria();

            // Trocar()

            #region testes
            //progBarBateria.Style = ProgressBarStyle.Blocks;
            //progBarBateria.RightToLeftLayout = true;
            //progBarBateria.RightToLeft = RightToLeft.Yes;

            //// for (int i = 100; i <= progBarBateria.Value; i++)
            //{
            //    if (progBarBateria.Value == 100)
            //    {
            //        progBarBateria.Value -= 1;

            //        lblDuracao.Text = progBarBateria.Value.ToString() + "%";
            //    }
            //    else
            //    {
            //        timer.Stop();

            //        MessageBox.Show("Trocar Bateria!");

            //    }
            //}


            //progBarBateria.Style = ProgressBarStyle.Blocks;
            //progBarBateria.RightToLeftLayout = true;
            //progBarBateria.RightToLeft = RightToLeft.Yes;

            //progBarBateria.Value = 100;

            //if (progBarBateria.Value == 100)
            //{
            //    progBarBateria.Value -= 3;
            //    lblDuracao.Text = progBarBateria.Value.ToString() + "%";
            //}
            //else
            //{
            //    timer.Stop();

            //    MessageBox.Show("Trocar Bateria!");

            //}
            #endregion

            if (progBarBateria.Value < 100)
            {
                progBarBateria.Value += 1;
                lblDuracao.Text = progBarBateria.Value.ToString() + "%";
            }

        
        }


        private void btnTrocarB_Click(object sender, EventArgs e)
        {
            timer.Start();
            ptBDesligada.Visible = true;
            lblStatusDesc.Text = "Descarregada";
            ptBLigada.Visible = false;

            progBarBateria.Style = ProgressBarStyle.Blocks;
            progBarBateria.RightToLeftLayout = true;
            progBarBateria.RightToLeft = RightToLeft.Yes;

            // for (int i = 100; i <= progBarBateria.Value; i++)
            {
                if (progBarBateria.Value == 100)
                {
                    progBarBateria.Value -= 1;

                    lblDuracao.Text = progBarBateria.Value.ToString() + "%";
                }
                else
                {
                   MessageBox.Show("Trocar Bateria!");

                }
                timer.Stop();

            }
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {

            ptBLigada.Visible = false;
            ptBDesligada.Visible = true;
            lblStatusDesc.Text = "Desligada";

            //if (progBarBateria.Value <= 0)
            //{

            //    lblDuracao.Text = progBarBateria.Value.ToString() + "%";
            //}
            timer.Stop();

        }
    }     
}

