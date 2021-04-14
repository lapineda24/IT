namespace Practice6
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
      this.textForCreate = new System.Windows.Forms.TextBox();
      this.textForFind = new System.Windows.Forms.TextBox();
      this.buttonForCreate = new System.Windows.Forms.Button();
      this.buttonForFind = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textForCreate
      // 
      this.textForCreate.Location = new System.Drawing.Point(82, 26);
      this.textForCreate.Multiline = true;
      this.textForCreate.Name = "textForCreate";
      this.textForCreate.Size = new System.Drawing.Size(212, 260);
      this.textForCreate.TabIndex = 0;
      // 
      // textForFind
      // 
      this.textForFind.Location = new System.Drawing.Point(421, 26);
      this.textForFind.Multiline = true;
      this.textForFind.Name = "textForFind";
      this.textForFind.Size = new System.Drawing.Size(212, 260);
      this.textForFind.TabIndex = 1;
      // 
      // buttonForCreate
      // 
      this.buttonForCreate.Location = new System.Drawing.Point(135, 311);
      this.buttonForCreate.Name = "buttonForCreate";
      this.buttonForCreate.Size = new System.Drawing.Size(104, 26);
      this.buttonForCreate.TabIndex = 2;
      this.buttonForCreate.Text = "Заполнить";
      this.buttonForCreate.UseVisualStyleBackColor = true;
      this.buttonForCreate.Click += new System.EventHandler(this.buttonForCreate_Click);
      // 
      // buttonForFind
      // 
      this.buttonForFind.Location = new System.Drawing.Point(488, 311);
      this.buttonForFind.Name = "buttonForFind";
      this.buttonForFind.Size = new System.Drawing.Size(104, 26);
      this.buttonForFind.TabIndex = 3;
      this.buttonForFind.Text = "Поиск";
      this.buttonForFind.UseVisualStyleBackColor = true;
      this.buttonForFind.Click += new System.EventHandler(this.buttonForFind_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(132, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(99, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Исходный массив";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(473, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(119, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Найденные элементы";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(707, 362);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonForFind);
      this.Controls.Add(this.buttonForCreate);
      this.Controls.Add(this.textForFind);
      this.Controls.Add(this.textForCreate);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textForCreate;
    private System.Windows.Forms.TextBox textForFind;
    private System.Windows.Forms.Button buttonForCreate;
    private System.Windows.Forms.Button buttonForFind;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

