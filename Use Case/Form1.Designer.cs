namespace Use_Case
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
            this.gBoxElements = new System.Windows.Forms.GroupBox();
            this.rBtLine = new System.Windows.Forms.RadioButton();
            this.rBtUseCase = new System.Windows.Forms.RadioButton();
            this.rBtActor = new System.Windows.Forms.RadioButton();
            this.gBoxModes = new System.Windows.Forms.GroupBox();
            this.rBtSelect = new System.Windows.Forms.RadioButton();
            this.rBtCreate = new System.Windows.Forms.RadioButton();
            this.pbUseCase = new System.Windows.Forms.PictureBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.gBoxElements.SuspendLayout();
            this.gBoxModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUseCase)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxElements
            // 
            this.gBoxElements.Controls.Add(this.rBtLine);
            this.gBoxElements.Controls.Add(this.rBtUseCase);
            this.gBoxElements.Controls.Add(this.rBtActor);
            this.gBoxElements.Location = new System.Drawing.Point(13, 13);
            this.gBoxElements.Name = "gBoxElements";
            this.gBoxElements.Size = new System.Drawing.Size(123, 110);
            this.gBoxElements.TabIndex = 0;
            this.gBoxElements.TabStop = false;
            this.gBoxElements.Text = "Elements";
            // 
            // rBtLine
            // 
            this.rBtLine.AutoSize = true;
            this.rBtLine.Location = new System.Drawing.Point(7, 77);
            this.rBtLine.Name = "rBtLine";
            this.rBtLine.Size = new System.Drawing.Size(56, 21);
            this.rBtLine.TabIndex = 2;
            this.rBtLine.TabStop = true;
            this.rBtLine.Text = "Line";
            this.rBtLine.UseVisualStyleBackColor = true;
            // 
            // rBtUseCase
            // 
            this.rBtUseCase.AutoSize = true;
            this.rBtUseCase.Location = new System.Drawing.Point(7, 50);
            this.rBtUseCase.Name = "rBtUseCase";
            this.rBtUseCase.Size = new System.Drawing.Size(90, 21);
            this.rBtUseCase.TabIndex = 1;
            this.rBtUseCase.TabStop = true;
            this.rBtUseCase.Text = "Use Case";
            this.rBtUseCase.UseVisualStyleBackColor = true;
            // 
            // rBtActor
            // 
            this.rBtActor.AutoSize = true;
            this.rBtActor.Location = new System.Drawing.Point(7, 22);
            this.rBtActor.Name = "rBtActor";
            this.rBtActor.Size = new System.Drawing.Size(62, 21);
            this.rBtActor.TabIndex = 0;
            this.rBtActor.TabStop = true;
            this.rBtActor.Text = "Actor";
            this.rBtActor.UseVisualStyleBackColor = true;
            // 
            // gBoxModes
            // 
            this.gBoxModes.Controls.Add(this.rBtSelect);
            this.gBoxModes.Controls.Add(this.rBtCreate);
            this.gBoxModes.Location = new System.Drawing.Point(142, 13);
            this.gBoxModes.Name = "gBoxModes";
            this.gBoxModes.Size = new System.Drawing.Size(83, 111);
            this.gBoxModes.TabIndex = 1;
            this.gBoxModes.TabStop = false;
            this.gBoxModes.Text = "Modes";
            // 
            // rBtSelect
            // 
            this.rBtSelect.AutoSize = true;
            this.rBtSelect.Location = new System.Drawing.Point(7, 50);
            this.rBtSelect.Name = "rBtSelect";
            this.rBtSelect.Size = new System.Drawing.Size(68, 21);
            this.rBtSelect.TabIndex = 1;
            this.rBtSelect.TabStop = true;
            this.rBtSelect.Text = "Select";
            this.rBtSelect.UseVisualStyleBackColor = true;
            // 
            // rBtCreate
            // 
            this.rBtCreate.AutoSize = true;
            this.rBtCreate.Location = new System.Drawing.Point(7, 22);
            this.rBtCreate.Name = "rBtCreate";
            this.rBtCreate.Size = new System.Drawing.Size(71, 21);
            this.rBtCreate.TabIndex = 0;
            this.rBtCreate.TabStop = true;
            this.rBtCreate.Text = "Create";
            this.rBtCreate.UseVisualStyleBackColor = true;
            // 
            // pbUseCase
            // 
            this.pbUseCase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbUseCase.Location = new System.Drawing.Point(13, 129);
            this.pbUseCase.Name = "pbUseCase";
            this.pbUseCase.Size = new System.Drawing.Size(725, 380);
            this.pbUseCase.TabIndex = 2;
            this.pbUseCase.TabStop = false;
            this.pbUseCase.Paint += new System.Windows.Forms.PaintEventHandler(this.pbUseCase_Paint);
            this.pbUseCase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbUseCase_MouseDown);
            this.pbUseCase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbUseCase_MouseMove);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(663, 13);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear all";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(663, 42);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 521);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.pbUseCase);
            this.Controls.Add(this.gBoxModes);
            this.Controls.Add(this.gBoxElements);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            this.gBoxElements.ResumeLayout(false);
            this.gBoxElements.PerformLayout();
            this.gBoxModes.ResumeLayout(false);
            this.gBoxModes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUseCase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxElements;
        private System.Windows.Forms.GroupBox gBoxModes;
        private System.Windows.Forms.PictureBox pbUseCase;
        private System.Windows.Forms.RadioButton rBtLine;
        private System.Windows.Forms.RadioButton rBtUseCase;
        private System.Windows.Forms.RadioButton rBtActor;
        private System.Windows.Forms.RadioButton rBtSelect;
        private System.Windows.Forms.RadioButton rBtCreate;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRemove;
    }
}

