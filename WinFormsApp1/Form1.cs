using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeForm();
            CreateInitialFile();
        }

        private void InitializeForm()
        {
            for (int i = 0; i < 50; i++)
            {
                cboNumber1.Items.Add(i.ToString());
                cboNumber2.Items.Add(i.ToString());
                chkLst1.Items.Add(i);
            }
            chkLst1.Visible = false; //Hide on initial load to make sure we have some values selected in dropdowns first.
        }

        private void CreateInitialFile()
        {
            if (!File.Exists("combinations.txt"))
            {
                MessageBox.Show("Combinations file not found, creating...");
                var fileContents = new StringBuilder();
                for (int num1 = 0; num1 < 50; num1++)
                {
                    for (int num2 = 0; num2 < 50; num2++) 
                    {
                        for (int num3 = 0; num3 < 50; num3++)
                        {
                            fileContents.AppendLine($"{num1} - {num2} - {num3} | unchecked");
                        }
                    }
                }
                File.WriteAllText("combinations.txt",fileContents.ToString());
            }
            
        }

        private void chkLst1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var num1 = cboNumber1.SelectedIndex;
            var num2 = cboNumber2.SelectedIndex;
            var num3 = e.Index;
            var isCheckedText = "unchecked";
            if (e.NewValue == CheckState.Checked) {
                isCheckedText = "checked";
            }
            

            IEnumerable<string> lines = File.ReadLines("combinations.txt");
            var stringbuilder = new StringBuilder();
            foreach (string line in lines) 
            {
                if (line.StartsWith($"{num1} - {num2} - {num3}"))
                {
                    stringbuilder.AppendLine($"{num1} - {num2} - {num3} | {isCheckedText}");
                }
                else
                {
                    stringbuilder.AppendLine(line);
                }
            }
            File.WriteAllText("combinations.txt",stringbuilder.ToString());

        }

        

        private void ShowCheckList(object sender, EventArgs e)
        {
            if (cboNumber1.SelectedIndex != -1 && cboNumber2.SelectedIndex != -1)
            {
                chkLst1.Visible = true;
                LoadData(cboNumber1.SelectedIndex, cboNumber2.SelectedIndex);
            }
            else 
            { 
                chkLst1.Visible=false;
            }

        }

        private void LoadData(int num1, int num2) 
        {
            for (int i = 0; i< 50; i++)
            {
                chkLst1.SetItemChecked(i, false);
            }
            IEnumerable<string> lines = File.ReadAllLines("combinations.txt");
            foreach (string line in lines)
            {
                if (line.StartsWith($"{num1} - {num2}"))
                {
                    var workingStr = line.Replace($"{num1} - {num2} - ", "");
                    var data = workingStr.Split(" | ");
                    var num3 = Convert.ToInt32(data[0]);
                    var isChecked = data[1];
                    chkLst1.SetItemChecked(num3, isChecked == "checked");
                }
            }

        }
    }
}
