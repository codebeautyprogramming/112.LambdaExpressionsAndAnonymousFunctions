namespace CookBook.UI
{
    partial class RecipeTypesForm
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
            label1 = new Label();
            NewTypeTxt = new TextBox();
            RecipeTypesLbx = new ListBox();
            AddRecipeTypesBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // NewTypeTxt
            // 
            NewTypeTxt.Location = new Point(103, 35);
            NewTypeTxt.Name = "NewTypeTxt";
            NewTypeTxt.Size = new Size(210, 35);
            NewTypeTxt.TabIndex = 1;
            // 
            // RecipeTypesLbx
            // 
            RecipeTypesLbx.FormattingEnabled = true;
            RecipeTypesLbx.ItemHeight = 30;
            RecipeTypesLbx.Location = new Point(29, 95);
            RecipeTypesLbx.Name = "RecipeTypesLbx";
            RecipeTypesLbx.Size = new Size(284, 304);
            RecipeTypesLbx.TabIndex = 2;
            // 
            // AddRecipeTypesBtn
            // 
            AddRecipeTypesBtn.Location = new Point(29, 424);
            AddRecipeTypesBtn.Name = "AddRecipeTypesBtn";
            AddRecipeTypesBtn.Size = new Size(284, 57);
            AddRecipeTypesBtn.TabIndex = 3;
            AddRecipeTypesBtn.Text = "Add";
            AddRecipeTypesBtn.UseVisualStyleBackColor = true;
            AddRecipeTypesBtn.Click += AddRecipeTypesBtn_Click;
            // 
            // RecipeTypesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 512);
            Controls.Add(AddRecipeTypesBtn);
            Controls.Add(RecipeTypesLbx);
            Controls.Add(NewTypeTxt);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeTypesForm";
            Text = "RecipeTypesForm";
            Load += RecipeTypesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewTypeTxt;
        private ListBox RecipeTypesLbx;
        private Button AddRecipeTypesBtn;
    }
}