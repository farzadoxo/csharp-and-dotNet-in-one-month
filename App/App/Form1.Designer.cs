namespace App;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        Showbtn = new Button
        {
            Text = "SHOW DATABASE",
            Location = new Point(20,20)
        };

        Addbtn = new Button
        {
            Text = "ADD TO DATABASE",
            Location = new Point(50,50)
        };

        dbdgv = new DataGridView
        {
            Location = new Point(100,100),
            Size = new Size(400,400)
        };

        Nametxt = new TextBox
        {
            Location = new Point(130,50)
        };

        Emailtxt = new TextBox
        {
            Location = new Point(250,50)
        };

        Idtxt = new TextBox
        {
            Location = new Point(100,20)
        };


        Controls.Add(Showbtn);
        Controls.Add(Addbtn);
        Controls.Add(dbdgv);
        Controls.Add(Nametxt);
        Controls.Add(Emailtxt);
        Controls.Add(Idtxt);
    }


private Button Showbtn;
private Button Addbtn;
private DataGridView dbdgv;
private TextBox Nametxt;
private TextBox Emailtxt;
private TextBox Idtxt;


    #endregion
}
