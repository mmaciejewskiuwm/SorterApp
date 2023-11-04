namespace AidsProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxLiczba_TextChanged(object sender, EventArgs e)
        {

        }
        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }
        string ConvertIntToString(int[] tab)
        {
            string napis = "";
            for (int i = 0;i < tab.Length;i++)
            {
                napis += tab[i].ToString();
                napis += " ";
            }
            return napis;
        }

        private void btSB_Click(object sender, EventArgs e)
        {
            try
            {
                int[] SortedList = BubbleSort(Convert(tbxLiczba.Text));
                tbxWynik.Text = ConvertIntToString(SortedList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("z�y format liczby musza byc oddzielone spacja");
            }
        }
        int[] BubbleSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                for (int j = 0; j < tab.Length - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            return tab;

        }

        private void tbxWynik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}