using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (id_list.SelectedItem == null)
            {
                btn_ann.Enabled = false;
                btn_eng.Enabled = false;
                btn_mod.Enabled = false;
                btn_supp.Enabled = false;
                id_list.Enabled = false;
                txtbox_prnm.Enabled = false;
                txtbox_met.Enabled = false;
                txtbox_nom.Enabled = false;
           
            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
       
            btn_ann.Enabled = true;
            btn_eng.Enabled = true;
            btn_mod.Enabled = false;
            btn_supp.Enabled = false;
            id_list.Enabled = false;
            btn_ajout.Enabled = false;
            txtbox_prnm.Enabled = true;
            txtbox_met.Enabled = true;
            txtbox_nom.Enabled = true;
            ajout = true;
            message.Text = "";
        }
        
        private void btn_mod_Click(object sender, EventArgs e)
        {

            if (id_list.SelectedItem == null)
                message.Text = "Veiller selectionner";
            else
            {
                btn_ann.Enabled = true;
                btn_eng.Enabled = true;
                btn_mod.Enabled = false;
                btn_supp.Enabled = false;
                id_list.Enabled = false;
                txtbox_prnm.Enabled = true;
                txtbox_met.Enabled = true;
                txtbox_nom.Enabled = true;
                btn_ajout.Enabled = false;

                mod = true;
            }
        }
       
        private void btn_supp_Click(object sender, EventArgs e)
        {
            if (id_list.SelectedItem == null)
                message.Text = "Veiller selectionner";
            else
            {
                btn_ann.Enabled = true;
                btn_eng.Enabled = true;
                btn_mod.Enabled = false;
                btn_supp.Enabled = false;
                id_list.Enabled = false;
                txtbox_prnm.Enabled = false;
                txtbox_met.Enabled = false;
                txtbox_nom.Enabled = false;
                btn_ajout.Enabled = false;

                supp = true;
            }
        }
        
        private void btn_ann_Click(object sender, EventArgs e)
        {
          

            btn_ajout.Enabled = true;
     
            if (id_list.Items.Count == 0)
            {
                btn_ann.Enabled = false;
                btn_eng.Enabled = false;
                btn_mod.Enabled = false;
                btn_supp.Enabled = false;
                id_list.Enabled = false;
                txtbox_prnm.Enabled = false;
                txtbox_met.Enabled = false;
                txtbox_nom.Enabled = false;

            }
            else
            {
                btn_ann.Enabled = false;
                btn_eng.Enabled = false;
                btn_mod.Enabled = true;
                btn_supp.Enabled = true;
                id_list.Enabled = true;
                btn_ajout.Enabled = true;
                txtbox_prnm.Enabled = false;
                txtbox_met.Enabled = false;
                txtbox_nom.Enabled = false;
            }
            txtbox_nom.Text = "";
            txtbox_met.Text = "";
            txtbox_prnm.Text = "";
            message.Text = "";
            id_list.Text = "Select";
            ////////
   
        }

        private void btn_eng_Click(object sender, EventArgs e)
        {
            DataApp mydata = new DataApp();
           
            if (txtbox_prnm.Text != "" && txtbox_nom.Text != "" && txtbox_met.Text != "")

            {
                if (ajout)
                {    

                    
                    mydata.AjouteData( txtbox_prnm.Text,txtbox_nom.Text , txtbox_met.Text);

                    id_list.Items.Add(mydata.SelectID());
                    ajout = false;
                }

                if (mod)
                {

                    int i=int.Parse(id_list.SelectedItem.ToString());
                    mydata.ModifierData(txtbox_prnm.Text, txtbox_nom.Text, txtbox_met.Text, i);

                 
               

                    mod = false;
                }

                btn_ann.Enabled = false;
                btn_eng.Enabled = false;
                btn_mod.Enabled = true;
                btn_supp.Enabled = true;
                id_list.Enabled = true;
                txtbox_prnm.Enabled = false;
                txtbox_met.Enabled = false;
                txtbox_nom.Enabled = false;
                btn_ajout.Enabled = true;
            }
            else { message.Text = "Veiller saisir"; }
            if (supp)
            {


                int i = int.Parse(id_list.SelectedItem.ToString());
                mydata.SupprimerData(i);
                id_list.Items.Remove(id_list.SelectedItem);
               
             
                supp = false;

                btn_ann.Enabled = false;
                btn_eng.Enabled = false;
                btn_mod.Enabled = true;
                btn_supp.Enabled = true;
                id_list.Enabled = true;
                txtbox_prnm.Enabled = false;
                txtbox_met.Enabled = false;
                txtbox_nom.Enabled = false;
                btn_ajout.Enabled = true;

                if (id_list.Items.Count == 0)
                {

                    btn_ann.Enabled = false;
                    btn_eng.Enabled = false;
                    btn_mod.Enabled = false;
                    btn_supp.Enabled = false;
                    id_list.Enabled = false;
                    txtbox_prnm.Enabled = false;
                    txtbox_met.Enabled = false;
                    txtbox_nom.Enabled = false;
                    btn_ajout.Enabled = true;

                }



            }


            txtbox_nom.Text = "";
            txtbox_met.Text = "";
            txtbox_prnm.Text = "";
            
            id_list.Text = "Select";
        }
    }
}
