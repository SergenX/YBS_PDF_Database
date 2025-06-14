using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Ank_PDF_Database
{
    public partial class DatabaseFounder_Form : Form
    {
        private string settingsFile;
        string Current_Location;

        public DatabaseFounder_Form()
        {
            InitializeComponent();
            settingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.txt");
            this.Load += DatabaseFounder_Form_Load;
            linkLabel1.Links.Clear();
            Found_Box.Items.Clear();
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/SergenX/");
        }

        public bool Database_Lister(string Target_Database_Location)
        {
            progressBar1.Value = 0;
            progressBar1.BackColor = SystemColors.Control;
            if (Directory.Exists(Target_Database_Location))
            {
                Current_Location = Target_Database_Location;
                string[] dosyalar = Directory.GetFiles(Target_Database_Location);
                if (dosyalar.Length == 0)
                {
                    Status_Indicator.ForeColor = Color.Yellow;
                    Status_Indicator.Text = "Database Bulundu Ancak Boþ!";
                }
                else
                {
                    foreach (string dosya in dosyalar)
                    {
                        Found_Box.Items.Add(Path.GetFileName(dosya));
                    }
                    Status_Indicator.ForeColor = Color.Green;
                    Status_Indicator.Text = "Database Bulundu Dosyalar Var!";              
                }
            }
            else
            {
                Current_Location = File.ReadAllText(settingsFile).Trim();
                Status_Indicator.ForeColor = Color.Red;
                Status_Indicator.Text = "Database Bulunamadý!";
                progressBar1.Value = 100;
                progressBar1.BackColor = Color.Red;
            }
            progressBar1.Value = 100; //Process finished Indicator.
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Found_Box.Items.Clear();
            if (Database_Selector_Box.SelectedItem != null)
            {
                string Selected_Folder = Database_Selector_Box.SelectedItem.ToString();
                switch (Selected_Folder)
                {
                    case "2023-2024":
                        Database_Lister(File.ReadAllText(settingsFile).Trim() + Selected_Folder);
                        break;
                    case "2024-2025":
                        Database_Lister(File.ReadAllText(settingsFile).Trim() + Selected_Folder);
                        break;
                    case "2025-2026":
                        Database_Lister(File.ReadAllText(settingsFile).Trim() + Selected_Folder);
                        break;
                    case "Daha Eski":
                        Database_Lister(File.ReadAllText(settingsFile).Trim() + Selected_Folder);
                        break;
                    case "Ek Medya":
                        Database_Lister(File.ReadAllText(settingsFile).Trim() + Selected_Folder);
                        break;
                    default:
                        label1.BackColor = SystemColors.Control;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öðe seçin!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string targetUrl = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(targetUrl))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = targetUrl,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Baðlantý açýlamadý: " + ex.Message);
                }
            }
        }

        void Folder_Opener_Process()
        {
            string Selected_File = Found_Box.SelectedItem.ToString();
            if (Selected_File != null)
            {
                {
                    string Process_Location = Path.Combine(Current_Location, Selected_File);
                    if (File.Exists(Process_Location))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(new ProcessStartInfo
                            {
                                FileName = Process_Location,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hata : Dosya Açýlamadý!");
                        }
                    }
                    else
                    {
                            MessageBox.Show("Hata : Geçersiz Dosya Yolu");
                    }
                }
            }
        }
        private void Found_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Folder_Opener_Process();
        }

        private void Found_Box_DoubleClick(object sender, EventArgs e)
        {
        }

        private void DatabaseFounder_Form_Load(object sender, EventArgs e)
        {
            string settingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.txt");
            Database_Selector_Box.DropDownStyle = ComboBoxStyle.DropDownList;
            if (!File.Exists(settingsFile))
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Lütfen Database Klasörünü Seçiniz!";
                    fbd.ShowNewFolderButton = false;

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        string path = fbd.SelectedPath;

                        // Sonunda slash yoksa ekle
                        if (!path.EndsWith(Path.DirectorySeparatorChar.ToString()))
                        {
                            path += Path.DirectorySeparatorChar;
                        }

                        File.WriteAllText(settingsFile, path);

                        MessageBox.Show("Dosya yolunuz ayarlanmýþtýr, eðer yanlýþ ayarladýysanýz sað alttan uygulamayý sýfýrlayabilirsiniz.");
                    }
                    else
                    {
                        MessageBox.Show("Database Klasörü Seçilmedi, Program Kapatýlýyor...");
                        this.Close();
                        return;
                    }
                }
            }
        }

        private void Reset_App_Click(object sender, EventArgs e)
        {
            string settingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.txt");

            if (File.Exists(settingsFile))
            {
                try
                {
                    File.Delete(settingsFile);
                    MessageBox.Show("settings.txt dosyasý silindi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya silinirken hata oluþtu:\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("settings.txt dosyasý bulunamadý.");
            }
        }
    }
}