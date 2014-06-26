using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TextBoxtest
{
    class TxtProNet:TextBox
    {
        private bool ALT;
        private bool AS;
        private bool CTRL;
        private bool ETC = true;
        private bool ETT = true;
        private Color FBC = Color.Yellow;
        private Font FF = Control.DefaultFont;
        private Color FFC = Color.Blue;
        private bool FTS = true;
        private int i;
        private Color LFBC;
        private Font LFF;
        private Color LFFC;
        private string ME = "";
        private bool MEIFS;
        private bool MER = true;
        private bool MESD;
        public string NumberToChar = "صفر";
        private bool SHIFT;
        private string STR;
        private bool TAC = true;
        private bool TDS;
        private bool TEO;
        public double TextValue;
        private bool TFO;
        private bool TNO;
        private string TOC = "";
        private bool TT;
        private SplitContainer splitContainer1;
        private string YY;

        private string Adadhoroof(double Adad)
        {
            if (Convert.ToString(Adad).Length <= 12)
            {
                this.STR = "";
                this.YY = "";
                this.i = 0;
                string str = Adad.ToString();
                if (!(str == "0.1"))
                {
                    while (str.Length != 13)
                    {
                        str = "0" + str;
                    }
                    this.i = 13;
                    while (this.i != 0)
                    {
                        this.i--;
                        if (this.i == 12)
                        {
                            this.STR = this.STR + this.Sadgan(str.Substring(1, 1));
                        }
                        if ((this.i == 11) && (str.Substring(2, 1) != "0"))
                        {
                            if (str.Substring(1, 1) != "0")
                            {
                                this.STR = this.STR + " و ";
                                this.STR = this.STR + this.Dahgan(str.Substring(2, 1), str.Substring(3, 1));
                            }
                            else
                            {
                                this.STR = this.STR + this.Dahgan(str.Substring(2, 1), str.Substring(3, 1));
                            }
                        }
                        else
                        {
                            if ((this.i == 10) && (str.Substring(3, 1) != "0"))
                            {
                                if ((str.Substring(2, 1) != "0") || (str.Substring(1, 1) != "0"))
                                {
                                    this.STR = this.STR + " و ";
                                    this.STR = this.STR + this.Yekan(str.Substring(3, 1));
                                }
                                else
                                {
                                    this.STR = this.STR + this.Yekan(str.Substring(3, 1));
                                }
                                continue;
                            }
                            if ((this.i == 9) && (Convert.ToDouble(str.Substring(1, 3)) > 0.0))
                            {
                                this.STR = this.STR + " میلیارد ";
                            }
                            if ((this.i == 9) && (str.Substring(4, 1) != "0"))
                            {
                                if (Convert.ToDouble(str.Substring(1, 3)) > 0.0)
                                {
                                    this.STR = this.STR + " و ";
                                    this.STR = this.STR + this.Sadgan(str.Substring(4, 1));
                                }
                                else
                                {
                                    this.STR = this.STR + this.Sadgan(str.Substring(4, 1));
                                }
                            }
                            else
                            {
                                if ((this.i == 8) && (str.Substring(5, 1) != "0"))
                                {
                                    if (Convert.ToDouble(str.Substring(1, 4)) > 0.0)
                                    {
                                        this.STR = this.STR + " و ";
                                        this.STR = this.STR + this.Dahgan(str.Substring(5, 1), str.Substring(6, 1));
                                    }
                                    else
                                    {
                                        this.STR = this.STR + this.Dahgan(str.Substring(5, 1), str.Substring(6, 1));
                                    }
                                    continue;
                                }
                                if ((this.i == 7) && (str.Substring(6, 1) != "0"))
                                {
                                    if (Convert.ToDouble(str.Substring(1, 5)) > 0.0)
                                    {
                                        this.STR = this.STR + " و ";
                                        this.STR = this.STR + this.Yekan(str.Substring(6, 1));
                                    }
                                    else
                                    {
                                        this.STR = this.STR + this.Yekan(str.Substring(6, 1));
                                    }
                                    continue;
                                }
                                if ((this.i == 6) && (Convert.ToDouble(str.Substring(4, 3)) > 0.0))
                                {
                                    this.STR = this.STR + " میلیون ";
                                }
                                if ((this.i == 6) && (str.Substring(7, 1) != "0"))
                                {
                                    if (Convert.ToDouble(str.Substring(1, 6)) > 0.0)
                                    {
                                        this.STR = this.STR + " و ";
                                        this.STR = this.STR + this.Sadgan(str.Substring(7, 1));
                                    }
                                    else
                                    {
                                        this.STR = this.STR + this.Sadgan(str.Substring(7, 1));
                                    }
                                    continue;
                                }
                                if ((this.i == 5) && (str.Substring(8, 1) != "0"))
                                {
                                    if (Convert.ToDouble(str.Substring(1, 7)) > 0.0)
                                    {
                                        this.STR = this.STR + " و ";
                                        this.STR = this.STR + this.Dahgan(str.Substring(8, 1), str.Substring(9, 1));
                                    }
                                    else
                                    {
                                        this.STR = this.STR + this.Dahgan(str.Substring(8, 1), str.Substring(9, 1));
                                    }
                                    continue;
                                }
                                if ((this.i == 4) && (str.Substring(9, 1) != "0"))
                                {
                                    if (Convert.ToDouble(str.Substring(1, 8)) > 0.0)
                                    {
                                        this.STR = this.STR + " و ";
                                        this.STR = this.STR + this.Yekan(str.Substring(9, 1));
                                    }
                                    else
                                    {
                                        this.STR = this.STR + this.Yekan(str.Substring(9, 1));
                                    }
                                    continue;
                                }
                                if ((this.i == 3) && (Convert.ToDouble(str.Substring(7, 3)) > 0.0))
                                {
                                    this.STR = this.STR + " هزار ";
                                }
                                if ((this.i == 3) && (str.Substring(10, 1) != "0"))
                                {
                                    if (Convert.ToDouble(str.Substring(1, 9)) > 0.0)
                                    {
                                        this.STR = this.STR + " و ";
                                        this.STR = this.STR + this.Sadgan(str.Substring(10, 1));
                                    }
                                    else
                                    {
                                        this.STR = this.STR + this.Sadgan(str.Substring(10, 1));
                                    }
                                    continue;
                                }
                                if ((this.i == 2) && (str.Substring(11, 1) != "0"))
                                {
                                    if (Convert.ToDouble(str.Substring(1, 10)) > 0.0)
                                    {
                                        this.STR = this.STR + " و ";
                                        this.STR = this.STR + this.Dahgan(str.Substring(11, 1), str.Substring(12, 1));
                                    }
                                    else
                                    {
                                        this.STR = this.STR + this.Dahgan(str.Substring(11, 1), str.Substring(12, 1));
                                    }
                                    continue;
                                }
                                if ((this.i == 1) && (str.Substring(12, 1) != "0"))
                                {
                                    if (Convert.ToDouble(str.Substring(1, 11)) > 0.0)
                                    {
                                        this.STR = this.STR + " و ";
                                        this.STR = this.STR + this.Yekan(str.Substring(12, 1));
                                        continue;
                                    }
                                    this.STR = this.STR + this.Yekan(str.Substring(12, 1));
                                }
                            }
                        }
                    }
                    return this.STR;
                }
            }
            return "ERROR";
        }

        private string Dahgan(string Ss, string m)
        {
            switch (Convert.ToInt32(Ss))
            {
                case 1:
                    this.YY = this.Zirebist(Ss, m);
                    break;

                case 2:
                    this.YY = "بيست";
                    break;

                case 3:
                    this.YY = "سي";
                    break;

                case 4:
                    this.YY = "چهل";
                    break;

                case 5:
                    this.YY = "پنجاه";
                    break;

                case 6:
                    this.YY = "شصت";
                    break;

                case 7:
                    this.YY = "هفتاد";
                    break;

                case 8:
                    this.YY = "هشتاد";
                    break;

                case 9:
                    this.YY = "نود";
                    break;
            }
            return this.YY;
        }

        private void MSGE()
        {
            if ((this.MessegeEmpty != "") && this.MessegeEmptyShowInForm)
            {
                if (((this.Text == "") || (this.TypeDateShamsi && this.Text.Contains("_"))) || (this.TypeTime && this.Text.Contains("_")))
                {
                    Label label = new Label
                    {
                        Name = base.Name + "1",
                        Text = this.MessegeEmpty,
                        AutoSize = true,
                        Font = this.Font,
                        Top = (base.Top + Convert.ToInt16((int)(base.Height / 2))) - 3,
                        ForeColor = Color.Red
                    };
                    base.FindForm().Controls.Add(label);
                    if (this.MessegeEmptyInFormRight)
                    {
                        label.Left = (base.Left + base.Width) + 5;
                    }
                    else
                    {
                        label.Left = (base.Left - label.Width) - 5;
                    }
                }
                else
                {
                    try
                    {
                        int count = base.FindForm().Controls.Count;
                        for (int i = 0; i < count; i++)
                        {
                            if (((base.FindForm().Controls[i] is Label) && (base.FindForm().Controls[i].Name == (base.Name + "1"))) && ((this.MessegeEmpty != "") && (this.Text != "")))
                            {
                                base.FindForm().Controls[i].Visible = false;
                                base.FindForm().Controls[i].Text = "";
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnEnter(EventArgs e)
        {
            this.LFBC = this.BackColor;
            this.LFFC = this.ForeColor;
            this.LFF = this.Font;
            if (this.TypeFarsiOnly && !this.TypeEnglishOnly)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));
            }
            if (!this.TypeFarsiOnly && this.TypeEnglishOnly)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("en-usa"));
            }
            this.BackColor = this.FocusBackColor;
            this.ForeColor = this.FocusForeColor;
            this.Font = this.FocusFont;
            if (this.FocusTextSelect)
            {
                base.SelectionStart = 0;
                this.SelectionLength = this.Text.Length;
            }
            base.OnEnter(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            this.CTRL = e.Control;
            this.SHIFT = e.Shift;
            this.ALT = e.Alt;
            if (this.TypeDateShamsi && (e.KeyCode.ToString() == "Delete"))
            {
                if ((base.SelectionStart == 4) || (base.SelectionStart == 7))
                {
                    e.SuppressKeyPress = true;
                    base.SelectionStart++;
                }
                else if (base.SelectionStart < 10)
                {
                    e.SuppressKeyPress = true;
                    int selectionStart = base.SelectionStart;
                    this.Text = this.Text.Substring(0, base.SelectionStart) + "_" + this.Text.Substring(base.SelectionStart + 1);
                    base.SelectionStart = selectionStart + 1;
                }
            }
            if (this.TypeTime && (e.KeyCode.ToString() == "Delete"))
            {
                if (base.SelectionStart == 2)
                {
                    e.SuppressKeyPress = true;
                    base.SelectionStart++;
                }
                else if (base.SelectionStart < 5)
                {
                    e.SuppressKeyPress = true;
                    int num2 = base.SelectionStart;
                    this.Text = this.Text.Substring(0, base.SelectionStart) + "_" + this.Text.Substring(base.SelectionStart + 1);
                    base.SelectionStart = num2 + 1;
                }
            }
            if ((Convert.ToInt32(e.KeyCode) == 13) && this.EnterToTab)
            {
                if (!this.Multiline)
                {
                    e.Handled = true;
                    base.Parent.SelectNextControl(this, true, false, true, true);
                }
                else if (!e.Control)
                {
                    e.Handled = true;
                    base.Parent.SelectNextControl(this, true, false, true, true);
                }
            }
            if ((Convert.ToInt32(e.KeyCode) == 0x1b) && this.EscToClose)
            {
                base.FindForm().Close();
            }
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((!this.Multiline || (e.KeyChar != '\n')) && !this.TypeAllChar)
            {
                string source = "";
                if (this.TypeDateShamsi)
                {
                    if (Convert.ToInt16(e.KeyChar) == 8)
                    {
                        if ((base.SelectionStart == 5) || (base.SelectionStart == 8))
                        {
                            base.SelectionStart--;
                        }
                        else if (base.SelectionStart > 0)
                        {
                            int selectionStart = base.SelectionStart;
                            this.Text = this.Text.Substring(0, base.SelectionStart - 1) + "_" + this.Text.Substring(base.SelectionStart);
                            base.SelectionStart = selectionStart - 1;
                        }
                        e.KeyChar = Convert.ToChar(0);
                        base.OnKeyPress(e);
                    }
                    else
                    {
                        if (base.SelectionStart < 10)
                        {
                            this.SelectionLength = 1;
                        }
                        if (base.SelectionStart == 0)
                        {
                            source = "12";
                        }
                        if (((base.SelectionStart == 1) || (base.SelectionStart == 2)) || (base.SelectionStart == 3))
                        {
                            source = "0123456789";
                        }
                        if (base.SelectionStart == 5)
                        {
                            source = "01";
                        }
                        if (base.SelectionStart == 6)
                        {
                            if (this.Text.Substring(5, 1) == "0")
                            {
                                source = "123456789";
                            }
                            if (this.Text.Substring(5, 1) == "1")
                            {
                                source = "012";
                            }
                        }
                        if ((base.SelectionStart == 4) || (base.SelectionStart == 7))
                        {
                            source = "/";
                            if (!source.Contains<char>(e.KeyChar))
                            {
                                base.SelectionStart++;
                            }
                        }
                        if (base.SelectionStart == 8)
                        {
                            source = "0123";
                        }
                        if (base.SelectionStart == 9)
                        {
                            if ((this.Text.Substring(8, 1) == "1") || (this.Text.Substring(8, 1) == "2"))
                            {
                                source = "1234567890";
                            }
                            if (this.Text.Substring(8, 1) == "0")
                            {
                                source = "123456789";
                            }
                            if (this.Text.Substring(8, 1) == "3")
                            {
                                if ((((this.Text.Substring(5, 2) == "01") || (this.Text.Substring(5, 2) == "02")) || ((this.Text.Substring(5, 2) == "03") || (this.Text.Substring(5, 2) == "04"))) || ((this.Text.Substring(5, 2) == "05") || (this.Text.Substring(5, 2) == "06")))
                                {
                                    source = "01";
                                }
                                else
                                {
                                    source = "0";
                                }
                            }
                        }
                        if (!source.Contains<char>(e.KeyChar))
                        {
                            e.KeyChar = Convert.ToChar(0);
                        }
                        base.OnKeyPress(e);
                    }
                }
                else if (this.TypeTime)
                {
                    if (Convert.ToInt16(e.KeyChar) == 8)
                    {
                        if (base.SelectionStart == 3)
                        {
                            base.SelectionStart--;
                        }
                        else if (base.SelectionStart > 0)
                        {
                            int num2 = base.SelectionStart;
                            this.Text = this.Text.Substring(0, base.SelectionStart - 1) + "_" + this.Text.Substring(base.SelectionStart);
                            base.SelectionStart = num2 - 1;
                        }
                        e.KeyChar = Convert.ToChar(0);
                        base.OnKeyPress(e);
                    }
                    else
                    {
                        if (base.SelectionStart < 5)
                        {
                            this.SelectionLength = 1;
                        }
                        if (base.SelectionStart == 0)
                        {
                            source = "012";
                        }
                        if (base.SelectionStart == 1)
                        {
                            if (this.Text.Substring(0, 1) == "2")
                            {
                                source = "0123";
                            }
                            else
                            {
                                source = "0123456789";
                            }
                        }
                        if (base.SelectionStart == 3)
                        {
                            source = "012345";
                        }
                        if (base.SelectionStart == 4)
                        {
                            source = "0123456789";
                        }
                        if (base.SelectionStart == 2)
                        {
                            source = ":";
                            if (!source.Contains<char>(e.KeyChar))
                            {
                                base.SelectionStart++;
                            }
                        }
                        if (!source.Contains<char>(e.KeyChar))
                        {
                            e.KeyChar = Convert.ToChar(0);
                        }
                        base.OnKeyPress(e);
                    }
                }
                else if (Convert.ToInt16(e.KeyChar) == 8)
                {
                    base.OnKeyPress(e);
                }
                else
                {
                    source = this.TypeOtherChar;
                    if (this.TypeEnglishOnly)
                    {
                        source = source + "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
                    }
                    if (this.TypeFarsiOnly)
                    {
                        source = source + "ابپتثجچحخدذرزژسشصضطظعغفقکگلمنوهیءأآـإية ";
                    }
                    if (this.TypeNumricOnly)
                    {
                        source = source + "0123456789.";
                    }
                    if ((!source.Contains<char>(e.KeyChar) && !this.CTRL) && !this.ALT)
                    {
                        e.KeyChar = Convert.ToChar(0);
                    }
                    base.OnKeyPress(e);
                }
            }
        }

        protected override void OnMultilineChanged(EventArgs e)
        {
            if ((this.TypeDateShamsi && this.Multiline) || (this.TypeTime && this.Multiline))
            {
                this.Multiline = false;
                MessageBox.Show("While TypeDateShamsi or TypeTime is true can not assign Multiline set", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            base.OnMultilineChanged(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if ((this.Text == "") && this.TypeTime)
            {
                this.Text = "__:__";
            }
            if ((this.Text == "") && this.TypeDateShamsi)
            {
                this.Text = "13__/__/__";
            }
            if (this.AutoSprator)
            {
                try
                {
                    this.Text = string.Format("{0:##,##}", Convert.ToDouble(this.Text));
                }
                catch
                {
                    if (this.Text != "-")
                    {
                        this.Text = "";
                    }
                }
                base.SelectionStart = this.Text.Length;
            }
            try
            {
                this.TextValue = Convert.ToDouble(string.Format("{0:##}", this.Text));
            }
            catch
            {
                if (this.Text == "")
                {
                    this.TextValue = 0.0;
                }
                else
                {
                    this.TextValue = -0.1;
                }
            }
            try
            {
                if (this.TextValue >= 0.0)
                {
                    this.NumberToChar = this.Adadhoroof(this.TextValue);
                }
                else
                {
                    this.NumberToChar = "منفی " + this.Adadhoroof(Math.Abs(this.TextValue));
                }
            }
            catch
            {
                this.NumberToChar = "ERROR";
            }
            this.MSGE();
            if (this.TypeDateShamsi)
            {
                if (((this.Text.Substring(5, 1) == "1") && (this.Text.Substring(6, 1) != "0")) && ((this.Text.Substring(6, 1) != "1") && (this.Text.Substring(6, 1) != "2")))
                {
                    int selectionStart = base.SelectionStart;
                    this.Text = this.Text.Substring(0, 6) + "_" + this.Text.Substring(7);
                    base.SelectionStart = selectionStart;
                }
                if (((((this.Text.Substring(5, 2) == "07") || (this.Text.Substring(5, 2) == "08")) || ((this.Text.Substring(5, 2) == "09") || (this.Text.Substring(5, 2) == "10"))) || ((this.Text.Substring(5, 2) == "11") || (this.Text.Substring(5, 2) == "12"))) && (this.Text.Substring(8) == "31"))
                {
                    int num2 = base.SelectionStart;
                    this.Text = this.Text.Substring(0, 9) + "_";
                    base.SelectionStart = num2;
                }
                if (((this.Text.Substring(8, 1) == "3") && (this.Text.Substring(9, 1) != "0")) && (this.Text.Substring(9, 1) != "1"))
                {
                    int num3 = base.SelectionStart;
                    this.Text = this.Text.Substring(0, 9) + "_";
                    base.SelectionStart = num3;
                }
            }
            if (((this.TypeTime && (this.Text.Substring(0, 1) == "2")) && ((this.Text.Substring(1, 1) != "0") && (this.Text.Substring(1, 1) != "1"))) && ((this.Text.Substring(1, 1) != "2") && (this.Text.Substring(1, 1) != "3")))
            {
                int num4 = base.SelectionStart;
                this.Text = this.Text.Substring(0, 1) + "_" + this.Text.Substring(2, 3);
                base.SelectionStart = num4;
            }
            if (this.TypeDateShamsi && ((base.SelectionStart == 4) || (base.SelectionStart == 7)))
            {
                base.SelectionStart++;
            }
            if (this.TypeTime && (base.SelectionStart == 2))
            {
                base.SelectionStart++;
            }
            if (!this.AutoSprator)
            {
                base.OnTextChanged(e);
            }
            else
            {
                base.OnTextChanged(e);
            }
        }

        protected override void OnValidated(EventArgs e)
        {
            this.BackColor = this.LFBC;
            this.ForeColor = this.LFFC;
            this.Font = this.LFF;
            this.MSGE();
            base.OnValidated(e);
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            if ((this.MessegeEmpty != "") && this.MessageEmptyShowDialog)
            {
                if ((this.Text == "") || (this.TypeDateShamsi && this.Text.Contains("_")))
                {
                    MessageBox.Show(this.MessegeEmpty, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if ((this.Text == "") || (this.TypeTime && this.Text.Contains("_")))
                {
                    MessageBox.Show(this.MessegeEmpty, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            base.OnValidating(e);
        }

        private string Sadgan(string Sad)
        {
            switch (Convert.ToInt32(Sad))
            {
                case 1:
                    this.YY = " يكصد";
                    break;

                case 2:
                    this.YY = "دويست";
                    break;

                case 3:
                    this.YY = "سيصد";
                    break;

                case 4:
                    this.YY = "چهارصد";
                    break;

                case 5:
                    this.YY = "پانصد";
                    break;

                case 6:
                    this.YY = "ششصد";
                    break;

                case 7:
                    this.YY = "هفتصد";
                    break;

                case 8:
                    this.YY = "هشتصد";
                    break;

                case 9:
                    this.YY = "نهصد";
                    break;
            }
            return this.YY;
        }

        private string Yekan(string Yek)
        {
            switch (Convert.ToInt32(Yek))
            {
                case 1:
                    this.YY = "يك";
                    break;

                case 2:
                    this.YY = "دو";
                    break;

                case 3:
                    this.YY = "سه";
                    break;

                case 4:
                    this.YY = "چهار";
                    break;

                case 5:
                    this.YY = "پنج";
                    break;

                case 6:
                    this.YY = " شش";
                    break;

                case 7:
                    this.YY = "هفت";
                    break;

                case 8:
                    this.YY = "هشت";
                    break;

                case 9:
                    this.YY = "نه";
                    break;
            }
            return this.YY;
        }

        private string Zirebist(string Ss, string m)
        {
            this.i--;
            switch (Convert.ToInt32(Ss + m))
            {
                case 10:
                    this.YY = "ده";
                    break;

                case 11:
                    this.YY = "يازده";
                    break;

                case 12:
                    this.YY = "دوازده";
                    break;

                case 13:
                    this.YY = "سيزده";
                    break;

                case 14:
                    this.YY = "چهارده";
                    break;

                case 15:
                    this.YY = "پانزده";
                    break;

                case 0x10:
                    this.YY = "شانزده";
                    break;

                case 0x11:
                    this.YY = "هفده";
                    break;

                case 0x12:
                    this.YY = "هيجده";
                    break;

                case 0x13:
                    this.YY = "نوزده";
                    break;
            }
            return this.YY;
        }

        public bool AutoSprator
        {
            get
            {
                return this.AS;
            }
            set
            {
                this.AS = value;
                if (this.AS)
                {
                    this.TypeNumricOnly = true;
                    this.TypeAllChar = false;
                    this.TypeDateShamsi = false;
                    this.TypeTime = false;
                    this.TypeEnglishOnly = false;
                    this.TypeOtherChar = "-";
                    this.MaxLength = 15;
                }
            }
        }

        public bool EnterToTab
        {
            get
            {
                return this.ETT;
            }
            set
            {
                this.ETT = value;
            }
        }

        public bool EscToClose
        {
            get
            {
                return this.ETC;
            }
            set
            {
                this.ETC = value;
            }
        }

        public Color FocusBackColor
        {
            get
            {
                return this.FBC;
            }
            set
            {
                this.FBC = value;
            }
        }

        public Font FocusFont
        {
            get
            {
                return this.FF;
            }
            set
            {
                this.FF = value;
            }
        }

        public Color FocusForeColor
        {
            get
            {
                return this.FFC;
            }
            set
            {
                this.FFC = value;
            }
        }

        public bool FocusTextSelect
        {
            get
            {
                return this.FTS;
            }
            set
            {
                this.FTS = value;
            }
        }

        public bool MessageEmptyShowDialog
        {
            get
            {
                return this.MESD;
            }
            set
            {
                this.MESD = value;
            }
        }

        public string MessegeEmpty
        {
            get
            {
                return this.ME;
            }
            set
            {
                this.ME = value;
            }
        }

        public bool MessegeEmptyInFormRight
        {
            get
            {
                return this.MER;
            }
            set
            {
                this.MER = value;
            }
        }

        public bool MessegeEmptyShowInForm
        {
            get
            {
                return this.MEIFS;
            }
            set
            {
                this.MEIFS = value;
            }
        }

        public bool TypeAllChar
        {
            get
            {
                return this.TAC;
            }
            set
            {
                this.TAC = value;
                if (this.AutoSprator && this.TypeAllChar)
                {
                    this.TAC = false;
                    MessageBox.Show("While AutoSprator is true cannot assign", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.TAC)
                {
                    if (this.TypeDateShamsi)
                    {
                        this.Text = "";
                    }
                    this.TypeDateShamsi = false;
                    if (this.TypeTime)
                    {
                        this.Text = "";
                    }
                    this.TypeTime = false;
                    this.TypeEnglishOnly = false;
                    this.TypeFarsiOnly = false;
                    this.TypeNumricOnly = false;
                    this.TypeOtherChar = "";
                }
            }
        }

        public bool TypeDateShamsi
        {
            get
            {
                return this.TDS;
            }
            set
            {
                this.TDS = value;
                if (this.AutoSprator && this.TypeDateShamsi)
                {
                    this.TypeDateShamsi = false;
                    MessageBox.Show("While AutoSprator is true cannot assign", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.TDS)
                {
                    this.TypeAllChar = false;
                    this.TypeEnglishOnly = false;
                    this.TypeFarsiOnly = false;
                    this.TypeTime = false;
                    this.TypeNumricOnly = false;
                    this.Text = "13__/__/__";
                    this.TypeOtherChar = "";
                    this.Multiline = false;
                }
                else if (!this.TypeTime)
                {
                    this.Text = "";
                }
            }
        }

        public bool TypeEnglishOnly
        {
            get
            {
                return this.TEO;
            }
            set
            {
                this.TEO = value;
                if (this.AutoSprator && this.TEO)
                {
                    this.TEO = false;
                    MessageBox.Show("While AutoSprator is true cannot assign", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.TEO)
                {
                    this.TypeAllChar = false;
                    this.TypeDateShamsi = false;
                    this.TypeTime = false;
                }
            }
        }

        public bool TypeFarsiOnly
        {
            get
            {
                return this.TFO;
            }
            set
            {
                this.TFO = value;
                if (this.AutoSprator && this.TypeFarsiOnly)
                {
                    this.TFO = false;
                    MessageBox.Show("While AutoSprator is true cannot assign", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.TFO)
                {
                    this.TypeAllChar = false;
                    this.TypeDateShamsi = false;
                    this.TypeTime = false;
                }
            }
        }

        public bool TypeNumricOnly
        {
            get
            {
                return this.TNO;
            }
            set
            {
                this.TNO = value;
                if (this.AutoSprator && !this.TypeNumricOnly)
                {
                    this.TNO = true;
                    MessageBox.Show("While AutoSprator is true cannot change", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.TNO)
                {
                    this.TypeAllChar = false;
                    this.TypeDateShamsi = false;
                    this.TypeTime = false;
                }
            }
        }

        public string TypeOtherChar
        {
            get
            {
                return this.TOC;
            }
            set
            {
                this.TOC = value;
                if (this.AutoSprator && (this.TypeOtherChar != "-"))
                {
                    this.TOC = "-";
                    MessageBox.Show("While AutoSprator is true cannot assign", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (this.TypeDateShamsi && (this.TOC != ""))
                    {
                        MessageBox.Show("While TypeDateShamsi or TypeTime is true ,can not assign value to OtherChar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.TOC = "";
                    }
                    if (this.TypeTime && (this.TOC != ""))
                    {
                        MessageBox.Show("While TypeDateShamsi or TypeTime is true ,can not assign value to OtherChar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.TOC = "";
                    }
                }
            }
        }

        public bool TypeTime
        {
            get
            {
                return this.TT;
            }
            set
            {
                this.TT = value;
                if (this.AutoSprator && this.TypeTime)
                {
                    this.TypeTime = false;
                    MessageBox.Show("While AutoSprator is true cannot assign", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.TT)
                {
                    this.TypeAllChar = false;
                    this.TypeEnglishOnly = false;
                    this.TypeFarsiOnly = false;
                    this.TypeDateShamsi = false;
                    this.TypeNumricOnly = false;
                    this.Text = "__:__";
                    this.TypeOtherChar = "";
                    this.Multiline = false;
                }
                else if (!this.TypeDateShamsi)
                {
                    this.Text = "";
                }
            }
        }

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
