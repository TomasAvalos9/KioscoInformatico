namespace KioscoInformaticoDesktop.Views
{
    partial class ProductosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtOnModificarar = new FontAwesome.Sharp.IconButton();
            iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            dataGridProductosView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            numericPrecio = new NumericUpDown();
            txtPrecio = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductosView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 52);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 33);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(0, 58);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(899, 442);
            tabControl.TabIndex = 2;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(iconButtonSalir);
            tabPageLista.Controls.Add(BtnBuscar);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(iconButtonEliminar);
            tabPageLista.Controls.Add(iconButtOnModificarar);
            tabPageLista.Controls.Add(iconButtonAgregar);
            tabPageLista.Controls.Add(dataGridProductosView);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3, 3, 3, 3);
            tabPageLista.Size = new Size(891, 414);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonSalir.BackColor = Color.OrangeRed;
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.IconSize = 44;
            iconButtonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSalir.Location = new Point(760, 289);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(108, 56);
            iconButtonSalir.TabIndex = 10;
            iconButtonSalir.Text = "&Salir";
            iconButtonSalir.TextAlign = ContentAlignment.MiddleRight;
            iconButtonSalir.UseVisualStyleBackColor = false;
            iconButtonSalir.Click += iconButtonSalir_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.OrangeRed;
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.White;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(760, 10);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(108, 56);
            BtnBuscar.TabIndex = 9;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 11);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 8;
            label3.Text = "Buscar producto:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(142, 11);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(597, 23);
            txtFiltro.TabIndex = 7;
            // 
            // iconButtonEliminar
            // 
            iconButtonEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonEliminar.BackColor = Color.OrangeRed;
            iconButtonEliminar.ForeColor = Color.White;
            iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.ToiletPortable;
            iconButtonEliminar.IconColor = Color.White;
            iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEliminar.IconSize = 44;
            iconButtonEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonEliminar.Location = new Point(760, 220);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(108, 56);
            iconButtonEliminar.TabIndex = 6;
            iconButtonEliminar.Text = "Eli&minar";
            iconButtonEliminar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonEliminar.UseVisualStyleBackColor = false;
            iconButtonEliminar.Click += iconButtonEliminar_Click;
            // 
            // iconButtOnModificarar
            // 
            iconButtOnModificarar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtOnModificarar.BackColor = Color.OrangeRed;
            iconButtOnModificarar.ForeColor = Color.White;
            iconButtOnModificarar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButtOnModificarar.IconColor = Color.White;
            iconButtOnModificarar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtOnModificarar.IconSize = 45;
            iconButtOnModificarar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtOnModificarar.Location = new Point(760, 146);
            iconButtOnModificarar.Name = "iconButtOnModificarar";
            iconButtOnModificarar.Size = new Size(108, 56);
            iconButtOnModificarar.TabIndex = 5;
            iconButtOnModificarar.Text = "&Editar";
            iconButtOnModificarar.TextAlign = ContentAlignment.MiddleRight;
            iconButtOnModificarar.UseVisualStyleBackColor = false;
            iconButtOnModificarar.Click += iconButtOnModificarar_Click;
            // 
            // iconButtonAgregar
            // 
            iconButtonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonAgregar.BackColor = Color.OrangeRed;
            iconButtonAgregar.ForeColor = Color.White;
            iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonAgregar.IconColor = Color.White;
            iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonAgregar.Location = new Point(760, 73);
            iconButtonAgregar.Name = "iconButtonAgregar";
            iconButtonAgregar.Size = new Size(108, 56);
            iconButtonAgregar.TabIndex = 4;
            iconButtonAgregar.Text = "&Agregar";
            iconButtonAgregar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonAgregar.UseVisualStyleBackColor = false;
            iconButtonAgregar.Click += iconButtonAgregar_Click;
            // 
            // dataGridProductosView
            // 
            dataGridProductosView.AllowUserToAddRows = false;
            dataGridProductosView.AllowUserToDeleteRows = false;
            dataGridProductosView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductosView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridProductosView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridProductosView.Location = new Point(3, 44);
            dataGridProductosView.Name = "dataGridProductosView";
            dataGridProductosView.ReadOnly = true;
            dataGridProductosView.RowHeadersWidth = 51;
            dataGridProductosView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProductosView.Size = new Size(736, 367);
            dataGridProductosView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(numericPrecio);
            tabPageAgregarEditar.Controls.Add(txtPrecio);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3, 3, 3, 3);
            tabPageAgregarEditar.Size = new Size(891, 414);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Location = new Point(389, 155);
            numericPrecio.Maximum = new decimal(new int[] { 268435456, 1042612833, 542101086, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(197, 23);
            numericPrecio.TabIndex = 13;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.AutoSize = true;
            txtPrecio.Location = new Point(299, 157);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(43, 15);
            txtPrecio.TabIndex = 12;
            txtPrecio.Text = "Precio:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(514, 275);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 60);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(277, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 60);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(389, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 49);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 502);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "ProductosView";
            Text = "ProductosView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductosView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtOnModificarar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private Label txtPrecio;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        public DataGridView dataGridProductosView;
        public TextBox txtFiltro;
        public TabControl tabControl;
        public TabPage tabPageLista;
        public TabPage tabPageAgregarEditar;
        public TextBox txtNombre;
        public NumericUpDown numericPrecio;
    }
}