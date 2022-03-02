namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Shown += Form1_Shown;
            btnExit.Click += BtnExit_Click;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            //this.SuspendLayout();
            this.WindowState = FormWindowState.Maximized;
            btnExit.Location = new Point(this.Width / 2 - (btnExit.Width / 2), this.Height / 2 - (btnExit.Height / 2));
            //this.ResumeLayout(false);
            //throw new NotImplementedException();
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(this, "진짜 종료?", "확인", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }            
            //throw new NotImplementedException();
        }
    }
}