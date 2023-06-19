using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;

namespace MainForm
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        #region Variables
        private OpenFileDialog openFileDialog;
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private bool CloseToTrayEnabled = false;
        #endregion Variables

        public MainForm()
        {
            InitializeComponent();

            materialSkinManager.AddFormToManage(this); /* MaterialSkinManager bizden manage edeceyi formu teleb edir ilk bawda */
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple200, Primary.Purple100, Primary.Purple500, Accent.Purple700, TextShade.BLACK);

            lblVersion1.Text = Application.ProductVersion;
            lblVersion2.Text = Application.ProductVersion;

            trayIcon.Visible = false; /* Ilk bawda appimizi tray-de gosterme. App Tray-e minimize edilmemiw tray-de appimizin ikonun gostermemekdir meqsed */
            trayIcon.BalloonTipTitle = "Imager"; /* App traye minimize olan kimi trey terefde baloonTip qutusunda: appin tray-e minimize olundugu barede :mesaj gorsenecek, hemin baloonTip qutusunun bawligi ne olsun? */
            trayIcon.BalloonTipText = "Imager successfully minimized to system tray."; /* App tray-e minimize olan kimi tray terefde gorsenecek olan baloonTip qutusunda ne mesaj gosterilsin? */
            trayIcon.Text = "Imager (Double click to show application)"; /* Trayde appin uzerine kursoru getirsek, balaca bir qutuda verdiyimiz Text-i gosterecek */
            trayIcon.ContextMenuStrip = trayIconContextMenu;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Reading settings
            switchTheme.CheckState = Imager.Properties.Settings.Default.ThemeStyleState == true ? CheckState.Checked : CheckState.Unchecked;
            closeToTraySwitch.CheckState = Imager.Properties.Settings.Default.CloseToTrayState == true ? CheckState.Checked : CheckState.Unchecked;
            #endregion Reading settings
        }

        #region Drag-n-Drop functionality
        /* Surukleyib buraxib, mausu panelin uzerinden cekende */
        private void pnlDropZone_DragLeave(object sender, EventArgs e)
        {
            pnlDropZone.CreateGraphics().Clear(pnlDropZone.BackColor); /* Cekilen fiquru sil, yerini rengle doldur */
            lblDragDropInfo.Text = "Choose a file or drag it here.";
        }

        /* Surukleyib panele buraxilanda */
        private async void pnlDropZone_DragDropAsync(object sender, DragEventArgs e)
        {
            pnlDropZone.Enabled = false;

            pnlDropZone.CreateGraphics().Clear(pnlDropZone.BackColor); /* Cekilen fiquru sil, yerini rengle doldur */
            lblDragDropInfo.Text = "Choose a file or drag it here.";

            lblDroppedFilesURL.Text = "";
            pbProgress.Value = 0;

            int faylSayi = 0;

            string UnsupportedFiles = null;

            List<string> Paths = new List<string>(); /* Elave olunan fayllarin yolunu saxlayacaq kolleksiya */
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                foreach (string file in droppedFiles) /* Drop olunan fayllari Drop olunmuw fayl kimi elde et */
                {
                    if (Validations.FileTypeValidation.CheckFileExtension(file, true))
                    {
                        /* Panele fayl evezine icerisinde fayllar olan papka suruklense, proqramimiz tekce papkani suruklenmiw fayl kimi qebul edecek, ancaq bize lazimdirki papka suruklense icerisindeki fayllari qebul etsin: */
                        if (Directory.Exists(file)) /* Eger fayl papka kimi movcuddursa */
                        {
                            foreach (string innerFile in Directory.GetFiles(file, "*.*", SearchOption.AllDirectories)) /* Suruklenib buraxilan butun papkalarinda icindeki papkalarda yerlewen fayllari elde edirik */
                            {
                                if (Validations.FileTypeValidation.CheckFileExtension(innerFile, false)) /* Icerideki fayl bize lazim olan extensiona sahibdirse */
                                {
                                    Paths.Add(innerFile); /* Suruklenen papkadaki faylin yolunu elave et kolleksiyaya */
                                    ++faylSayi;
                                }
                                else if (!Validations.FileTypeValidation.CheckFileExtension(innerFile, false)) /* Icerideki fayl bize lazim olan extensiona sahib deyilse */
                                {
                                    UnsupportedFiles += $"{innerFile}\n";
                                }
                            }
                        }
                        else /* Movcud deyilse demeli fayl suruklenib */
                        {
                            lblDroppedFilesURL.Text = "";
                            Paths.Add(file); /* Suruklenen faylin yolunu elave et kolleksiyaya */
                            ++faylSayi;
                        }

                        lblDroppedFilesURL.Text += string.Join("\n", Paths); /* Suruklenib buraxilan fayllarin yolunu yazdir labela */
                    }
                    else
                    {
                        UnsupportedFiles += $"{file}\n";
                        lblDroppedFilesURL.Text = "";
                        lblDroppedFilesURL.Text += $"\n\n> Unsupported files: \n{UnsupportedFiles}\n".Trim();
                        pnlDropZone.Enabled = true;

                        return;
                    }
                }
            }
            catch { /* Suruwdurulen fayla icazemiz olmasa ve s. */ }

            if (UnsupportedFiles != null) { lblDroppedFilesURL.Text += $"\n\n> Unsupported files: \n{UnsupportedFiles}\n".Trim(); }

            string dataForClipboard = string.Empty;
            pbProgress.Maximum = faylSayi;
            foreach (string Url in await Helpers.UploadImage.UploadImgbbAsync(Paths))
            {
                dataForClipboard += (Url + "\n");
                ++pbProgress.Value;
            }
            if (dataForClipboard != string.Empty)
            {
                Clipboard.SetText(dataForClipboard);
                lblDroppedFilesURL.Text = ($"READY:\n{dataForClipboard}\n" + lblDroppedFilesURL.Text);
            }
            else { Clipboard.SetText(Clipboard.GetText()); }

            /* Clipboard.SetText(dataForClipboard == string.Empty ? Clipboard.GetText() : dataForClipboard); */

            pnlDropZone.Enabled = true;
        }

        /* Suruklenen fayl panelin uzerine gelende */
        private void pnlDropZone_DragEnter(object sender, DragEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 2)) /* Xet qara rengde, qalinligi 2px olsun */
            {
                /* Qelemle qiriq-qiriq xetler cekilecek, xetlerse verdiyimiz wablon esasinda cekilecek: */
                pen.DashPattern = new float[] { 4, 2 }; /* { Her bir qiriq xettin uzunlugu ve xetlerin aralarindaki bowluqlar } */

                using (Graphics graph = pnlDropZone.CreateGraphics())
                {
                    /* Oval daire cekende, xetler seliqeli cekilsin. Adi halda oval dairenin xetleri eyri-uyru cekilirse, xetleri daha seliqe cekir: */
                    // graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    /* Pen obyektine esasen(qalinligi,rengi,stili ve s.) Kvadrat cek. x(1) ve y(1) pozisiyalari - kvadratin sol ust hissesini cekmeye bawlamaq istediyimiz kordinatdir. width ve height ise cekeceyimiz kvadratin geniwliyi ve hundurluyudur: */
                    graph.DrawRectangle(pen, 1, 1, pnlDropZone.Width - 2, pnlDropZone.Height - 2);
                }
            }

            /* Evente gelen e arqumentindeki Datani Drop olunan fayl kimi elde et, metod geriye boolean dondurur, Drop olundusa true eks halda false */
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                lblDragDropInfo.Text = "Drop files here.";
                e.Effect = DragDropEffects.Copy; /* Fayli surukleyib panel uzerine gelende kopyalanma effekti ver */
            }
        }

        /* Uzerine suruklenecek fayllari qebul edecek olan Panele kliklenende:  */
        private void pnlDropZone_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\" + Environment.UserName + @"\desktop",
                Filter = "Images Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tif;*.webp;*.heic;*.pdf)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tif;*.webp;*.heic;*.pdf",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileURL in openFileDialog.FileNames)
                    lblDroppedFilesURL.Text += fileURL + "\n";
            }
        }

        private void lblDragDropInfo_Click(object sender, EventArgs e)
        {
            pnlDropZone_Click(sender, e);
        }
        #endregion Drag-n-Drop functionality

        #region Settings tab
        #region Theme switching setting
        private void switchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (switchTheme.CheckState == CheckState.Unchecked)
            {
                switchTheme.Text = "Light theme";
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple200, Primary.Purple100, Primary.Purple500, Accent.Purple700, TextShade.BLACK);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                Imager.Properties.Settings.Default.ThemeStyleState = switchTheme.CheckState == CheckState.Checked ? true : false;
                Imager.Properties.Settings.Default.Save();
                Imager.Properties.Settings.Default.Reload();
                //Imager.Properties.Settings.Default.Upgrade();
            }
            else if (switchTheme.CheckState == CheckState.Checked)
            {
                switchTheme.Text = "Dark theme";
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple200, Primary.Purple700, Primary.Purple500, Accent.Purple700, TextShade.WHITE);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                Imager.Properties.Settings.Default.ThemeStyleState = switchTheme.CheckState == CheckState.Checked ? true : false;
                Imager.Properties.Settings.Default.Save();
                Imager.Properties.Settings.Default.Reload();
                //Imager.Properties.Settings.Default.Upgrade();
            }
        }
        #endregion Theme switching setting

        #region Tray functionality
        private void closeToTraySwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(closeToTraySwitch.CheckState == CheckState.Unchecked)
            {
                CloseToTrayEnabled = false;

                Imager.Properties.Settings.Default.CloseToTrayState = closeToTraySwitch.CheckState == CheckState.Checked ? true : false;
                Imager.Properties.Settings.Default.Save();
                Imager.Properties.Settings.Default.Reload();
                //Imager.Properties.Settings.Default.Upgrade();
            }
            else if (closeToTraySwitch.CheckState == CheckState.Checked)
            {
                CloseToTrayEnabled = true;

                Imager.Properties.Settings.Default.CloseToTrayState = closeToTraySwitch.CheckState == CheckState.Checked ? true : false;
                Imager.Properties.Settings.Default.Save();
                Imager.Properties.Settings.Default.Reload();
                //Imager.Properties.Settings.Default.Upgrade();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CloseToTrayEnabled)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    e.Cancel = true;
                    this.Hide();
                    trayIcon.Visible = true;
                    trayIcon.ShowBalloonTip(2000);
                }
                else
                {
                    trayIcon.Visible = false;
                }
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) /* Mausun yalniz sol(mouse1) knopkasi double kliklense acilsin */
            {
                this.Show();
                trayIcon.Visible = false;
                WindowState = FormWindowState.Normal;
            }
        }

        #region Tray icon context menu
        private void imagerApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            tabMain.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            tabSettings.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); /* Applicationi 0 bildiriw kodu ile bagla, 0 yeniki proqram problemsiz baglanib (+ Application.Exit() iwlemedi) */
        }
        #endregion Tray icon context menu
        #endregion Tray functionality
        #endregion Settings tab

        #region Diger sazlamalar
        /* Formun hecminin deyiwdirilmesinin qarwisini alaq: */
        private void MainForm_Resize(object sender, EventArgs e)
        {
            /* Form ekranin kenarlarina getirilende formun hecmi deyiwmesin, deyiwende formun gozu-qawi qacir, Borderide FixedSingle ve s. etdiyim zaman Minimize knopkasi iwlemir, bu sebeble formun borderi None-dir ve bu wekilde bloklayiram ekranin kenarlarina formun yerlewdirilmesini (ki, formun hecmi deyiwmesin): */
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();
        }
        #endregion Diger sazlamalar
    }
}