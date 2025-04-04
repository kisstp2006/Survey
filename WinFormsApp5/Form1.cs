namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        // Define colors for dark mode and light mode as class fields
        private readonly Color darkBackground = Color.FromArgb(33, 33, 33);
        private readonly Color darkControl = Color.FromArgb(51, 51, 51);
        private readonly Color darkText = Color.FromArgb(240, 240, 240);
        private readonly Color darkAccent = Color.FromArgb(0, 122, 204);
        private readonly Color darkButton = Color.FromArgb(75, 75, 75);
        private readonly Color darkSuccessButton = Color.FromArgb(46, 139, 87);
        private readonly Color darkSubmitButton = Color.FromArgb(165, 42, 42);

        private readonly Color lightBackground = Color.White;
        private readonly Color lightControl = Color.FromArgb(250, 250, 250);
        private readonly Color lightText = Color.FromArgb(64, 64, 64);
        private readonly Color lightAccent = Color.FromArgb(0, 122, 204);
        private readonly Color lightPanel = Color.FromArgb(245, 245, 245);
        private readonly Color lightSuccessButton = Color.FromArgb(46, 204, 113);
        private readonly Color lightSubmitButton = Color.FromArgb(231, 76, 60);

        int pontszam = 0;
        int tesztszamlalo = 0;
        bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hide group boxes and buttons initially
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            // Initialize dark mode toggle
            darkModeToggle.Checked = false;
            darkModeToggle.Text = "  Sötét mód";
        }

        private void darkModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            isDarkMode = darkModeToggle.Checked;
            ApplyTheme(isDarkMode);
        }

        private void ApplyTheme(bool dark)
        {
            // Set form colors based on mode
            this.BackColor = dark ? darkBackground : lightBackground;

            // Update panels
            panel1.BackColor = dark ? darkControl : lightControl;
            panel2.BackColor = dark ? darkBackground : lightBackground;
            panel3.BackColor = dark ? darkControl : lightPanel;

            // Update group boxes
            foreach (Control control in panel2.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    groupBox.BackColor = dark ? darkControl : lightBackground;
                    groupBox.ForeColor = dark ? darkText : lightText;

                    // Update controls within group boxes
                    foreach (Control groupControl in groupBox.Controls)
                    {
                        if (groupControl is Label label)
                        {
                            label.ForeColor = dark ? darkText : lightText;
                        }
                        else if (groupControl is RadioButton radioButton)
                        {
                            radioButton.ForeColor = dark ? darkText : lightText;
                        }
                        else if (groupControl is Button btn)
                        {
                            btn.BackColor = dark ? darkSuccessButton : lightSuccessButton;
                            btn.ForeColor = Color.White;
                        }
                    }
                }
                else if (control is Button btn)
                {
                    if (btn == button6)
                    {
                        btn.BackColor = dark ? darkSubmitButton : lightSubmitButton;
                        btn.ForeColor = Color.White;
                    }
                }
            }

            // Update labels in panel3 (score panel)
            foreach (Control control in panel3.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = dark ? darkText : lightText;

                    // Keep certain labels with accent colors
                    if (label == label5 || label == label14)
                    {
                        label.ForeColor = dark ? darkAccent : lightAccent;
                    }
                    else if (label == label11)
                    {
                        // Don't change the color here as we set it conditionally elsewhere
                    }
                    else if (label == label10)
                    {
                        label.ForeColor = dark ? Color.FromArgb(231, 76, 60) : Color.FromArgb(231, 76, 60);
                    }
                }
            }

            // Update controls in panel1 (header)
            foreach (Control control in panel1.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = dark ? darkText : lightText;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = dark ? darkControl : lightBackground;
                    textBox.ForeColor = dark ? darkText : lightText;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.BackColor = dark ? darkControl : lightBackground;
                    comboBox.ForeColor = dark ? darkText : lightText;
                }
                else if (control is Button btn)
                {
                    btn.BackColor = dark ? darkAccent : lightAccent;
                    btn.ForeColor = Color.White;
                }
            }

            // Update dark mode toggle appearance
            darkModeToggle.ForeColor = dark ? darkText : Color.FromArgb(52, 73, 94);
            darkModeToggle.Text = dark ? "  Világos mód" : "  Sötét mód";
            darkModeToggle.BackColor = dark ? darkButton : Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;

            // Reset score when starting new test
            pontszam = 0;
            label5.Text = "0";
            label10.Text = "0";
            label11.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nyomd meg a gombot" + "\n" + "Akarod e beküldeni a választ?"
                , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                if (radioButton1.Checked)
                {
                    pontszam++;
                    label5.Text = pontszam.ToString();
                    button2.Visible = false;
                }
            }
            else
            {
                //do something if NO
            }

            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nyomd meg a gombot" + "\n" + "Akarod e beküldeni a választ?"
                , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                if (radioButton4.Checked)
                {
                    pontszam++;
                    label5.Text = pontszam.ToString();
                    button3.Visible = false;
                }
            }
            else
            {
                //do something if NO
            }

            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nyomd meg a gombot" + "\n" + "Akarod e beküldeni a választ?"
                , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                if (radioButton6.Checked)
                {
                    pontszam++;
                    label5.Text = pontszam.ToString();
                    button4.Visible = false;
                }
            }
            else
            {
                //do something if NO
            }

            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nyomd meg a gombot" + "\n" + "Akarod e beküldeni a választ?"
                , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                if (radioButton8.Checked)
                {
                    pontszam++;
                    label5.Text = pontszam.ToString();
                    button5.Visible = false;
                }
            }
            else
            {
                //do something if NO

            }

            groupBox4.Visible = false;
            label10.Text = pontszam.ToString();
            label10.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pontszam = 0;

            if (radioButton1.Checked)
            {
                pontszam++;
            }
            if (radioButton4.Checked)
            {
                pontszam++;
            }
            if (radioButton6.Checked)
            {
                pontszam++;
            }
            if (radioButton8.Checked)
            {
                pontszam++;
            }

            label10.Text = pontszam.ToString();

            if (pontszam == 4)
            {
                label11.Text = "MEGFELELT";
                label11.ForeColor = isDarkMode ? Color.FromArgb(46, 204, 113) : Color.FromArgb(46, 204, 113);
            }
            else
            {
                label11.Text = "NEM FELELT MEG";
                label11.ForeColor = isDarkMode ? Color.FromArgb(231, 76, 60) : Color.FromArgb(231, 76, 60);
            }

            tesztszamlalo++;
            label14.Text = tesztszamlalo.ToString();

            // Update progress bar value
            progressBar1.Value = 100;

            // Reset radio buttons
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;

            // Hide elements after submission
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}