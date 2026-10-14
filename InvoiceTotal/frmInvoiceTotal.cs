namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {        
            try
            {
                decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                decimal discountPct = .25m;
                decimal discountAmt = Math.Round(subtotal * discountPct, 2);
                decimal invoiceTotal = Math.Round(subtotal - discountAmt, 2);

                


                txtDiscountPct.Text = discountPct.ToString("p1");
                txtDiscountAmt.Text = discountAmt.ToString("c");
                txtTotal.Text = invoiceTotal.ToString("c");

                if (subtotal <= 0)
                {
                    throw new Exception();
                }
                if (subtotal >= 10000)
                {
                    throw new OverflowException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a valid number for the Subtotal field.",
                    "Entry Error");
            }
            catch (OverflowException)
            {
                
                MessageBox.Show(
                    "Please enter a smaller Number" +
                    " NumberOverFlowException", "Entry Error");
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Monthly investment must be greater than 0.", "Entry Error");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {

        }
    }
}