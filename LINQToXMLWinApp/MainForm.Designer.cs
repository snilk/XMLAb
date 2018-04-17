namespace LINQToXMLWinApp
{
    partial class MainForm
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
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.AddInventoryItem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMakeColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLookUpColors = new System.Windows.Forms.Button();
            this.btnXmlToBase = new System.Windows.Forms.Button();
            this.btnBaseToXml = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxChangeId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxChangedColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxDeleteCarById = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBoxOldNode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChangeNode = new System.Windows.Forms.Button();
            this.AddInventoryItem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(69, 48);
            this.txtInventory.Multiline = true;
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInventory.Size = new System.Drawing.Size(431, 314);
            this.txtInventory.TabIndex = 0;
            // 
            // AddInventoryItem
            // 
            this.AddInventoryItem.Controls.Add(this.label3);
            this.AddInventoryItem.Controls.Add(this.label2);
            this.AddInventoryItem.Controls.Add(this.label1);
            this.AddInventoryItem.Controls.Add(this.txtMake);
            this.AddInventoryItem.Controls.Add(this.txtColor);
            this.AddInventoryItem.Controls.Add(this.txtPetName);
            this.AddInventoryItem.Controls.Add(this.btnAddNewItem);
            this.AddInventoryItem.Location = new System.Drawing.Point(564, 48);
            this.AddInventoryItem.Name = "AddInventoryItem";
            this.AddInventoryItem.Size = new System.Drawing.Size(517, 198);
            this.AddInventoryItem.TabIndex = 1;
            this.AddInventoryItem.TabStop = false;
            this.AddInventoryItem.Text = "AddInventoryItem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pet Name";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(140, 33);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(292, 22);
            this.txtMake.TabIndex = 5;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(140, 77);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(292, 22);
            this.txtColor.TabIndex = 4;
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(140, 126);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(292, 22);
            this.txtPetName.TabIndex = 3;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(411, 175);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewItem.TabIndex = 2;
            this.btnAddNewItem.Text = "Add";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMakeColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLookUpColors);
            this.groupBox1.Location = new System.Drawing.Point(564, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Look Up Color To Make";
            // 
            // txtMakeColor
            // 
            this.txtMakeColor.Location = new System.Drawing.Point(202, 40);
            this.txtMakeColor.Name = "txtMakeColor";
            this.txtMakeColor.Size = new System.Drawing.Size(230, 22);
            this.txtMakeColor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Make To Look Up";
            // 
            // btnLookUpColors
            // 
            this.btnLookUpColors.Location = new System.Drawing.Point(335, 77);
            this.btnLookUpColors.Name = "btnLookUpColors";
            this.btnLookUpColors.Size = new System.Drawing.Size(151, 23);
            this.btnLookUpColors.TabIndex = 0;
            this.btnLookUpColors.Text = "Look Up Colors";
            this.btnLookUpColors.UseVisualStyleBackColor = true;
            this.btnLookUpColors.Click += new System.EventHandler(this.btnLookUpColors_Click);
            // 
            // btnXmlToBase
            // 
            this.btnXmlToBase.Location = new System.Drawing.Point(331, 368);
            this.btnXmlToBase.Name = "btnXmlToBase";
            this.btnXmlToBase.Size = new System.Drawing.Size(169, 23);
            this.btnXmlToBase.TabIndex = 3;
            this.btnXmlToBase.Text = "XmlToBase";
            this.btnXmlToBase.UseVisualStyleBackColor = true;
            this.btnXmlToBase.Click += new System.EventHandler(this.btnXmlToBase_Click);
            // 
            // btnBaseToXml
            // 
            this.btnBaseToXml.Location = new System.Drawing.Point(69, 368);
            this.btnBaseToXml.Name = "btnBaseToXml";
            this.btnBaseToXml.Size = new System.Drawing.Size(143, 23);
            this.btnBaseToXml.TabIndex = 4;
            this.btnBaseToXml.Text = "BaseToXml";
            this.btnBaseToXml.UseVisualStyleBackColor = true;
            this.btnBaseToXml.Click += new System.EventHandler(this.btnBaseToXml_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxChangeId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBoxChangedColor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnChangeColor);
            this.groupBox2.Location = new System.Drawing.Point(564, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Color by ID";
            // 
            // txtBoxChangeId
            // 
            this.txtBoxChangeId.Location = new System.Drawing.Point(202, 56);
            this.txtBoxChangeId.Name = "txtBoxChangeId";
            this.txtBoxChangeId.Size = new System.Drawing.Size(230, 22);
            this.txtBoxChangeId.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID of changed color";
            // 
            // txtBoxChangedColor
            // 
            this.txtBoxChangedColor.Location = new System.Drawing.Point(202, 85);
            this.txtBoxChangedColor.Name = "txtBoxChangedColor";
            this.txtBoxChangedColor.Size = new System.Drawing.Size(230, 22);
            this.txtBoxChangedColor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Changed Color";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(335, 128);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(151, 23);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxDeleteCarById);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(41, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete car by id";
            // 
            // txtBoxDeleteCarById
            // 
            this.txtBoxDeleteCarById.Location = new System.Drawing.Point(202, 40);
            this.txtBoxDeleteCarById.Name = "txtBoxDeleteCarById";
            this.txtBoxDeleteCarById.Size = new System.Drawing.Size(230, 22);
            this.txtBoxDeleteCarById.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Car id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxOldNode);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnChangeNode);
            this.groupBox4.Location = new System.Drawing.Point(41, 589);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Change Node";
            // 
            // txtBoxOldNode
            // 
            this.txtBoxOldNode.Location = new System.Drawing.Point(202, 40);
            this.txtBoxOldNode.Name = "txtBoxOldNode";
            this.txtBoxOldNode.Size = new System.Drawing.Size(230, 22);
            this.txtBoxOldNode.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Old name of node";
            // 
            // btnChangeNode
            // 
            this.btnChangeNode.Location = new System.Drawing.Point(335, 77);
            this.btnChangeNode.Name = "btnChangeNode";
            this.btnChangeNode.Size = new System.Drawing.Size(151, 23);
            this.btnChangeNode.TabIndex = 0;
            this.btnChangeNode.Text = "Change";
            this.btnChangeNode.UseVisualStyleBackColor = true;
            this.btnChangeNode.Click += new System.EventHandler(this.btnChangeNode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 731);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBaseToXml);
            this.Controls.Add(this.btnXmlToBase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddInventoryItem);
            this.Controls.Add(this.txtInventory);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddInventoryItem.ResumeLayout(false);
            this.AddInventoryItem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.GroupBox AddInventoryItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMakeColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLookUpColors;
        private System.Windows.Forms.Button btnXmlToBase;
        private System.Windows.Forms.Button btnBaseToXml;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxChangeId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxChangedColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxDeleteCarById;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxOldNode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChangeNode;
    }
}

