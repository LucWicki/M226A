namespace M226A_B01_1b
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSeiteA = new System.Windows.Forms.TextBox();
      this.txtSeiteB = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.btnStatic = new System.Windows.Forms.Button();
      this.txtFlaeche = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(180, 223);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(26, 29);
      this.label1.TabIndex = 0;
      this.label1.Text = "a";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(180, 279);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 29);
      this.label2.TabIndex = 1;
      this.label2.Text = "b";
      // 
      // txtSeiteA
      // 
      this.txtSeiteA.Location = new System.Drawing.Point(264, 223);
      this.txtSeiteA.Name = "txtSeiteA";
      this.txtSeiteA.Size = new System.Drawing.Size(175, 35);
      this.txtSeiteA.TabIndex = 2;
      // 
      // txtSeiteB
      // 
      this.txtSeiteB.Location = new System.Drawing.Point(264, 273);
      this.txtSeiteB.Name = "txtSeiteB";
      this.txtSeiteB.Size = new System.Drawing.Size(175, 35);
      this.txtSeiteB.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(553, 201);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(278, 51);
      this.button1.TabIndex = 4;
      this.button1.Text = "berechne m. Objekt";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnStatic
      // 
      this.btnStatic.Location = new System.Drawing.Point(553, 268);
      this.btnStatic.Name = "btnStatic";
      this.btnStatic.Size = new System.Drawing.Size(278, 55);
      this.btnStatic.TabIndex = 5;
      this.btnStatic.Text = "berechne statisch";
      this.btnStatic.UseVisualStyleBackColor = true;
      this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
      // 
      // txtFlaeche
      // 
      this.txtFlaeche.Location = new System.Drawing.Point(1080, 241);
      this.txtFlaeche.Name = "txtFlaeche";
      this.txtFlaeche.Size = new System.Drawing.Size(100, 35);
      this.txtFlaeche.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(943, 241);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 29);
      this.label3.TabIndex = 7;
      this.label3.Text = "Fläche";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1539, 714);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtFlaeche);
      this.Controls.Add(this.btnStatic);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtSeiteB);
      this.Controls.Add(this.txtSeiteA);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSeiteA;
    private System.Windows.Forms.TextBox txtSeiteB;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnStatic;
    private System.Windows.Forms.TextBox txtFlaeche;
    private System.Windows.Forms.Label label3;
  }
}

