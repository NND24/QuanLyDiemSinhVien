using DevExpress.XtraReports.UI;
using System;

namespace QuanLyDiemSinhVien.reports
{
    public partial class ReportHocPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHocPhi(string maLop, string nienKhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocKy;
            this.sqlDataSource1.Fill();
        }

        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = { "", "nghìn", "triệu", "tỷ" };

            bool isNegative = inputNumber < 0;
            double number = Math.Abs(inputNumber);
            string sNumber = number.ToString();

            int positionDigit = sNumber.Length;
            string result = "";

            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    int ones = positionDigit >= 1 ? sNumber[positionDigit - 1] - '0' : 0;
                    int tens = positionDigit >= 2 ? sNumber[positionDigit - 2] - '0' : -1;
                    int hundreds = positionDigit >= 3 ? sNumber[positionDigit - 3] - '0' : -1;
                    positionDigit -= 3;

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue = (placeValue + 1) % 4;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }

                    if (tens < 0) break;

                    if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                    if (tens == 1) result = "mười " + result;
                    if (tens > 1) result = unitNumbers[tens] + " mươi " + result;

                    if (hundreds < 0) break;

                    if ((hundreds > 0) || (tens > 0) || (ones > 0))
                        result = unitNumbers[hundreds] + " trăm " + result;
                }
            }

            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");
        }


        private void lblBangChu_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XRLabel label = (XRLabel)sender;
            double FieldValue = Convert.ToDouble(GetCurrentColumnValue("tongtien"));
            System.Console.WriteLine(FieldValue.ToString());
            (sender as XRLabel).Text = NumberToText(FieldValue);
        }
    }
}
