namespace Praсtiсe4
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelForX = new System.Windows.Forms.Label();
      this.textBoxForX = new System.Windows.Forms.TextBox();
      this.textBoxForCalculation = new System.Windows.Forms.TextBox();
      this.buttonCalculation = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelForX
      // 
      this.labelForX.AutoSize = true;
      this.labelForX.Location = new System.Drawing.Point(35, 56);
      this.labelForX.Name = "labelForX";
      this.labelForX.Size = new System.Drawing.Size(57, 13);
      this.labelForX.TabIndex = 0;
      this.labelForX.Text = "Введите х";
      // 
      // textBoxForX
      // 
      this.textBoxForX.Location = new System.Drawing.Point(98, 53);
      this.textBoxForX.Name = "textBoxForX";
      this.textBoxForX.Size = new System.Drawing.Size(351, 20);
      this.textBoxForX.TabIndex = 1;
      // 
      // textBoxForCalculation
      // 
      this.textBoxForCalculation.Location = new System.Drawing.Point(98, 93);
      this.textBoxForCalculation.Multiline = true;
      this.textBoxForCalculation.Name = "textBoxForCalculation";
      this.textBoxForCalculation.Size = new System.Drawing.Size(351, 180);
      this.textBoxForCalculation.TabIndex = 2;
      // 
      // buttonCalculation
      // 
      this.buttonCalculation.Location = new System.Drawing.Point(464, 244);
      this.buttonCalculation.Name = "buttonCalculation";
      this.buttonCalculation.Size = new System.Drawing.Size(87, 29);
      this.buttonCalculation.TabIndex = 3;
      this.buttonCalculation.Text = "Расчет";
      this.buttonCalculation.UseVisualStyleBackColor = true;
      this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(563, 308);
      this.Controls.Add(this.buttonCalculation);
      this.Controls.Add(this.textBoxForCalculation);
      this.Controls.Add(this.textBoxForX);
      this.Controls.Add(this.labelForX);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelForX;
    private System.Windows.Forms.TextBox textBoxForX;
    private System.Windows.Forms.TextBox textBoxForCalculation;
    private System.Windows.Forms.Button buttonCalculation;
  }
}

