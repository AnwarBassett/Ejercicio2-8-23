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
using static System.Net.WebRequestMethods;
using Microsoft.Office.Interop.Excel;
using objExcel= Microsoft.Office.Interop.Excel;

namespace balance_General
{
    public partial class Form1 : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        metodos p = new metodos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tabla.AllowUserToAddRows = false;
        }
        int strFila = 0;
        public void ciclo()
        {
            txtCuentasActivo.Text = "";
            txtValorActivo.Text = "";
            txtCuentaPasivo.Text = "";
            txtValorPasivo.Text = "";
            txtCuentasActivo.Focus();

            double Total2 = 0;
            double ttP = 0; 
            double Total1 = 0;
            double Total = 0;
            foreach (DataGridViewRow row in Tabla.Rows)
            {
                Total2 += Convert.ToDouble(row.Cells["Valores_Activos"].Value);
                strFila = Convert.ToInt32(row.Index.ToString());
                int valor = Convert.ToInt32(row.Cells["Valores_Activos"].Value);
                if (valor < 0)
                {

                    Tabla.Rows[strFila].DefaultCellStyle.BackColor = Color.Green;
                }
            }
            foreach (DataGridViewRow row in Tabla.Rows)
            {
                ttP += Convert.ToDouble(row.Cells["Valores_Pasivos"].Value);
            }

            Total = Total + Total2;
            txtTotalActivo.Text = Total.ToString();


            Total1 = Total1 + ttP;
            txtTotalPasivo.Text = Total1.ToString();

            double Total21 = 0;
            Total21 = ttP - Total;
            txtTotal.Text = Total21.ToString();

            if (Total1 == Total)
            {
                LbMensaje.Text = "Las cuentas son correctas";
                btnGuardar.Enabled = true;
            }
            else
            {
                LbMensaje.Text = "Las cuentas son incorrectas, hay monto sobrante o faltante" +
                    " revise las cuentas antes de guardar";
                btnGuardar.Enabled = false;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            int f;
            f = Tabla.RowCount;
            for (int i = f - 1; i >= 0; i--)
            {
                Tabla.Rows.RemoveAt(i);
            }
            limpiar();
            //btnAgregar.Enabled = Enabled;
            txtTotalActivo.Text = "0";
            txtTotalPasivo.Text = "0";
            txtTotal.Text = "0";
            txtCuentasActivo.Focus();
        }

        public void limpiar()
        {
            txtCuentasActivo.Text = string.Empty;
            txtValorActivo.Text="0";
            txtCuentaPasivo.Text = string.Empty;
            txtValorPasivo.Text ="0";
            chDepreciacion.Checked = false;
            txtCuentasActivo.Focus();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string cuentasPA, valoresAC = "";
                string cuentasAC, valoresPA = "";
                double valAC=0, valPA=0;
                cuentasAC = txtCuentasActivo.Text;
                valAC = double.Parse(txtValorActivo.Text);
                cuentasPA = txtCuentaPasivo.Text;
                valPA = double.Parse(txtValorPasivo.Text);


                if (valAC < 0||valPA < 0)
                {
                    MessageBox.Show("No puede ingresar ese tipo de valores");
                }
                else
                {
                    if (chDepreciacion.Checked == true)
                    {
                        valAC = valAC * (-1);
                        valoresAC = String.Format("{0}", valAC);
                        valoresPA = String.Format("{0}", valPA);
                    }
                    else
                    {
                        valoresAC = String.Format("{0}", valAC);
                        valoresPA = String.Format("{0}", valPA);
                    }
                    //cuentas = String.Format("{0}", cuen);
                }

                string[] fila = new string[4];
                fila[0] = cuentasAC;
                fila[1] = valoresAC;
                fila[2] = cuentasPA;
                fila[3] = valoresPA;
                Tabla.Rows.Add(fila);
                
                ciclo();
                limpiar();
            }
            catch
            {
               MessageBox.Show("los caracter no son validos");
            }



        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //using static System.Net.WebRequestMethods;
            //using Microsoft.Office.Interop.Excel;
            //using objExcel= Microsoft.Office.Interop.Excel;
            objExcel.Application objAplicacion = new objExcel.Application();
            Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

            objAplicacion.Visible = false;

            foreach (DataGridViewColumn columna in Tabla.Columns)
            {
                objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in Tabla.Rows)
                {
                    objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }

            objHoja.Cells[1, 6] = "resultado activo";
            objHoja.Cells[1, 7] = txtTotalActivo.Text;
            objHoja.Cells[1, 8] = "resultado Pasivo+Capital";
            objHoja.Cells[1, 9] = txtTotalPasivo.Text;
            objLibro.SaveAs(ruta + "\\tabla.xlsx");
            objLibro.Close();
            MessageBox.Show("Archivo guardado, Revise la ventana");

            //objAplicacion.Quit();

            int f;
            f = Tabla.RowCount;
            for (int i = f - 1; i >= 0; i--)
            {
                Tabla.Rows.RemoveAt(i);
            }

            //btnAgregar.Enabled = Enabled;
            txtTotalActivo.Text = "0";
            txtTotalPasivo.Text = "0";
            txtTotal.Text = "0";
            txtCuentasActivo.Focus();
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
