namespace Método_de_sustitución
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.themeToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCalcular = new MaterialSkin.Controls.MaterialButton();
            this.txtEcuacion2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEcuacion1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblSinResultados = new MaterialSkin.Controls.MaterialLabel();
            this.txtY = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtX = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblPaso1_2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso1_1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.lblPaso4_3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso4_2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso4_1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.lblPaso3_6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso3_5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso3_4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso3_3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso3_2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso3_1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.lblPaso2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.lblPaso5_6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso5_5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso5_4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso5_3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso5_2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaso5_1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDato = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.epEcuacion1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEcuacion2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).BeginInit();
            this.materialCard8.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEcuacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEcuacion2)).BeginInit();
            this.SuspendLayout();
            // 
            // themeToggle
            // 
            this.themeToggle.AutoSize = true;
            this.themeToggle.Depth = 0;
            this.themeToggle.Location = new System.Drawing.Point(986, 40);
            this.themeToggle.Margin = new System.Windows.Forms.Padding(0);
            this.themeToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeToggle.Name = "themeToggle";
            this.themeToggle.Ripple = true;
            this.themeToggle.Size = new System.Drawing.Size(99, 37);
            this.themeToggle.TabIndex = 34;
            this.themeToggle.Text = "Tema";
            this.themeToggle.UseVisualStyleBackColor = true;
            this.themeToggle.CheckedChanged += new System.EventHandler(this.themeToggle_CheckedChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.btnCalcular);
            this.materialCard1.Controls.Add(this.txtEcuacion2);
            this.materialCard1.Controls.Add(this.txtEcuacion1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(346, 275);
            this.materialCard1.TabIndex = 35;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(62, 203);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(79, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Limpiar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(81, 29);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(167, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Ingresa tus ecuaciones:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalcular.Depth = 0;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.HighEmphasis = true;
            this.btnCalcular.Icon = null;
            this.btnCalcular.Location = new System.Drawing.Point(174, 203);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalcular.Size = new System.Drawing.Size(95, 36);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalcular.UseAccentColor = false;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtEcuacion2
            // 
            this.txtEcuacion2.AnimateReadOnly = false;
            this.txtEcuacion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEcuacion2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEcuacion2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEcuacion2.Depth = 0;
            this.txtEcuacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEcuacion2.HideSelection = true;
            this.txtEcuacion2.Hint = "Ecuación 2";
            this.txtEcuacion2.LeadingIcon = null;
            this.txtEcuacion2.Location = new System.Drawing.Point(42, 125);
            this.txtEcuacion2.MaxLength = 32767;
            this.txtEcuacion2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEcuacion2.Name = "txtEcuacion2";
            this.txtEcuacion2.PasswordChar = '\0';
            this.txtEcuacion2.PrefixSuffixText = null;
            this.txtEcuacion2.ReadOnly = false;
            this.txtEcuacion2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEcuacion2.SelectedText = "";
            this.txtEcuacion2.SelectionLength = 0;
            this.txtEcuacion2.SelectionStart = 0;
            this.txtEcuacion2.ShortcutsEnabled = false;
            this.txtEcuacion2.Size = new System.Drawing.Size(250, 48);
            this.txtEcuacion2.TabIndex = 1;
            this.txtEcuacion2.TabStop = false;
            this.txtEcuacion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEcuacion2.TrailingIcon = null;
            this.txtEcuacion2.UseSystemPasswordChar = false;
            this.txtEcuacion2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEcuacion2_KeyPress);
            this.txtEcuacion2.TextChanged += new System.EventHandler(this.txtEcuacion2_TextChanged);
            // 
            // txtEcuacion1
            // 
            this.txtEcuacion1.AnimateReadOnly = false;
            this.txtEcuacion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEcuacion1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEcuacion1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEcuacion1.Depth = 0;
            this.txtEcuacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEcuacion1.HelperText = "5x+y=8";
            this.txtEcuacion1.HideSelection = true;
            this.txtEcuacion1.Hint = "Ecuación 1";
            this.txtEcuacion1.LeadingIcon = null;
            this.txtEcuacion1.Location = new System.Drawing.Point(42, 62);
            this.txtEcuacion1.MaxLength = 32767;
            this.txtEcuacion1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEcuacion1.Name = "txtEcuacion1";
            this.txtEcuacion1.PasswordChar = '\0';
            this.txtEcuacion1.PrefixSuffixText = null;
            this.txtEcuacion1.ReadOnly = false;
            this.txtEcuacion1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEcuacion1.SelectedText = "";
            this.txtEcuacion1.SelectionLength = 0;
            this.txtEcuacion1.SelectionStart = 0;
            this.txtEcuacion1.ShortcutsEnabled = false;
            this.txtEcuacion1.Size = new System.Drawing.Size(250, 48);
            this.txtEcuacion1.TabIndex = 0;
            this.txtEcuacion1.TabStop = false;
            this.txtEcuacion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEcuacion1.TrailingIcon = null;
            this.txtEcuacion1.UseSystemPasswordChar = false;
            this.txtEcuacion1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEcuacion2_KeyPress);
            this.txtEcuacion1.TextChanged += new System.EventHandler(this.txtEcuacion2_TextChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblSinResultados);
            this.materialCard2.Controls.Add(this.txtY);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.txtX);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(23, 372);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(346, 261);
            this.materialCard2.TabIndex = 36;
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.Depth = 0;
            this.lblSinResultados.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSinResultados.Location = new System.Drawing.Point(17, 122);
            this.lblSinResultados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(303, 19);
            this.lblSinResultados.TabIndex = 38;
            this.lblSinResultados.Text = "El sistema de ecuaciones no tiene solución";
            this.lblSinResultados.Visible = false;
            // 
            // txtY
            // 
            this.txtY.AnimateReadOnly = false;
            this.txtY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtY.Depth = 0;
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtY.HideSelection = true;
            this.txtY.Hint = "Resultado de V2";
            this.txtY.LeadingIcon = null;
            this.txtY.Location = new System.Drawing.Point(42, 165);
            this.txtY.MaxLength = 32767;
            this.txtY.MouseState = MaterialSkin.MouseState.OUT;
            this.txtY.Name = "txtY";
            this.txtY.PasswordChar = '\0';
            this.txtY.PrefixSuffixText = null;
            this.txtY.ReadOnly = true;
            this.txtY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtY.SelectedText = "";
            this.txtY.SelectionLength = 0;
            this.txtY.SelectionStart = 0;
            this.txtY.ShortcutsEnabled = true;
            this.txtY.Size = new System.Drawing.Size(250, 48);
            this.txtY.TabIndex = 37;
            this.txtY.TabStop = false;
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtY.TrailingIcon = null;
            this.txtY.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(99, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(139, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Los resultados son:";
            // 
            // txtX
            // 
            this.txtX.AnimateReadOnly = false;
            this.txtX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtX.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX.Depth = 0;
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtX.HideSelection = true;
            this.txtX.Hint = "Resultado de V1";
            this.txtX.LeadingIcon = null;
            this.txtX.Location = new System.Drawing.Point(42, 51);
            this.txtX.MaxLength = 32767;
            this.txtX.MouseState = MaterialSkin.MouseState.OUT;
            this.txtX.Name = "txtX";
            this.txtX.PasswordChar = '\0';
            this.txtX.PrefixSuffixText = null;
            this.txtX.ReadOnly = true;
            this.txtX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtX.SelectedText = "";
            this.txtX.SelectionLength = 0;
            this.txtX.SelectionStart = 0;
            this.txtX.ShortcutsEnabled = true;
            this.txtX.Size = new System.Drawing.Size(250, 48);
            this.txtX.TabIndex = 5;
            this.txtX.TabStop = false;
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtX.TrailingIcon = null;
            this.txtX.UseSystemPasswordChar = false;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lblPaso1_2);
            this.materialCard3.Controls.Add(this.lblPaso1_1);
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(385, 81);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(216, 123);
            this.materialCard3.TabIndex = 37;
            // 
            // lblPaso1_2
            // 
            this.lblPaso1_2.AutoSize = true;
            this.lblPaso1_2.Depth = 0;
            this.lblPaso1_2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso1_2.Location = new System.Drawing.Point(18, 79);
            this.lblPaso1_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso1_2.Name = "lblPaso1_2";
            this.lblPaso1_2.Size = new System.Drawing.Size(133, 19);
            this.lblPaso1_2.TabIndex = 2;
            this.lblPaso1_2.Text = "Etiqueta de prueba";
            this.lblPaso1_2.Visible = false;
            // 
            // lblPaso1_1
            // 
            this.lblPaso1_1.AutoSize = true;
            this.lblPaso1_1.Depth = 0;
            this.lblPaso1_1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso1_1.Location = new System.Drawing.Point(17, 42);
            this.lblPaso1_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso1_1.Name = "lblPaso1_1";
            this.lblPaso1_1.Size = new System.Drawing.Size(133, 19);
            this.lblPaso1_1.TabIndex = 1;
            this.lblPaso1_1.Text = "Etiqueta de prueba";
            this.lblPaso1_1.Visible = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(75, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Paso 1:";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.lblPaso4_3);
            this.materialCard4.Controls.Add(this.lblPaso4_2);
            this.materialCard4.Controls.Add(this.lblPaso4_1);
            this.materialCard4.Controls.Add(this.materialLabel6);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(385, 221);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(216, 214);
            this.materialCard4.TabIndex = 38;
            // 
            // lblPaso4_3
            // 
            this.lblPaso4_3.AutoSize = true;
            this.lblPaso4_3.Depth = 0;
            this.lblPaso4_3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso4_3.Location = new System.Drawing.Point(18, 146);
            this.lblPaso4_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso4_3.Name = "lblPaso4_3";
            this.lblPaso4_3.Size = new System.Drawing.Size(133, 19);
            this.lblPaso4_3.TabIndex = 6;
            this.lblPaso4_3.Text = "Etiqueta de prueba";
            this.lblPaso4_3.Visible = false;
            // 
            // lblPaso4_2
            // 
            this.lblPaso4_2.AutoSize = true;
            this.lblPaso4_2.Depth = 0;
            this.lblPaso4_2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso4_2.Location = new System.Drawing.Point(18, 93);
            this.lblPaso4_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso4_2.Name = "lblPaso4_2";
            this.lblPaso4_2.Size = new System.Drawing.Size(133, 19);
            this.lblPaso4_2.TabIndex = 5;
            this.lblPaso4_2.Text = "Etiqueta de prueba";
            this.lblPaso4_2.Visible = false;
            // 
            // lblPaso4_1
            // 
            this.lblPaso4_1.AutoSize = true;
            this.lblPaso4_1.Depth = 0;
            this.lblPaso4_1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso4_1.Location = new System.Drawing.Point(18, 46);
            this.lblPaso4_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso4_1.Name = "lblPaso4_1";
            this.lblPaso4_1.Size = new System.Drawing.Size(133, 19);
            this.lblPaso4_1.TabIndex = 4;
            this.lblPaso4_1.Text = "Etiqueta de prueba";
            this.lblPaso4_1.Visible = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(72, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(54, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Paso 4:";
            // 
            // materialCard5
            // 
            this.materialCard5.AutoSize = true;
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.lblPaso3_6);
            this.materialCard5.Controls.Add(this.lblPaso3_5);
            this.materialCard5.Controls.Add(this.lblPaso3_4);
            this.materialCard5.Controls.Add(this.lblPaso3_3);
            this.materialCard5.Controls.Add(this.lblPaso3_2);
            this.materialCard5.Controls.Add(this.lblPaso3_1);
            this.materialCard5.Controls.Add(this.materialLabel8);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(847, 81);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(240, 354);
            this.materialCard5.TabIndex = 39;
            // 
            // lblPaso3_6
            // 
            this.lblPaso3_6.AutoSize = true;
            this.lblPaso3_6.Depth = 0;
            this.lblPaso3_6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso3_6.Location = new System.Drawing.Point(18, 279);
            this.lblPaso3_6.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso3_6.Name = "lblPaso3_6";
            this.lblPaso3_6.Size = new System.Drawing.Size(133, 19);
            this.lblPaso3_6.TabIndex = 13;
            this.lblPaso3_6.Text = "Etiqueta de prueba";
            this.lblPaso3_6.Visible = false;
            // 
            // lblPaso3_5
            // 
            this.lblPaso3_5.AutoSize = true;
            this.lblPaso3_5.Depth = 0;
            this.lblPaso3_5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso3_5.Location = new System.Drawing.Point(17, 228);
            this.lblPaso3_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso3_5.Name = "lblPaso3_5";
            this.lblPaso3_5.Size = new System.Drawing.Size(133, 19);
            this.lblPaso3_5.TabIndex = 12;
            this.lblPaso3_5.Text = "Etiqueta de prueba";
            this.lblPaso3_5.Visible = false;
            // 
            // lblPaso3_4
            // 
            this.lblPaso3_4.AutoSize = true;
            this.lblPaso3_4.Depth = 0;
            this.lblPaso3_4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso3_4.Location = new System.Drawing.Point(18, 184);
            this.lblPaso3_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso3_4.Name = "lblPaso3_4";
            this.lblPaso3_4.Size = new System.Drawing.Size(133, 19);
            this.lblPaso3_4.TabIndex = 11;
            this.lblPaso3_4.Text = "Etiqueta de prueba";
            this.lblPaso3_4.Visible = false;
            // 
            // lblPaso3_3
            // 
            this.lblPaso3_3.AutoSize = true;
            this.lblPaso3_3.Depth = 0;
            this.lblPaso3_3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso3_3.Location = new System.Drawing.Point(17, 142);
            this.lblPaso3_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso3_3.Name = "lblPaso3_3";
            this.lblPaso3_3.Size = new System.Drawing.Size(133, 19);
            this.lblPaso3_3.TabIndex = 10;
            this.lblPaso3_3.Text = "Etiqueta de prueba";
            this.lblPaso3_3.Visible = false;
            // 
            // lblPaso3_2
            // 
            this.lblPaso3_2.AutoSize = true;
            this.lblPaso3_2.Depth = 0;
            this.lblPaso3_2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso3_2.Location = new System.Drawing.Point(17, 93);
            this.lblPaso3_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso3_2.Name = "lblPaso3_2";
            this.lblPaso3_2.Size = new System.Drawing.Size(133, 19);
            this.lblPaso3_2.TabIndex = 9;
            this.lblPaso3_2.Text = "Etiqueta de prueba";
            this.lblPaso3_2.Visible = false;
            // 
            // lblPaso3_1
            // 
            this.lblPaso3_1.AutoSize = true;
            this.lblPaso3_1.Depth = 0;
            this.lblPaso3_1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso3_1.Location = new System.Drawing.Point(17, 51);
            this.lblPaso3_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso3_1.Name = "lblPaso3_1";
            this.lblPaso3_1.Size = new System.Drawing.Size(133, 19);
            this.lblPaso3_1.TabIndex = 8;
            this.lblPaso3_1.Text = "Etiqueta de prueba";
            this.lblPaso3_1.Visible = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(72, 14);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(54, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Paso 3:";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.lblPaso2);
            this.materialCard6.Controls.Add(this.materialLabel5);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(617, 82);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(215, 100);
            this.materialCard6.TabIndex = 40;
            // 
            // lblPaso2
            // 
            this.lblPaso2.AutoSize = true;
            this.lblPaso2.Depth = 0;
            this.lblPaso2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso2.Location = new System.Drawing.Point(34, 48);
            this.lblPaso2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso2.Name = "lblPaso2";
            this.lblPaso2.Size = new System.Drawing.Size(133, 19);
            this.lblPaso2.TabIndex = 10;
            this.lblPaso2.Text = "Etiqueta de prueba";
            this.lblPaso2.Visible = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(72, 14);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(54, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Paso 2:";
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.lblPaso5_6);
            this.materialCard7.Controls.Add(this.lblPaso5_5);
            this.materialCard7.Controls.Add(this.lblPaso5_4);
            this.materialCard7.Controls.Add(this.lblPaso5_3);
            this.materialCard7.Controls.Add(this.lblPaso5_2);
            this.materialCard7.Controls.Add(this.lblPaso5_1);
            this.materialCard7.Controls.Add(this.materialLabel13);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(617, 197);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(215, 239);
            this.materialCard7.TabIndex = 40;
            // 
            // lblPaso5_6
            // 
            this.lblPaso5_6.AutoSize = true;
            this.lblPaso5_6.Depth = 0;
            this.lblPaso5_6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso5_6.Location = new System.Drawing.Point(16, 204);
            this.lblPaso5_6.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso5_6.Name = "lblPaso5_6";
            this.lblPaso5_6.Size = new System.Drawing.Size(133, 19);
            this.lblPaso5_6.TabIndex = 13;
            this.lblPaso5_6.Text = "Etiqueta de prueba";
            this.lblPaso5_6.Visible = false;
            // 
            // lblPaso5_5
            // 
            this.lblPaso5_5.AutoSize = true;
            this.lblPaso5_5.Depth = 0;
            this.lblPaso5_5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso5_5.Location = new System.Drawing.Point(16, 172);
            this.lblPaso5_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso5_5.Name = "lblPaso5_5";
            this.lblPaso5_5.Size = new System.Drawing.Size(133, 19);
            this.lblPaso5_5.TabIndex = 12;
            this.lblPaso5_5.Text = "Etiqueta de prueba";
            this.lblPaso5_5.Visible = false;
            // 
            // lblPaso5_4
            // 
            this.lblPaso5_4.AutoSize = true;
            this.lblPaso5_4.Depth = 0;
            this.lblPaso5_4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso5_4.Location = new System.Drawing.Point(16, 140);
            this.lblPaso5_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso5_4.Name = "lblPaso5_4";
            this.lblPaso5_4.Size = new System.Drawing.Size(133, 19);
            this.lblPaso5_4.TabIndex = 11;
            this.lblPaso5_4.Text = "Etiqueta de prueba";
            this.lblPaso5_4.Visible = false;
            // 
            // lblPaso5_3
            // 
            this.lblPaso5_3.AutoSize = true;
            this.lblPaso5_3.Depth = 0;
            this.lblPaso5_3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso5_3.Location = new System.Drawing.Point(16, 106);
            this.lblPaso5_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso5_3.Name = "lblPaso5_3";
            this.lblPaso5_3.Size = new System.Drawing.Size(133, 19);
            this.lblPaso5_3.TabIndex = 10;
            this.lblPaso5_3.Text = "Etiqueta de prueba";
            this.lblPaso5_3.Visible = false;
            // 
            // lblPaso5_2
            // 
            this.lblPaso5_2.AutoSize = true;
            this.lblPaso5_2.Depth = 0;
            this.lblPaso5_2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso5_2.Location = new System.Drawing.Point(16, 75);
            this.lblPaso5_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso5_2.Name = "lblPaso5_2";
            this.lblPaso5_2.Size = new System.Drawing.Size(133, 19);
            this.lblPaso5_2.TabIndex = 9;
            this.lblPaso5_2.Text = "Etiqueta de prueba";
            this.lblPaso5_2.Visible = false;
            // 
            // lblPaso5_1
            // 
            this.lblPaso5_1.AutoSize = true;
            this.lblPaso5_1.Depth = 0;
            this.lblPaso5_1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaso5_1.Location = new System.Drawing.Point(16, 44);
            this.lblPaso5_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaso5_1.Name = "lblPaso5_1";
            this.lblPaso5_1.Size = new System.Drawing.Size(133, 19);
            this.lblPaso5_1.TabIndex = 8;
            this.lblPaso5_1.Text = "Etiqueta de prueba";
            this.lblPaso5_1.Visible = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(72, 14);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(54, 19);
            this.materialLabel13.TabIndex = 7;
            this.materialLabel13.Text = "Paso 5:";
            // 
            // dgvDato
            // 
            this.dgvDato.AllowUserToAddRows = false;
            this.dgvDato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(150)))), ((int)(((byte)(65)))));
            this.dgvDato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(150)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(150)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDato.EnableHeadersVisualStyles = false;
            this.dgvDato.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(212)))), ((int)(((byte)(156)))));
            this.dgvDato.Location = new System.Drawing.Point(393, 460);
            this.dgvDato.Name = "dgvDato";
            this.dgvDato.ReadOnly = true;
            this.dgvDato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(212)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(212)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDato.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(150)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(212)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDato.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDato.Size = new System.Drawing.Size(686, 116);
            this.dgvDato.TabIndex = 14;
            this.dgvDato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDato_CellClick);
            this.dgvDato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDato_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(358, 134);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(161, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar registro";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.btnCancelar);
            this.materialCard8.Controls.Add(this.btnEliminar);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(385, 451);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(702, 182);
            this.materialCard8.TabIndex = 41;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(189, 134);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(161, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 35);
            this.panel1.TabIndex = 51;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Depth = 0;
            this.btnMinimizar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMinimizar.Location = new System.Drawing.Point(1039, 4);
            this.btnMinimizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = "‒";
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCerrar.Location = new System.Drawing.Point(1073, 4);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(25, 43);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(561, 29);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Sistema de ecuaciones 2x2, Método por sustitución";
            // 
            // epEcuacion1
            // 
            this.epEcuacion1.ContainerControl = this;
            this.epEcuacion1.Icon = ((System.Drawing.Icon)(resources.GetObject("epEcuacion1.Icon")));
            // 
            // epEcuacion2
            // 
            this.epEcuacion2.ContainerControl = this;
            this.epEcuacion2.Icon = ((System.Drawing.Icon)(resources.GetObject("epEcuacion2.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 670);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDato);
            this.Controls.Add(this.materialCard8);
            this.Controls.Add(this.materialCard7);
            this.Controls.Add(this.materialCard6);
            this.Controls.Add(this.materialCard5);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.themeToggle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método de sustitución";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).EndInit();
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epEcuacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEcuacion2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch themeToggle;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnCalcular;
        private MaterialSkin.Controls.MaterialTextBox2 txtEcuacion2;
        private MaterialSkin.Controls.MaterialTextBox2 txtEcuacion1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblSinResultados;
        private MaterialSkin.Controls.MaterialTextBox2 txtY;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtX;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lblPaso1_2;
        private MaterialSkin.Controls.MaterialLabel lblPaso1_1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel lblPaso4_3;
        private MaterialSkin.Controls.MaterialLabel lblPaso4_2;
        private MaterialSkin.Controls.MaterialLabel lblPaso4_1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel lblPaso3_6;
        private MaterialSkin.Controls.MaterialLabel lblPaso3_5;
        private MaterialSkin.Controls.MaterialLabel lblPaso3_4;
        private MaterialSkin.Controls.MaterialLabel lblPaso3_3;
        private MaterialSkin.Controls.MaterialLabel lblPaso3_2;
        private MaterialSkin.Controls.MaterialLabel lblPaso3_1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel lblPaso2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialLabel lblPaso5_6;
        private MaterialSkin.Controls.MaterialLabel lblPaso5_5;
        private MaterialSkin.Controls.MaterialLabel lblPaso5_4;
        private MaterialSkin.Controls.MaterialLabel lblPaso5_3;
        private MaterialSkin.Controls.MaterialLabel lblPaso5_2;
        private MaterialSkin.Controls.MaterialLabel lblPaso5_1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.DataGridView dgvDato;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel btnCerrar;
        private MaterialSkin.Controls.MaterialLabel btnMinimizar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private System.Windows.Forms.ErrorProvider epEcuacion1;
        private System.Windows.Forms.ErrorProvider epEcuacion2;
    }
}

