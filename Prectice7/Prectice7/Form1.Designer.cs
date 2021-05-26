namespace Prectice7
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.buttonForCreate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxForResult = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 35);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(674, 253);
      this.dataGridView1.TabIndex = 0;
      // 
      // buttonForCreate
      // 
      this.buttonForCreate.Location = new System.Drawing.Point(88, 303);
      this.buttonForCreate.Name = "buttonForCreate";
      this.buttonForCreate.Size = new System.Drawing.Size(145, 24);
      this.buttonForCreate.TabIndex = 1;
      this.buttonForCreate.Text = "Заполнение массива";
      this.buttonForCreate.UseVisualStyleBackColor = true;
      this.buttonForCreate.Click += new System.EventHandler(this.buttonForCreate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(386, 309);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Результат:";
      // 
      // textBoxForResult
      // 
      this.textBoxForResult.Location = new System.Drawing.Point(451, 306);
      this.textBoxForResult.Name = "textBoxForResult";
      this.textBoxForResult.Size = new System.Drawing.Size(131, 20);
      this.textBoxForResult.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(701, 348);
      this.Controls.Add(this.textBoxForResult);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonForCreate);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button buttonForCreate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxForResult;
  }
}

