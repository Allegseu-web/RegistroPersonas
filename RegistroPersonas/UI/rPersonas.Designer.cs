
namespace RegistroPersonas.UI
{
    public partial class rPersonas
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
            this.PersonaIdTextBox = new System.Windows.Forms.TextBox();
            this.PersonaId = new System.Windows.Forms.Label();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.NombreConctacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumeroContactoTextBox = new System.Windows.Forms.TextBox();
            this.AñadirButtom = new System.Windows.Forms.Button();
            this.NuevoButtom = new System.Windows.Forms.Button();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.EliminarButtom = new System.Windows.Forms.Button();
            this.ContactosDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ContactosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaIdTextBox
            // 
            this.PersonaIdTextBox.Location = new System.Drawing.Point(99, 42);
            this.PersonaIdTextBox.Name = "PersonaIdTextBox";
            this.PersonaIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.PersonaIdTextBox.TabIndex = 0;
            // 
            // PersonaId
            // 
            this.PersonaId.AutoSize = true;
            this.PersonaId.Location = new System.Drawing.Point(25, 45);
            this.PersonaId.Name = "PersonaId";
            this.PersonaId.Size = new System.Drawing.Size(59, 15);
            this.PersonaId.TabIndex = 1;
            this.PersonaId.Text = "PersonaId";
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Location = new System.Drawing.Point(222, 42);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(75, 23);
            this.BuscarButtom.TabIndex = 2;
            this.BuscarButtom.Text = "Buscar";
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(99, 95);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 23);
            this.NombreTextBox.TabIndex = 4;
            // 
            // NombreConctacto
            // 
            this.NombreConctacto.Location = new System.Drawing.Point(157, 162);
            this.NombreConctacto.Name = "NombreConctacto";
            this.NombreConctacto.Size = new System.Drawing.Size(164, 23);
            this.NombreConctacto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero Contacto";
            // 
            // NumeroContactoTextBox
            // 
            this.NumeroContactoTextBox.Location = new System.Drawing.Point(469, 162);
            this.NumeroContactoTextBox.Name = "NumeroContactoTextBox";
            this.NumeroContactoTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumeroContactoTextBox.TabIndex = 9;
            // 
            // AñadirButtom
            // 
            this.AñadirButtom.Location = new System.Drawing.Point(618, 161);
            this.AñadirButtom.Name = "AñadirButtom";
            this.AñadirButtom.Size = new System.Drawing.Size(75, 23);
            this.AñadirButtom.TabIndex = 10;
            this.AñadirButtom.Text = "Añadir";
            this.AñadirButtom.UseVisualStyleBackColor = true;
            this.AñadirButtom.Click += new System.EventHandler(this.AñadirButtom_Click);
            // 
            // NuevoButtom
            // 
            this.NuevoButtom.Location = new System.Drawing.Point(157, 415);
            this.NuevoButtom.Name = "NuevoButtom";
            this.NuevoButtom.Size = new System.Drawing.Size(75, 23);
            this.NuevoButtom.TabIndex = 11;
            this.NuevoButtom.Text = "Nuevo";
            this.NuevoButtom.UseVisualStyleBackColor = true;
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.Location = new System.Drawing.Point(268, 415);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(75, 23);
            this.GuardarButtom.TabIndex = 12;
            this.GuardarButtom.Text = "Guardar";
            this.GuardarButtom.UseVisualStyleBackColor = true;
            this.GuardarButtom.Click += new System.EventHandler(this.GuardarButtom_Click);
            // 
            // EliminarButtom
            // 
            this.EliminarButtom.Location = new System.Drawing.Point(394, 415);
            this.EliminarButtom.Name = "EliminarButtom";
            this.EliminarButtom.Size = new System.Drawing.Size(75, 23);
            this.EliminarButtom.TabIndex = 13;
            this.EliminarButtom.Text = "Eliminar";
            this.EliminarButtom.UseVisualStyleBackColor = true;
            this.EliminarButtom.Click += new System.EventHandler(this.EliminarButtom_Click);
            // 
            // ContactosDataGrid
            // 
            this.ContactosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactosDataGrid.Location = new System.Drawing.Point(37, 209);
            this.ContactosDataGrid.Name = "ContactosDataGrid";
            this.ContactosDataGrid.RowTemplate.Height = 25;
            this.ContactosDataGrid.Size = new System.Drawing.Size(656, 182);
            this.ContactosDataGrid.TabIndex = 14;
            // 
            // rPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContactosDataGrid);
            this.Controls.Add(this.EliminarButtom);
            this.Controls.Add(this.GuardarButtom);
            this.Controls.Add(this.NuevoButtom);
            this.Controls.Add(this.AñadirButtom);
            this.Controls.Add(this.NumeroContactoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreConctacto);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.PersonaId);
            this.Controls.Add(this.PersonaIdTextBox);
            this.Name = "rPersonas";
            this.Text = "Guardar";
            this.Load += new System.EventHandler(this.rPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactosDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PersonaIdTextBox;
        private System.Windows.Forms.Label PersonaId;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox NombreConctacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumeroContactoTextBox;
        private System.Windows.Forms.Button AñadirButtom;
        private System.Windows.Forms.Button NuevoButtom;
        private System.Windows.Forms.Button GuardarButtom;
        private System.Windows.Forms.Button EliminarButtom;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.DataGridView ContactoDataGrid;
        private System.Windows.Forms.DataGridView ContactosDataGrid;
    }
}