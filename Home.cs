using Bisection_Calculator.types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bisection_Calculator
{
    public partial class Home : Form
    {
        static readonly string api_endpoint = "https://bisection-calculator.herokuapp.com/bisection";
        static readonly HttpClient client = new HttpClient();
        private BracketResult[] bracket_results = { };

        public Home()
        {
            InitializeComponent();
        }

        private async void btn_calculate_Click(object sender, EventArgs e)
        {
            enableInputs(false);

            // Create request body
            var body = new BisectionPostRequest
            {
                equation = txt_equation.Text,
                ea = txt_ea.Text,
                places = (int) num_places.Value,
                range = (int) num_range.Value
            };

            try
            {
                // Send request
                HttpResponseMessage response = await client.PostAsync(api_endpoint, body, new JsonMediaTypeFormatter());

                // Deserialize response
                var result = await response.Content.ReadAsAsync<BisectionPostResponse>();

                // Check if theres an error
                if (response.StatusCode != System.Net.HttpStatusCode.OK) throw new Exception(result.error);

                resetOutputs();


                // Function Limits

                var x = new ListViewItem("x");
                var fx = new ListViewItem("f(x)");
                lv_fxLimits.Columns.Add(null, 35, HorizontalAlignment.Center);

                foreach (var fx_limit_value in result.fx_limit_values)
                {
                    x.SubItems.Add(fx_limit_value.x.ToString());
                    fx.SubItems.Add(fx_limit_value.fx.ToString());
                    lv_fxLimits.Columns.Add(null, 60, HorizontalAlignment.Center);
                }
                lv_fxLimits.Items.Add(x);
                lv_fxLimits.Items.Add(fx);


                // Bracket

                foreach (var bracket in result.possible_brackets)
                {
                    var bracket_str = $"[{bracket.x0}, {bracket.x1}]";
                    cb_iBracket.Items.Add(bracket_str);
                    lv_pBrackets.Items.Add(bracket_str);
                }
                if (result.possible_brackets.Length > 0) cb_iBracket.SelectedIndex = 0;

                // Result

                bracket_results = result.bracket_results;

                updateResult();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bisection Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                enableInputs(true);
            }
        }

        private void cb_iBracket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_iBracket.Enabled) updateResult();
        }

        private void updateResult()
        {
            lv_result.Items.Clear();
            tb_root.Clear();

            var index = cb_iBracket.SelectedIndex;
            if (index < 0) return;

            var bracket = bracket_results[index];

            for (var i = 0; i < bracket.results.Length; i++)
            {
                var result = bracket.results[i];

                var item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(result.x0.ToString());
                item.SubItems.Add(result.x1.ToString());
                item.SubItems.Add(result.x2.ToString());
                item.SubItems.Add(result.fx2.ToString());
                item.SubItems.Add(i > 0 ? result.Ea.ToString() : "");

                lv_result.Items.Add(item);
            }

            tb_root.Text = bracket.results[bracket.results.Length - 1].x2.ToString();
        }

        private void enableInputs(bool enable)
        {
            btn_calculate.Enabled = enable;
            txt_equation.Enabled = enable;
            txt_ea.Enabled = enable;
            num_places.Enabled = enable;
            num_range.Enabled = enable;

            cb_iBracket.Enabled = enable;
        }

        private void resetOutputs()
        {
            lv_fxLimits.Clear();

            cb_iBracket.Items.Clear();
            lv_pBrackets.Clear();

            lv_result.Items.Clear();
            tb_root.Clear();
        }
    }
}
