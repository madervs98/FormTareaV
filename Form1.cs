using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTareaV
{
    public partial class Form1 : Form
    {

        String Tipo = "";

    
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_agregar_Click(object sender, EventArgs e)
        {

            //Validacion de campo vacio.
            if(string.IsNullOrEmpty(txt_cuenta.Text)){
                MessageBox.Show("Por favor no dejar campo 'Cuenta' vacio. ");
                txt_cuenta.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_nombrec.Text))
            {
                MessageBox.Show("Por favor no dejar campo 'Nombre Cuenta' vacio. ");
                txt_nombrec.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Tipo))
            {
                MessageBox.Show("Por favor no dejar campo 'Tipo' vacio. ");
                cmb_tipo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_monto.Text))
            {
                MessageBox.Show("Por favor no dejar campo 'Monto' vacio. ");
                txt_monto.Focus();
                return;
            }

            //Seleccionar Tipo 
            int total;
            if (cmb_tipo.Text == "Débito")
            {
                total = int.Parse(txt_monto.Text) + int.Parse(txt_tdebito.Text);
                dgv_Detalles.Rows.Add(txt_cuenta.Text, txt_nombrec.Text, txt_monto.Text, "");
                txt_tdebito.Text = total.ToString();
            }
            else if(cmb_tipo.Text == "Crédito")
            {
                total = int.Parse(txt_monto.Text) + int.Parse(txt_tcredito.Text);
                dgv_Detalles.Rows.Add(txt_cuenta.Text, txt_nombrec.Text,"", txt_monto.Text);
                txt_tcredito.Text = total.ToString();
            }

            //Limpiar campos 
            txt_cuenta.Clear();
            txt_nombrec.Clear();
            Tipo = cmb_tipo.Text = "";
            txt_monto.Clear();
            txt_cuenta.Focus();

        }

        //Seleccion de Tipo
        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipo = cmb_tipo.Text;
        }

        //Almacenar datos con Tecla Enter
        private void txt_monto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                //Valida que no deje ningun campo vacio.
                if (string.IsNullOrEmpty(txt_cuenta.Text))
                {
                    MessageBox.Show("Por favor no dejar campo 'Cuenta' vacio. ");
                    txt_cuenta.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_nombrec.Text))
                {
                    MessageBox.Show("Por favor no dejar campo 'Nombre Cuenta' vacio. ");
                    txt_nombrec.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cmb_tipo.Text))
                {
                    MessageBox.Show("Por favor no dejar campo 'Tipo' vacio. ");
                    cmb_tipo.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_monto.Text))
                {
                    MessageBox.Show("Por favor no dejar campo 'Monto' vacio. ");
                    txt_monto.Focus();
                    return;
                }
                //Agrega los datos
                int total;
                if (cmb_tipo.Text == "Débito")
                {
                    total = int.Parse(txt_monto.Text) + int.Parse(txt_tdebito.Text);
                    dgv_Detalles.Rows.Add(txt_cuenta.Text, txt_nombrec.Text, txt_monto.Text, "");
                    txt_tdebito.Text = total.ToString();
                }
                else if (cmb_tipo.Text == "Crédito")
                {
                    total = int.Parse(txt_monto.Text) + int.Parse(txt_tcredito.Text);
                    dgv_Detalles.Rows.Add(txt_cuenta.Text, txt_nombrec.Text, "", txt_monto.Text);
                    txt_tcredito.Text = total.ToString();
                }
                //Borrar cada campo luego de guardar
                txt_cuenta.Clear();
                txt_nombrec.Clear();
                Tipo = cmb_tipo.Text = "";
                txt_monto.Clear();
                txt_cuenta.Focus();
            }
        }

        //Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int result = 0;
            if(dgv_Detalles.CurrentRow.Index != -1)
            {
                if (dgv_Detalles.CurrentRow.Cells[2].Value.ToString().Trim() != "") 
                {
                    result = int.Parse(txt_tdebito.Text.ToString()) - int.Parse(dgv_Detalles.CurrentRow.Cells[2].Value.ToString());
                    txt_tdebito.Text = result.ToString(); 
                }
                else if (dgv_Detalles.CurrentRow.Cells[3].Value.ToString().Trim() == "")
                {
                    result = int.Parse(txt_tcredito.Text.ToString()) - int.Parse(dgv_Detalles.CurrentRow.Cells[3].Value.ToString());
                    txt_tcredito.Text = result.ToString();
                }
            }

                dgv_Detalles.Rows.RemoveAt(dgv_Detalles.CurrentRow.Index);
            }

        }
    }

