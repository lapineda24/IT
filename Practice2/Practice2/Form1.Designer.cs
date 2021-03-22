namespace Practice2
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
      this.labelForCalculate = new System.Windows.Forms.Label();
      this.textBoxForX = new System.Windows.Forms.TextBox();
      this.textBoxForCalculate = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelForX
      // 
      this.labelForX.AutoSize = true;
      this.labelForX.Location = new System.Drawing.Point(81, 39);
      this.labelForX.Name = "labelForX";
      this.labelForX.Size = new System.Drawing.Size(107, 13);
      this.labelForX.TabIndex = 0;
      this.labelForX.Text = "Введите значение х";
      // 
      // labelForCalculate
      // 
      this.labelForCalculate.AutoSize = true;
      this.labelForCalculate.Location = new System.Drawing.Point(81, 98);
      this.labelForCalculate.Name = "labelForCalculate";
      this.labelForCalculate.Size = new System.Drawing.Size(189, 13);
      this.labelForCalculate.TabIndex = 1;
      this.labelForCalculate.Text = "Результат выполнения программы:";
      // 
      // textBoxForX
      // 
      this.textBoxForX.Location = new System.Drawing.Point(205, 36);
      this.textBoxForX.Name = "textBoxForX";
      this.textBoxForX.Size = new System.Drawing.Size(156, 20);
      this.textBoxForX.TabIndex = 2;
      // 
      // textBoxForCalculate
      // 
      this.textBoxForCalculate.Location = new System.Drawing.Point(87, 140);
      this.textBoxForCalculate.Multiline = true;
      this.textBoxForCalculate.Name = "textBoxForCalculate";
      this.textBoxForCalculate.Size = new System.Drawing.Size(274, 187);
      this.textBoxForCalculate.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(402, 293);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(92, 33);
      this.button1.TabIndex = 4;
      this.button1.Text = "Расчет";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(503, 360);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBoxForCalculate);
      this.Controls.Add(this.textBoxForX);
      this.Controls.Add(this.labelForCalculate);
      this.Controls.Add(this.labelForX);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelForX;
    private System.Windows.Forms.Label labelForCalculate;
    private System.Windows.Forms.TextBox textBoxForX;
    private System.Windows.Forms.TextBox textBoxForCalculate;
    private System.Windows.Forms.Button button1;
  }
}

