namespace sortstring.Views
{
    partial class Sortstring
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            input = new TextBox();
            inputlabel = new Label();
            selection = new ComboBox();
            select = new Label();
            output = new Label();
            sort = new Button();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(110, 12);
            input.Name = "input";
            input.Size = new Size(166, 23);
            input.TabIndex = 0;
            // 
            // inputlabel
            // 
            inputlabel.AutoSize = true;
            inputlabel.Location = new Point(34, 15);
            inputlabel.Name = "input";
            inputlabel.Size = new Size(70, 15);
            inputlabel.TabIndex = 1;
            inputlabel.Text = "Enter string:";
            // 
            // selection
            // 
            selection.FormattingEnabled = true;
            selection.Location = new Point(110, 41);
            selection.Name = "selection";
            selection.Size = new Size(166, 23);
            selection.TabIndex = 2;
            // 
            // select
            // 
            select.AutoSize = true;
            select.Location = new Point(34, 44);
            select.Name = "select";
            select.Size = new Size(38, 15);
            select.TabIndex = 3;
            select.Text = "Select";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(34, 123);
            output.Name = "output";
            output.Size = new Size(200, 45);
            output.TabIndex = 4;
            output.Text = "Output";
            // 
            // sort
            // 
            sort.Location = new Point(110, 70);
            sort.Name = "sort";
            sort.Size = new Size(166, 23);
            sort.TabIndex = 5;
            sort.Text = "Sort";
            sort.UseVisualStyleBackColor = true;
            // 
            // Sortstring
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 200);
            Controls.Add(sort);
            Controls.Add(output);
            Controls.Add(select);
            Controls.Add(selection);
            Controls.Add(input);
            Controls.Add(inputlabel);
            Name = "Sortstring";
            Text = "Sort string";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox input;
        private Label inputlabel;
        private ComboBox selection;
        private Label select;
        private Label output;
        private Button sort;
    }
}
