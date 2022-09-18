namespace Actividad2
{
    partial class frmArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.lbArticulos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbBuscarPor = new System.Windows.Forms.Label();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lbLimpiarFiltro = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(53, 107);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvArticulos.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(933, 546);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.Thistle;
            this.btnDetalles.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnDetalles.Location = new System.Drawing.Point(209, 661);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(127, 32);
            this.btnDetalles.TabIndex = 2;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.Thistle;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(56, 661);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarArticulo.Size = new System.Drawing.Size(109, 32);
            this.btnAgregarArticulo.TabIndex = 1;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(1288, 730);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(132, 39);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.Thistle;
            this.btnModificarArticulo.CausesValidation = false;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnModificarArticulo.Location = new System.Drawing.Point(1075, 730);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(125, 39);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // lbArticulos
            // 
            this.lbArticulos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbArticulos.AutoSize = true;
            this.lbArticulos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbArticulos.Location = new System.Drawing.Point(368, 28);
            this.lbArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArticulos.Name = "lbArticulos";
            this.lbArticulos.Size = new System.Drawing.Size(128, 37);
            this.lbArticulos.TabIndex = 0;
            this.lbArticulos.Text = "Articulos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1456, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarRegistroToolStripMenuItem,
            this.agregarRegistroToolStripMenuItem,
            this.modificarRegistroToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // borrarRegistroToolStripMenuItem
            // 
            this.borrarRegistroToolStripMenuItem.Name = "borrarRegistroToolStripMenuItem";
            this.borrarRegistroToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.borrarRegistroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.borrarRegistroToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.borrarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            // 
            // agregarRegistroToolStripMenuItem
            // 
            this.agregarRegistroToolStripMenuItem.Name = "agregarRegistroToolStripMenuItem";
            this.agregarRegistroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.agregarRegistroToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.agregarRegistroToolStripMenuItem.Text = "Agregar Registro";
            // 
            // modificarRegistroToolStripMenuItem
            // 
            this.modificarRegistroToolStripMenuItem.Name = "modificarRegistroToolStripMenuItem";
            this.modificarRegistroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modificarRegistroToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.modificarRegistroToolStripMenuItem.Text = "Modificar Registro";
            this.modificarRegistroToolStripMenuItem.Click += new System.EventHandler(this.modificarRegistroToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(14, 546);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 107);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(44, 546);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.Eliminar,
            this.tsbModificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 93);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = global::Actividad2.Properties.Resources.add;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(28, 24);
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eliminar.Image = global::Actividad2.Properties.Resources.trash_;
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(28, 24);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = global::Actividad2.Properties.Resources.modify2;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(28, 24);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackColor = System.Drawing.Color.White;
            this.pbxArticulo.Location = new System.Drawing.Point(1075, 107);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(345, 263);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(1071, 389);
            this.lbCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(54, 16);
            this.lbCode.TabIndex = 7;
            this.lbCode.Text = "Codigo:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(1071, 431);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 16);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Nombre:";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(1071, 469);
            this.lbBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(48, 16);
            this.lbBrand.TabIndex = 9;
            this.lbBrand.Text = "Marca:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(1071, 512);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(69, 16);
            this.lbCategory.TabIndex = 10;
            this.lbCategory.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1071, 556);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción:";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(1189, 385);
            this.tbCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(231, 22);
            this.tbCode.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(1189, 427);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(231, 22);
            this.tbName.TabIndex = 14;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(1189, 470);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.ReadOnly = true;
            this.tbBrand.Size = new System.Drawing.Size(231, 22);
            this.tbBrand.TabIndex = 15;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(1189, 508);
            this.tbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(231, 22);
            this.tbCategory.TabIndex = 16;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(1075, 590);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescription.MinimumSize = new System.Drawing.Size(231, 100);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(345, 100);
            this.tbDescription.TabIndex = 17;
            // 
            // lbBuscarPor
            // 
            this.lbBuscarPor.AutoSize = true;
            this.lbBuscarPor.Location = new System.Drawing.Point(53, 78);
            this.lbBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuscarPor.Name = "lbBuscarPor";
            this.lbBuscarPor.Size = new System.Drawing.Size(75, 16);
            this.lbBuscarPor.TabIndex = 7;
            this.lbBuscarPor.Text = "Buscar por:";
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.Location = new System.Drawing.Point(309, 78);
            this.lbCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(52, 16);
            this.lbCriterio.TabIndex = 10;
            this.lbCriterio.Text = "Criterio:";
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(361, 74);
            this.cbCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(135, 24);
            this.cbCriterio.TabIndex = 11;
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Location = new System.Drawing.Point(143, 74);
            this.cbBuscarPor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(135, 24);
            this.cbBuscarPor.TabIndex = 9;
            this.cbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cbBuscarPor_SelectedIndexChanged);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(523, 79);
            this.lbFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(43, 16);
            this.lbFiltrar.TabIndex = 12;
            this.lbFiltrar.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(577, 75);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(268, 22);
            this.txtFiltro.TabIndex = 13;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Thistle;
            this.btBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btBuscar.Location = new System.Drawing.Point(860, 70);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(127, 32);
            this.btBuscar.TabIndex = 14;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lbLimpiarFiltro
            // 
            this.lbLimpiarFiltro.BackColor = System.Drawing.Color.Thistle;
            this.lbLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimpiarFiltro.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbLimpiarFiltro.Location = new System.Drawing.Point(860, 661);
            this.lbLimpiarFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLimpiarFiltro.Name = "lbLimpiarFiltro";
            this.lbLimpiarFiltro.Size = new System.Drawing.Size(127, 32);
            this.lbLimpiarFiltro.TabIndex = 15;
            this.lbLimpiarFiltro.Text = "Limpiar filtro";
            this.lbLimpiarFiltro.UseVisualStyleBackColor = false;
            this.lbLimpiarFiltro.Click += new System.EventHandler(this.lbLimpiarFiltro_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1456, 787);
            this.Controls.Add(this.lbLimpiarFiltro);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.lbCriterio);
            this.Controls.Add(this.cbBuscarPor);
            this.Controls.Add(this.lbBuscarPor);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.lbArticulos);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1474, 834);
            this.MinimumSize = new System.Drawing.Size(1474, 834);
            this.Name = "frmArticulos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Label lbArticulos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.Label lbBuscarPor;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button lbLimpiarFiltro;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbDescription;
    }
}

