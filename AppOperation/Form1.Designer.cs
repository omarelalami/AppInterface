namespace AppOperation
{
    partial class Form1
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
            this.btn_ajout = new System.Windows.Forms.Button();
            this.btn_ann = new System.Windows.Forms.Button();
            this.btn_supp = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_eng = new System.Windows.Forms.Button();
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.txtbox_met = new System.Windows.Forms.TextBox();
            this.txtbox_prnm = new System.Windows.Forms.TextBox();
            this.id_list = new System.Windows.Forms.ComboBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_met = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prnm = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(39, 305);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(121, 39);
            this.btn_ajout.TabIndex = 0;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // btn_ann
            // 
            this.btn_ann.Location = new System.Drawing.Point(462, 305);
            this.btn_ann.Name = "btn_ann";
            this.btn_ann.Size = new System.Drawing.Size(121, 39);
            this.btn_ann.TabIndex = 1;
            this.btn_ann.Text = "Annuler";
            this.btn_ann.UseVisualStyleBackColor = true;
            this.btn_ann.Click += new System.EventHandler(this.btn_ann_Click);
            // 
            // btn_supp
            // 
            this.btn_supp.Location = new System.Drawing.Point(320, 305);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(121, 39);
            this.btn_supp.TabIndex = 2;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(179, 305);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(121, 39);
            this.btn_mod.TabIndex = 3;
            this.btn_mod.Text = "Modifier";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_eng
            // 
            this.btn_eng.Location = new System.Drawing.Point(603, 305);
            this.btn_eng.Name = "btn_eng";
            this.btn_eng.Size = new System.Drawing.Size(121, 39);
            this.btn_eng.TabIndex = 4;
            this.btn_eng.Text = "Enregistrer";
            this.btn_eng.UseVisualStyleBackColor = true;
            this.btn_eng.Click += new System.EventHandler(this.btn_eng_Click);
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Location = new System.Drawing.Point(188, 111);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(146, 20);
            this.txtbox_nom.TabIndex = 5;
            // 
            // txtbox_met
            // 
            this.txtbox_met.Location = new System.Drawing.Point(188, 195);
            this.txtbox_met.Name = "txtbox_met";
            this.txtbox_met.Size = new System.Drawing.Size(146, 20);
            this.txtbox_met.TabIndex = 6;
            // 
            // txtbox_prnm
            // 
            this.txtbox_prnm.Location = new System.Drawing.Point(188, 154);
            this.txtbox_prnm.Name = "txtbox_prnm";
            this.txtbox_prnm.Size = new System.Drawing.Size(146, 20);
            this.txtbox_prnm.TabIndex = 7;
            // 
            // id_list
            // 
            this.id_list.FormattingEnabled = true;
            this.id_list.Location = new System.Drawing.Point(188, 72);
            this.id_list.Name = "id_list";
            this.id_list.Size = new System.Drawing.Size(146, 21);
            this.id_list.TabIndex = 8;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(103, 75);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "ID";
            // 
            // label_met
            // 
            this.label_met.AutoSize = true;
            this.label_met.Location = new System.Drawing.Point(103, 198);
            this.label_met.Name = "label_met";
            this.label_met.Size = new System.Drawing.Size(36, 13);
            this.label_met.TabIndex = 10;
            this.label_met.Text = "Métier";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(103, 157);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(29, 13);
            this.label_nom.TabIndex = 11;
            this.label_nom.Text = "Nom";
            // 
            // label_prnm
            // 
            this.label_prnm.AutoSize = true;
            this.label_prnm.Location = new System.Drawing.Point(103, 114);
            this.label_prnm.Name = "label_prnm";
            this.label_prnm.Size = new System.Drawing.Size(43, 13);
            this.label_prnm.TabIndex = 12;
            this.label_prnm.Text = "Prénom";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(431, 264);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 36);
            this.message.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 370);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label_prnm);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_met);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.id_list);
            this.Controls.Add(this.txtbox_prnm);
            this.Controls.Add(this.txtbox_met);
            this.Controls.Add(this.txtbox_nom);
            this.Controls.Add(this.btn_eng);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.btn_ann);
            this.Controls.Add(this.btn_ajout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        bool mod = false;  ///Des Variables pour determiner les états en cours de enregistrement
        bool supp = false;
        bool ajout = false;

        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button btn_ann;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_eng;
        private System.Windows.Forms.TextBox txtbox_nom;
        private System.Windows.Forms.TextBox txtbox_met;
        private System.Windows.Forms.TextBox txtbox_prnm;
        private System.Windows.Forms.ComboBox id_list;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_met;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prnm;
        private System.Windows.Forms.Label message;
    }
}

