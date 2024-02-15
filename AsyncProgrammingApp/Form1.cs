namespace AsyncProgrammingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            int n;
            //n = Cal();
            
            Task<int> task = new(Cal);
            task.Start();

            n = await task;

            MessageBox.Show($"Result : {n}");
        }

        private int Cal()
        {
            int total = 40;
            System.Threading.Thread.Sleep(3000);
            return total;
        }
    }
}
