namespace _06._10._2023_uygulama3
{
    public partial class Form1 : Form
    {
        List<string>musteriler=new List<string>();
        List<string> musteriBilgileri=new List<string>();
        public Form1(List <string> musteriler, List <string>musteriBilgileri)
        {
            InitializeComponent();
            this.musteriler=musteriler;
            this.musteriBilgileri = musteriBilgileri;


        }



        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();


        }

        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(musteriBilgileri[lstMusteriler.SelectedIndex]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach(string musteri in musteriler)
            {
                lstMusteriler.Items.Add(musteri);
                
            }
            
        }
    }
}