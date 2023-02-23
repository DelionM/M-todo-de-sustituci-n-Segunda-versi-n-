using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;

namespace Método_de_sustitución
{
    public partial class Form1 : MaterialForm
    {
        //string ecuacion1, ecuacion2;
        double x1, y1, r1, x2, y2, r2, y1Contraria, solX, solY, solEc1, solEc2;
        String varDes, ecu2sus, ecu2res, letra1, letra2;
        int poc;
        int m, mx, my;

        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (themeToggle.Checked)
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult seleccion = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (seleccion == DialogResult.Yes)
                Application.Exit();
             
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            txtEcuacion1.Clear();
            txtEcuacion2.Clear();
            txtX.Clear();
            txtY.Clear();

            txtX.Visible = true;
            txtY.Visible = true;
            lblSinResultados.Visible = false;

            lblPaso1_1.Visible = false;
            lblPaso1_2.Visible = false;

            lblPaso2.Visible = false;

            lblPaso3_1.Visible = false;
            lblPaso3_2.Visible = false;
            lblPaso3_3.Visible = false;
            lblPaso3_4.Visible = false;
            lblPaso3_5.Visible = false;
            lblPaso3_6.Visible = false;

            lblPaso4_1.Visible = false;
            lblPaso4_2.Visible = false;
            lblPaso4_3.Visible = false;

            lblPaso5_1.Visible = false;
            lblPaso5_2.Visible = false;
            lblPaso5_3.Visible = false;
            lblPaso5_4.Visible = false;
            lblPaso5_5.Visible = false;
            lblPaso5_6.Visible = false;

            txtX.Hint = "Resultado de V1";
            txtY.Hint = "Resultado de V2";

            txtEcuacion1.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDato.Columns.Add("ecu1", "Ecuación 1");
            dgvDato.Columns.Add("ecu2", "Ecuación 2");
            dgvDato.Columns.Add("resultadox", "Resultado V1");
            dgvDato.Columns.Add("resultadoy", "Resultado V2");
            txtEcuacion1.SelectAll();
        }

        private void dgvDato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                poc = dgvDato.CurrentRow.Index;
                if (dgvDato.SelectedRows.Count > 0)
                {
                    txtEcuacion1.Focus();
          
                    txtEcuacion1.Text = dgvDato[0, poc].Value.ToString();
                    txtEcuacion2.Text = dgvDato[1, poc].Value.ToString();
     
                }

                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
               
                }

            }
            catch
            {
                MessageBox.Show("Seleccione una fila valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEcuacion1.Focus();
            }
        }
        public void limpiar()
        {
            txtEcuacion1.Clear();
            txtEcuacion2.Clear();
            txtX.Clear();
            txtY.Clear();
        }

        private void txtEcuacion2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumero(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtEcuacion1.Text == String.Empty)
                    epEcuacion1.SetError(txtEcuacion1, "Este campo es obligatorio");
                if (txtEcuacion2.Text == String.Empty)
                    epEcuacion2.SetError(txtEcuacion2, "Este campo es obligatorio");

                btnCalcular.PerformClick();
            }
        }

        private void dgvDato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDato.SelectedRows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            else
            {
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void txtEcuacion2_TextChanged(object sender, EventArgs e)
        {
            if (txtEcuacion1.Text != String.Empty && txtEcuacion2.Text != String.Empty)
                btnCalcular.Enabled = true;
            else
                btnCalcular.Enabled = false;

            if (txtEcuacion1.Text != String.Empty)
                epEcuacion1.Clear();
            if (txtEcuacion2.Text != String.Empty)
                epEcuacion2.Clear();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            txtEcuacion1.Clear();
            txtEcuacion2.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult msj = MessageBox.Show("¿Deseas eliminar el registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msj == DialogResult.OK)
                {
                    if (dgvDato.SelectedRows.Count > 0)
                    {
                        limpiar();
                        dgvDato.Rows.Remove(dgvDato.CurrentRow);
                        btnEliminar.Enabled = false;
                     
                        MessageBox.Show("Eliminado Correctamente");

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila por favor");
                        btnEliminar.Enabled = false;
                    }
                }
                else
                {

                    txtEcuacion1.Focus();
                    btnEliminar.Enabled = false;
                   
                }


            }
            catch
            {
                MessageBox.Show("Seleccione una fila valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEliminar.Enabled = false;
            
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtEcuacion1.Text) || String.IsNullOrEmpty(txtEcuacion2.Text))
            {

                MessageBox.Show("Debe completar la información", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;

            }
            try {
                obtenerValoresEcuacion1(Regex.Replace(txtEcuacion1.Text, @"\s", "").ToLower());
                obtenerValoresEcuacion2(Regex.Replace(txtEcuacion1.Text, @"\s", "").ToLower());
                paso1();
                paso2();
                paso3();
                paso4();
                paso5();

                //error 1
                mostrarResultados();


                lblPaso1_1.Visible = true;
                lblPaso1_2.Visible = true;

                lblPaso2.Visible = true;

                lblPaso3_1.Visible = true;
                lblPaso3_2.Visible = true;
                lblPaso3_3.Visible = true;
                lblPaso3_4.Visible = true;
                lblPaso3_5.Visible = true;
                lblPaso3_6.Visible = true;

                lblPaso4_1.Visible = true;
                lblPaso4_2.Visible = true;
                lblPaso4_3.Visible = true;

                lblPaso5_1.Visible = true;
                lblPaso5_2.Visible = true;
                lblPaso5_3.Visible = true;
                lblPaso5_4.Visible = true;
                lblPaso5_5.Visible = true;
                lblPaso5_6.Visible = true;

                dgvDato.Rows.Add(txtEcuacion1.Text, txtEcuacion2.Text, txtX.Text, txtY.Text);
                txtEcuacion1.Focus();
                MessageBox.Show("Se ingresó correctamente su ecuación", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception)
            {
                DialogResult seleccion = MessageBox.Show("Ha ingresado al menos una ecuación no valida. Por favor ingrese las ecuaciones en la forma ax + by = c", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (seleccion == DialogResult.OK)
                {
                    txtEcuacion1.Focus();
                }
            }

        }

        private void obtenerValoresEcuacion1(String ecuacion1)
        {
            string valores = string.Empty;
            int var = 1;
            letra1 = String.Empty;
            letra2 = String.Empty;

            for (int i = 0; i < ecuacion1.Length; i++)
            {
                switch (ecuacion1[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'ñ':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                    case 'v':
                    case 'x':
                    case 'w':
                    case 'y':
                    case 'z':
                        if (valores == string.Empty || valores == "+")
                            valores = "1";
                        else if (valores == "-")
                            valores = "-1";

                        if (var == 1)
                        {
                            x1 = Double.Parse(valores);
                            var++;
                            letra1 = Convert.ToString(ecuacion1[i]);
                        }
                        else if (var == 2)
                        {
                            y1 = Double.Parse(valores);
                            var++;
                            letra2 = Convert.ToString(ecuacion1[i]);
                        }
                        valores = string.Empty;
                        break;
                    case '=':
                        valores = string.Empty;
                        break;
                    default:
                        valores += ecuacion1[i];
                        break;
                }
            }

            r1 = Double.Parse(valores);
            txtX.Hint = "Resultado de " + letra1;
            txtY.Hint = "Resultado de " + letra2;
          
    
        }

        private void obtenerValoresEcuacion2(String ecuacion2)
        {
            string valores = string.Empty;
            int var = 1;

            for (int i = 0; i < ecuacion2.Length; i++)
            {
                switch (ecuacion2[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'ñ':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        if (valores == string.Empty || valores == "+")
                            valores = "1";
                        else if (valores == "-")
                            valores = "-1";

                        if (var == 1)
                        {
                            x2 = Double.Parse(valores);
                            var++;
                        }
                        else if (var == 2)
                        {
                            y2 = Double.Parse(valores);
                            var++;
                        }
                        valores = string.Empty;
                        break;
                    case '=':
                        valores = string.Empty;
                        break;
                    default:
                        valores += ecuacion2[i];
                        break;
                }
            }

            r2 = Double.Parse(valores);
            //otro error
            txtX.Hint = "Resultado de " + letra1;
            txtY.Hint = "Resultado de " + letra2;
        }

        //Despeje de una variable
        private void paso1()
        {
            varDes = String.Empty;
            //Paso 1.1
            y1Contraria = y1 * (-1);

            if (x1 != 1 && x1 != -1)
                varDes += Convert.ToString(x1);
            else if (x1 == -1)
                varDes += -1;

            if (y1Contraria >= 0)
                varDes += letra1 + " = " + Convert.ToString(r1) + " + ";
            else
                varDes += letra1 + " = " + Convert.ToString(r1) + " - ";

            if (y1Contraria == 1 || y1Contraria == -1)
                varDes += letra2;
            else
                varDes += y1Contraria + letra2;

            lblPaso1_1.Text = varDes;

            //Paso 1.2
            y1Contraria = y1 * (-1);
            varDes = "(" + r1;

            if (y1Contraria >= 0)
                varDes += " + ";
            else
                varDes += " - ";

            if (y1Contraria == 1 || y1Contraria == -1)
                varDes += letra2 + ")/" + x1;
            else
                varDes += y1Contraria + ")/" + x1;

            lblPaso1_2.Text = letra1 + " = " + varDes;
        }

        //Sustituir en la otra ecuación la variable despejada por el valor obtenido
        private void paso2()
        {
            ecu2sus = x2 + "(" + varDes + ")";

            if (y2 >= 0)
                ecu2sus += " + ";
            else
                ecu2sus += " - ";

            if (y2 == 1 || y2 == -1)
                ecu2sus += letra2 + " = " + r2;
            else
                ecu2sus += y2 + letra2 + " = " + r2;

            lblPaso2.Text = ecu2sus;
        }

        //Resolver la ecuación obtenida
        private void paso3()
        {
            //Paso 3.1
            ecu2res = "((" + (x2 * r1);

            if ((x2 * y1Contraria) >= 0)
                ecu2res += " + ";

            if ((x2 * y1Contraria) == 1)
                ecu2res += letra2 + ")/" + x1 + ")";
            else if ((x2 * y1Contraria) == -1)
                ecu2res += letra2 + ")/" + x1 + ")";
            else
                ecu2res += (x2 * y1Contraria) + letra2 + ")/" + x1 + ")";

            if (y2 >= 0)
                ecu2res += " + ";
            else
                ecu2res += " - ";

            if (y2 == 1 || y2 == -1)
                ecu2res += letra2 + " = " + r2;
            else
                ecu2res += y2 + letra2 + " = " + r2;

            lblPaso3_1.Text = ecu2res;

            //Paso 3.2
            ecu2res = Convert.ToString(Decimal.Round(Convert.ToDecimal(x2 * r1 / x1), 2));

            if ((x2 * y1Contraria / x1) >= 0)
                ecu2res += " + ";

            if ((x2 * y1Contraria / x1) == 1 || (x2 * y1Contraria / x1) == -1)
                ecu2res += letra2;
            else
                ecu2res += Decimal.Round(Convert.ToDecimal(x2 * y1Contraria / x1), 2) + letra2;

            if (y2 >= 0)
                ecu2res += " + ";
            else
                ecu2res += " - ";

            if (y2 == 1 || y2 == -1)
                ecu2res += letra2 + " = " + r2;
            else
                ecu2res += y2 + letra2 + " = " + r2;

            lblPaso3_2.Text = ecu2res;

            //Paso 3.3

            if ((x2 * y1Contraria / x1) < 0)
                ecu2res = " - ";

            if ((x2 * y1Contraria / x1) == 1 || (x2 * y1Contraria / x1) == -1)
                ecu2res = letra2;
            else
                ecu2res = Decimal.Round(Convert.ToDecimal(x2 * y1Contraria / x1), 2) + letra2;

            if (y2 >= 0)
                ecu2res += " + ";
            else
                ecu2res += " - ";

            if (y2 == 1 || y2 == -1)
                ecu2res += letra2 + " = " + r2;
            else
                ecu2res += y2 + letra2 + " = " + r2;

            if (-(x2 * r1 / x1) >= 0)
                ecu2res += " + " + Decimal.Round(Convert.ToDecimal(-(x2 * r1 / x1)), 2);
            else
                ecu2res += Decimal.Round(Convert.ToDecimal(-(x2 * r1 / x1)), 2);

            lblPaso3_3.Text = ecu2res;

            //Paso 3.4
            double primY = x2 * y1Contraria / x1;
            double segIn = -(x2 * r1 / x1);
            double yTot = primY + y2;
            double inTot = r2 + segIn;

            ecu2res = String.Empty;
            if (yTot == -1)
                ecu2res += "-" + letra2 + " = " + Decimal.Round(Convert.ToDecimal(inTot), 2);
            else if (yTot == 1)
                ecu2res += letra2 + " = " + Decimal.Round(Convert.ToDecimal(inTot), 2);
            else
                ecu2res += Decimal.Round(Convert.ToDecimal(yTot), 2) + letra2 + " = " + Decimal.Round(Convert.ToDecimal(inTot), 2);

            lblPaso3_4.Text = ecu2res;

            //Paso 3.5 (SOLO SE EJECUTARAN SI EL COEFICIENTE DE Y ES DISTINTO A 1)
            if (yTot != 1)
                ecu2res = letra2 + " = " + Decimal.Round(Convert.ToDecimal(inTot), 2) + "/" + Decimal.Round(Convert.ToDecimal(yTot), 2);
            lblPaso3_5.Text = ecu2res;

            //Paso 3.6 (VALOR DE Y)
            solY = inTot / yTot;
            ecu2res = letra2 + " = " + solY;
            lblPaso3_6.Text = ecu2res;
        }

        //Sustituir el valor obtenido en la variable despejada
        private void paso4()
        {
            //Paso 4.1
            varDes = "(" + r1;

            if (y1Contraria >= 0)
                varDes += " + ";
            else
                varDes += " - ";

            if (solY < 0)
                varDes += "(" + solY + "))/" + x1;
            else
                varDes += solY + ")/" + x1;

            lblPaso4_1.Text = letra1 + " = " + varDes;

            //Paso 4.2
            varDes = letra1 + " = ";

            if (y1Contraria >= 0)
            {
                varDes += (r1 + solY) + "/" + x1;
                solX = (r1 + solY) / x1;
            }
            else
            {
                varDes += (r1 - solY) + "/" + x1;
                solX = (r1 - solY) / x1;
            }
            lblPaso4_2.Text = varDes;

            //Paso 4.3
            lblPaso4_3.Text = letra1 + " = " + solX;

        }

        //Comprobación de los resultados
        private void paso5()
        {
            String ec1, ec2;

            //Paso 5.1
            if (x1 == -1)
                ec1 = "-" + solX;
            else if (x1 == 1)
                ec1 = Convert.ToString(solX);
            else
                ec1 = Convert.ToString(x1) + "(" + solX + ") ";

            if (y1 == 1)
            {
                ec1 += " + " + solY + " = " + r1;
                if (solY < 0)
                    ec1 += "(" + solY + ") = " + r1;
            }
            else if (y1 >= 0)
                ec1 += " + " + y1 + "(" + solY + ") = " + r1;
            else
                ec1 += y1 + "(" + solY + ") = " + r1;

            lblPaso5_1.Text = ec1;

            //Paso 5.2
            ec1 = Convert.ToString(x1 * solX);

            if ((y1 * solY) > 0)
                ec1 += " + " + Convert.ToString(y1 * solY);
            else
                ec1 += Convert.ToString(y1 * solY);

            ec1 += " = " + r1;

            lblPaso5_2.Text = ec1;

            if (lblPaso5_2.Text == lblPaso5_1.Text)
                lblPaso5_2.Text = String.Empty;

            //Paso 5.3
            solEc1 = (x1 * solX) + (y1 * solY);
            if (lblPaso5_2.Text == String.Empty)
            {
                lblPaso5_2.Text = Convert.ToString(solEc1) + " = " + r1;
                lblPaso5_3.Text = String.Empty;
            }
            else
                lblPaso5_3.Text = Convert.ToString(solEc1) + " = " + r1;

            //Paso 5.4
            if (x2 == -1)
                ec2 = "-" + solX;
            else if (x2 == 1)
                ec2 = Convert.ToString(solX);
            else
                ec2 = Convert.ToString(x2) + "(" + solX + ") ";

            if (y2 == 1)
            {
                ec2 += " + " + solY + " = " + r2;
                if (solY < 0)
                    ec2 += "(" + solY + ") = " + r2;
            }
            else if (y2 >= 0)
                ec2 += " + " + y2 + "(" + solY + ") = " + r2;
            else
                ec2 += y2 + "(" + solY + ") = " + r2;

            lblPaso5_4.Text = ec2;

            //Paso 5.5
            ec2 = Convert.ToString(x2 * solX);

            if ((y2 * solY) > 0)
                ec2 += " + " + Convert.ToString(y2 * solY);
            else
                ec2 += Convert.ToString(y2 * solY);

            ec2 += " = " + r2;

            lblPaso5_5.Text = ec2;

            if (lblPaso5_5.Text == lblPaso5_4.Text)
                lblPaso5_5.Text = String.Empty;

            //Paso 5.6
            solEc2 = (x2 * solX) + (y2 * solY);
            if (lblPaso5_5.Text == String.Empty)
            {
                lblPaso5_5.Text = Convert.ToString(solEc2) + " = " + r2;
                lblPaso5_6.Text = String.Empty;
            }
            else
                lblPaso5_6.Text = Convert.ToString(solEc2) + " = " + r2;
        }

        private void mostrarResultados()
        {
            if (solEc1 == r1 && solEc2 == r2)
            {
                txtX.Text = Convert.ToString(solX);
                txtY.Text = Convert.ToString(solY);
               
            }
            else
            {
                txtX.Visible = false;
                txtY.Visible = false;
           
                lblSinResultados.Visible = true;
                
            }

        }
    }
}
