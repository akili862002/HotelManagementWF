using Guna.UI.WinForms;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hotel
{
    class Validation
    {
        public static bool IsPhoneNumber(string phone)
        {
            return phone.Length == 10;
        }
        public static bool IsEmail(string email)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            return reg.IsMatch(email);
        }
    }

    class ValidateKeyPress
    {
        KeyPressEventArgs e;
        object sender;

        public ValidateKeyPress(object sender, KeyPressEventArgs e)
        {
            this.e = e;
            this.sender = sender;
        }

        public void justAllowNumber()
        {
            if (!char.IsControl(this.e.KeyChar) && !char.IsDigit(this.e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void justAllowAlphabet()
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }

    class TextBoxValidation
    {
        CancelEventArgs e;
        GunaTextBox textBox;
        GunaLabel errorLabel;
        bool useFocus;
        bool stopVali = false;

        public TextBoxValidation(CancelEventArgs e, GunaTextBox textBox, GunaLabel errorLabel, bool useFocus = true)
        {
            this.e = e;
            this.textBox = textBox;
            this.errorLabel = errorLabel;
            this.useFocus = useFocus;
        }
        public void error(string message)
        {
            if (this.e != null)
                this.e.Cancel = true;
            if (this.useFocus)
                this.textBox.Focus();
            this.errorLabel.Text = message;
            this.errorLabel.Show();
            this.stopVali = true;
        }
        public void normal()
        {
            if (this.e != null)
                this.e.Cancel = false;
            this.errorLabel.Text = "";
            this.errorLabel.Hide();
            this.stopVali = false;
        }

        public TextBoxValidation required()
        {
            if (this.stopVali) return this;

            if (string.IsNullOrEmpty(this.textBox.Text))
            {
                this.error("Vui lòng nhập ô này!");
                return this;
            }
            this.normal();
            return this;
        }

        public TextBoxValidation isPhone()
        {
            if (this.stopVali) return this;

            if (!Validation.IsPhoneNumber(this.textBox.Text))
            {
                this.error("Số ĐT không hợp lệ!");
                return this;
            }
            this.normal();
            return this;
        }
        public TextBoxValidation isEmail()
        {
            if (this.stopVali) return this;

            if (!Validation.IsEmail(this.textBox.Text))
            {
                this.error("Email không hợp lệ!");
                return this;
            }
            this.normal();
            return this;
        }
        public TextBoxValidation minLength(int number)
        {
            if (this.stopVali) return this;

            if (this.textBox.Text.Length < number)
            {
                this.error($"Quá ngắn!, ít nhất {number} kí tự!");
                return this;
            }
            this.normal();
            return this;
        }
        public TextBoxValidation maxLength(int number)
        {
            if (this.stopVali) return this;

            if (this.textBox.Text.Length > number)
            {
                this.error($"Quá dài!, giới hạn {number} kí tự!");
                return this;
            }
            this.normal();
            return this;
        }
    }
    class UpDownValidation
    {
        CancelEventArgs e;
        NumericUpDown numUpDown;
        Label errorLabel;
        public UpDownValidation(CancelEventArgs e, NumericUpDown numUpDown, Label errorLabel)
        {
            this.e = e;
            this.numUpDown = numUpDown;
            this.errorLabel = errorLabel;
        }
        public void error(string message)
        {
            if (this.e != null)
                this.e.Cancel = true;
            this.numUpDown.Focus();
            this.errorLabel.Text = message;
            this.errorLabel.Show();
        }
        public void normal()
        {
            if (this.e != null)
                this.e.Cancel = false;
            this.errorLabel.Text = "";
            this.errorLabel.Hide();
        }
    }
    class ComboboxValidation
    {
        CancelEventArgs e;
        ComboBox comboBox;
        Label errorLabel;
        public ComboboxValidation(CancelEventArgs e, ComboBox comboBox, Label errorLabel)
        {
            this.e = e;
            this.comboBox = comboBox;
            this.errorLabel = errorLabel;
        }
        public void error(string message)
        {
            if (this.e != null)
                this.e.Cancel = true;
            this.comboBox.Focus();
            this.errorLabel.Text = message;
            this.errorLabel.Show();
        }
        public void normal()
        {
            if (this.e != null)
                this.e.Cancel = false;
            this.errorLabel.Text = "";
            this.errorLabel.Hide();
        }
    }
}
