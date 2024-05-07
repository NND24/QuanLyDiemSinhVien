using DevExpress.XtraReports.UI;
using System;

namespace QuanLyDiemSinhVien.reports
{
    public partial class ReportHocPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHocPhi(string maLop, string NienKhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = NienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocKy;
            this.sqlDataSource1.Fill();
        }

        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // Convert the number to string and check if it's negative
            string sNumber = inputNumber.ToString();
            double number = inputNumber;
            if (number < 0)
            {
                // If negative, make it positive for conversion
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }

            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first
            string result = "";

            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();

            // Add "Âm" only if the number is negative
            if (isNegative)
            {
                result = "Âm " + result;
            }

            return result + (suffix ? " đồng chẵn" : "");
        }


        private void lblBangChu_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XRLabel label = (XRLabel)sender;
            // Retrieve the value of lblTongTien from the report's dataset
            double fieldValue = Convert.ToDouble(GetCurrentColumnValue("lblTongTien"));

            // Convert the numeric value to text using the NumberToText method
            string textValue = NumberToText(fieldValue);

            // Set the text of the label to the converted text value
            label.Text = textValue;
        }

    }
}
