using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace Erlang_Calculator
{
    public partial class Erlang_C : Form
    {
        public Erlang_C()
        {
            InitializeComponent();
            // set the AcceptButton property of the form to the button you want to click when the user presses Enter
            this.AcceptButton = calculate_btn;

            // set the DialogResult property of the button to OK
            calculate_btn.DialogResult = DialogResult.OK;


            // intitialize variables
            string num_calls = "";
            int aht = 260;
            float req_sla = 90;
            float shrinkage = 5;
            period_combo_bx.SelectedIndex = 0;
            TAT_combo_bx.SelectedIndex = 3;

            //text box default value
            req_sla_bx.Text = req_sla.ToString();
            AHT_s_bx.Text = aht.ToString();
            shrinkage_bx.Text = shrinkage.ToString();
            num_calls_bx.Text = num_calls.ToString();

            //number of calls


            //input validation
            OnlyAllow4DigitNumbers(num_calls_bx);
            OnlyAllow4DigitNumbers(AHT_s_bx);
            OnlyAllowNumbersBetween1And100(req_sla_bx);
            OnlyAllowNumbersBetween1And100(shrinkage_bx);

        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                float num_calls = float.Parse(num_calls_bx.Text);
                double sl = 0;
                double sla = double.Parse(req_sla_bx.Text) / 100;
                int additional = 0;
                int volumecalls = 0;

                while (sla >= sl)
                {
                    // calculation happen here

                    // parse variable
                    if (num_calls == 0)
                    {
                        additional = 1;
                    }
                    else if(num_calls == 1){
                        additional = 2;
                    }
                    float aht = float.Parse(AHT_s_bx.Text);
                    float shrinkage = float.Parse(shrinkage_bx.Text);
                    float period = 60 * Convert.ToInt16(period_combo_bx.SelectedItem.ToString());
                    //int additional = int.Parse(add_agent_bx.Text);


                    //result variable
                    if (num_calls % 45 == 0 || aht % 45 == 0)
                    {
                        num_calls = float.Parse(Convert.ToString((num_calls + 0.0001))); // to prevent overflow
                        aht = float.Parse(Convert.ToString((aht + 0.0001))); // to prevent overflow
                    }
                    volumecalls = Convert.ToInt16(num_calls);
                    float A = (num_calls * aht) / period;
                    int A_int = Convert.ToInt16(A);
                    int N = Convert.ToInt16(A) + additional;

                    //Probability of waiting variables
                    int number = N;
                    BigInteger Nfact = Factorial(number);
                    double power = Math.Pow(A, number);
                    double x1 = power / double.Parse(Nfact.ToString());
                    double x2 = (number / (number - A));
                    double y = summation(A, number);
                    double Pw = ((x2 * x1) / (y + (x2 * x1)));                            //important

                    //Service Level Variables
                    int tats = Convert.ToInt16(TAT_combo_bx.SelectedItem.ToString());
                    double exp = -1 * ((number - A) * (tats / aht));
                    double euler = Math.Exp(exp);
                    sl = 1 - (Pw * euler);                           //important


                    //Average Speed of Answer
                    double asa = (Pw * aht) / (N - A);                           //important

                    //percentage of calls answered immediately
                    double imm_answ = (1 - Pw) * 100;                           //important

                    //maximum occupancy
                    double occ = (A / N) * 100;                           //important

                    //shrinkage factor
                    double req = N / (1 - (shrinkage / 100));                           //important

                    //result[0] = volumecalls.ToString();
                    add_agents.Text = additional.ToString();
                    traffic_intesity.Text = A_int.ToString();
                    raw_agents.Text = Convert.ToInt16(N).ToString();
                    prob_wait.Text = (Pw * 100).ToString("F2") + "%";
                    sla_bx.Text = (sl * 100).ToString("F2") + "%";
                    asa_bx.Text = asa.ToString("F1") + " (s)";
                    calls_ans.Text = imm_answ.ToString("N2") + "%";
                    max_occ.Text = occ.ToString("F2") + "%";
                    w_shrinkage.Text = Convert.ToInt16(req).ToString();



                    additional++; // increment while sla >= sl
                }
            }
            catch (System.OverflowException)
            {
                //
                MessageBox.Show("Input to Large for this period!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please complete the parameters needed!");
            }

        }        
                      

        private void clear_btn_Click(object sender, EventArgs e)
        {
            // clear text box value
            num_calls_bx.Text = "";
            add_agents.Text = "";
            traffic_intesity.Text = "";
            raw_agents.Text = ""; ;
            prob_wait.Text = ""; 
            sla_bx.Text = "";
            asa_bx.Text = "";
            calls_ans.Text = "";
            max_occ.Text = "";
            w_shrinkage.Text = "";

            // intitialize variables
            //int period = 0;
            int aht = 260;
            float req_sla = 90;
            //int tat = 0;
            float shrinkage = 5;
            period_combo_bx.SelectedIndex = 0;
            TAT_combo_bx.SelectedIndex = 3;

            //text box default value
            req_sla_bx.Text = req_sla.ToString();
            AHT_s_bx.Text = aht.ToString();
            shrinkage_bx.Text = shrinkage.ToString();
            period_combo_bx.SelectedIndex = 0;
            TAT_combo_bx.SelectedIndex = 3;
        }

        private double summation(double A2, double N2)
        {
            double numTerms = N2;
            double sum = 0.0;


            for (int i = 0; i < numTerms; i++)
            {
                BigInteger factsum = Factorial(i);
                double denom = double.Parse(factsum.ToString());
                double poww = Math.Pow(A2, i);
                double term = poww / denom;
                sum += term;
            }

            return sum;
        }

        private BigInteger Factorial(int number) //factorial function
        {
            BigInteger fact = 1;

            if (number == 0)
            {
                return 1;
            }
            else
            {
                for (int i = number; i > 0; i--)
                {
                    fact *= i;
                }

                return fact;

            }
        }

        public void OnlyAllow4DigitNumbers(TextBox textBox)     //check the text box input only accept 3 digit maximum only
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Check if the key pressed is a digit or a control key
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is not a digit or a control key, set the Handled property to true
                    e.Handled = true;
                }
                else if (char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is a digit, check if the resulting text is a valid 3-digit number
                    string newText = textBox.Text + e.KeyChar;
                    if (newText.Length > 4 || !int.TryParse(newText, out int result))
                    {
                        // If the resulting text is not a valid 3-digit number, set the Handled property to true
                        e.Handled = true;
                    }
                }
            };
        }

        public void OnlyAllowNumbersBetween1And100(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Check if the key pressed is a digit or a control key
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is not a digit or a control key, set the Handled property to true
                    e.Handled = true;
                }
                else if (char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is a digit, check if the resulting text is a valid number between 1 and 100
                    string newText = textBox.Text + e.KeyChar;
                    if (!int.TryParse(newText, out int result) || result < 1 || result > 100)
                    {
                        // If the resulting text is not a valid number between 1 and 100, set the Handled property to true
                        e.Handled = true;
                    }
                }
            };
        }

    }
}
