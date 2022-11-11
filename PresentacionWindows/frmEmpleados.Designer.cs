namespace PresentacionWindows
{
    partial class frmEmpleados
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
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnAgregarDpto = new System.Windows.Forms.Button();
            this.txtNombreDpto = new System.Windows.Forms.TextBox();
            this.txtIdDpto = new System.Windows.Forms.TextBox();
            this.lblNombreDpto = new System.Windows.Forms.Label();
            this.lblIdDepartamento = new System.Windows.Forms.Label();
            this.gridEmpleadoXDpto = new System.Windows.Forms.DataGridView();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadoXDpto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(-6, 265);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(204, 28);
            this.btnAgregarEmpleado.TabIndex = 0;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(44, 151);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 177);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(16, 207);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(21, 234);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 4;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(69, 148);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpleado.TabIndex = 5;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(69, 174);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpleado.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(69, 200);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(69, 231);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 8;
            // 
            // btnAgregarDpto
            // 
            this.btnAgregarDpto.Location = new System.Drawing.Point(16, 91);
            this.btnAgregarDpto.Name = "btnAgregarDpto";
            this.btnAgregarDpto.Size = new System.Drawing.Size(204, 28);
            this.btnAgregarDpto.TabIndex = 9;
            this.btnAgregarDpto.Text = "Agregar Departamento";
            this.btnAgregarDpto.UseVisualStyleBackColor = true;
            this.btnAgregarDpto.Click += new System.EventHandler(this.btnAgregarDpto_Click);
            // 
            // txtNombreDpto
            // 
            this.txtNombreDpto.Location = new System.Drawing.Point(66, 58);
            this.txtNombreDpto.Name = "txtNombreDpto";
            this.txtNombreDpto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDpto.TabIndex = 15;
            // 
            // txtIdDpto
            // 
            this.txtIdDpto.Location = new System.Drawing.Point(66, 32);
            this.txtIdDpto.Name = "txtIdDpto";
            this.txtIdDpto.Size = new System.Drawing.Size(100, 20);
            this.txtIdDpto.TabIndex = 14;
            // 
            // lblNombreDpto
            // 
            this.lblNombreDpto.AutoSize = true;
            this.lblNombreDpto.Location = new System.Drawing.Point(13, 61);
            this.lblNombreDpto.Name = "lblNombreDpto";
            this.lblNombreDpto.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDpto.TabIndex = 11;
            this.lblNombreDpto.Text = "Nombre:";
            // 
            // lblIdDepartamento
            // 
            this.lblIdDepartamento.AutoSize = true;
            this.lblIdDepartamento.Location = new System.Drawing.Point(41, 35);
            this.lblIdDepartamento.Name = "lblIdDepartamento";
            this.lblIdDepartamento.Size = new System.Drawing.Size(19, 13);
            this.lblIdDepartamento.TabIndex = 10;
            this.lblIdDepartamento.Text = "Id:";
            // 
            // gridEmpleadoXDpto
            // 
            this.gridEmpleadoXDpto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadoXDpto.Location = new System.Drawing.Point(376, 14);
            this.gridEmpleadoXDpto.Name = "gridEmpleadoXDpto";
            this.gridEmpleadoXDpto.Size = new System.Drawing.Size(401, 150);
            this.gridEmpleadoXDpto.TabIndex = 16;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(621, 177);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(156, 27);
            this.btnMostrarLista.TabIndex = 17;
            this.btnMostrarLista.Text = "Mostrar Listado Empleados";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.gridEmpleadoXDpto);
            this.Controls.Add(this.txtNombreDpto);
            this.Controls.Add(this.txtIdDpto);
            this.Controls.Add(this.lblNombreDpto);
            this.Controls.Add(this.lblIdDepartamento);
            this.Controls.Add(this.btnAgregarDpto);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Name = "frmEmpleados";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadoXDpto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnAgregarDpto;
        private System.Windows.Forms.TextBox txtNombreDpto;
        private System.Windows.Forms.TextBox txtIdDpto;
        private System.Windows.Forms.Label lblNombreDpto;
        private System.Windows.Forms.Label lblIdDepartamento;
        private System.Windows.Forms.DataGridView gridEmpleadoXDpto;
        private System.Windows.Forms.Button btnMostrarLista;
    }
}

